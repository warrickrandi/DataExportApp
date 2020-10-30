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

namespace DataExportApp.App_Data
{
    public class DBConnection
    {
        [NonSerialized]
        public OracleConnection con = new OracleConnection();
        [NonSerialized]
        public OracleCommand cmd = new OracleCommand();
        [NonSerialized]
        public OracleTransaction tr;
        [NonSerialized]
        public OracleDataReader dr;
        [NonSerialized]
        public OracleDataAdapter Ad;
        public DBConnection()
        {
           con.ConnectionString = ConfigurationManager.ConnectionStrings["dbString"].ToString();

            try
            {
                this.con.Open();
                this.cmd.Connection = con;
                this.tr = con.BeginTransaction();
                this.cmd.Transaction = tr;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Commit()
        {
            tr.Commit();
            this.cmd.Dispose();
            this.con.Close();
            this.con.Dispose();
        }
        public void RollBack()
        {
            this.tr.Rollback();
            this.cmd.Dispose();
            this.con.Close();
            this.con.Dispose();
        }
    }
}
