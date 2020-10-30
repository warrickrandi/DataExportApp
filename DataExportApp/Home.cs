using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Configuration;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DataExportApp.App_Data;

namespace DataExportApp
{
    public partial class Home : Form
    {

        DataTable dataTable = null;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Text = "Export Data to Oracle Server";
            this.CausesValidation = false;
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.ExportMethod();
            }
        }


        public void ExportMethod()
        {
            string ODBCSchema = txtODBCSchema.Text.Trim();
            string ODBCTable = txtODBCTable.Text.Trim();
            string OracleSchema = txtOracleSchema.Text.Trim();
            string OracleTable = txtOracleTable.Text.Trim();

            DBConnection dbConnection = new DBConnection();
            btnExport.Enabled = false;
            OdbcConnection con = new OdbcConnection("DSN=PRODDSN;UID=INTERNET;PWD=INTERNET");
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            OdbcCommand cmd = new OdbcCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM "+ODBCSchema+"."+ODBCTable+"";
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                dataTable = new DataTable();
                da.Fill(dataTable);

                int rowCount = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    this.InsertDataRow(row, OracleSchema, OracleTable, dbConnection);
                    rowCount++;
                }

                MessageBox.Show(rowCount + " rows inserted!");
                Reset();
            }
            catch(Exception  exp)
            {
                MessageBox.Show("Export Failed : " + exp.Message);
                dbConnection.RollBack();
                btnExport.Enabled = true;
            }
            finally
            {
                con.Close();
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();

                }
                btnExport.Enabled = true;
            }
        }

        public void InsertDataRow(DataRow row,string OracleSchema,string OracleTable,DBConnection dbConnection)
        {
            dbConnection.cmd = CreateInsertCommand(row, OracleSchema, OracleTable,dbConnection.cmd);
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.ExecuteNonQuery();
        }

        public static OracleCommand CreateInsertCommand(DataRow row, string OracleSchema, string OracleTable,OracleCommand command)
        {
            DataTable dataTable = row.Table;
            string sql = CreateInsertSQL(dataTable, OracleSchema, OracleTable);
            command.Parameters.Clear();
            command.CommandText = sql;
            command.CommandType = System.Data.CommandType.Text;

            foreach (DataColumn column in dataTable.Columns)
            {
                if (!column.AutoIncrement)
                {
                    string parameterName = column.ColumnName;
                    InsertParameter(command, parameterName,
                                      column.ColumnName,
                                      row[column.ColumnName]);
                }
            }
            return command;

        }

        public static void InsertParameter(OracleCommand command,string paraName, string column, object value)
        {
            OracleParameter parameter = new OracleParameter(paraName, value);
            parameter.Direction = ParameterDirection.Input;
            parameter.ParameterName = paraName;
            parameter.SourceColumn = column;
            parameter.SourceVersion = DataRowVersion.Current;
            command.Parameters.Add(parameter);
        }


        public static string CreateInsertSQL(DataTable dataTable, string OracleSchema, string OracleTable)
        {
            StringBuilder sql = new StringBuilder("INSERT INTO " + OracleSchema + "." + OracleTable + " (");
            StringBuilder values = new StringBuilder("VALUES (");

            bool bFirst = true;
            bool bIdentity = false;
            string identityType = null;

            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.AutoIncrement)
                {
                    bIdentity = true;

                    switch (column.DataType.Name)
                    {
                        case "Int16":
                            identityType = "smallint";
                            break;
                        case "Int32":
                            identityType = "int";
                            break;
                        case "SByte":
                            identityType = "tinyint";
                            break;
                        case "Int64":
                            identityType = "bigint";
                            break;
                        case "Decimal":
                            identityType = "decimal";
                            break;
                        default:
                            identityType = "string";
                            break;
                    }
                }
                else
                {
                    if (bFirst)
                        bFirst = false;
                    else
                    {
                        sql.Append(", ");
                        values.Append(", ");
                    }

                    sql.Append(column.ColumnName);
                    values.Append(":");
                    values.Append(column.ColumnName);
                }
            }
            sql.Append(") ");
            sql.Append(values.ToString());
            sql.Append(")");

            if (bIdentity)
            {
                sql.Append("; SELECT CAST(scope_identity() AS ");
                sql.Append(identityType);
                sql.Append(")");
            }

            return sql.ToString(); ;

        }


        private void txtODBCSchema_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtODBCSchema, epODBCSchema, e, "Please enter the Schema Name");
        }

        private void txtODBCTable_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtODBCTable, epODBCTable, e, "Please enter the Table Name");
        }

        private void txtOracleSchema_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtOracleSchema, epOracleSchema, e, "Please enter the Schema Name");
        }

        private void txtOracleTable_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtOracleTable, epOracleTable, e, "Please enter the Table Name");
        }

        private void requiredValidator(TextBox textbox, ErrorProvider errorProvider, CancelEventArgs e, string msg)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                e.Cancel = true;
                textbox.Focus();
                errorProvider.SetError(textbox, msg);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textbox, null);
            }
        }

        public void Reset()
        {
            txtODBCSchema.Text = "";
            txtODBCTable.Text = "";
            txtOracleSchema.Text = "";
            txtOracleTable.Text = "";
        }


    }
}
