namespace DataExportApp
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtODBCTable = new System.Windows.Forms.TextBox();
            this.txtODBCSchema = new System.Windows.Forms.TextBox();
            this.lblODBCTable = new System.Windows.Forms.Label();
            this.lblODBCSchema = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOracleTable = new System.Windows.Forms.TextBox();
            this.txtOracleSchema = new System.Windows.Forms.TextBox();
            this.lblOracleTable = new System.Windows.Forms.Label();
            this.lblOracleSchema = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.epODBCSchema = new System.Windows.Forms.ErrorProvider(this.components);
            this.epODBCTable = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOracleSchema = new System.Windows.Forms.ErrorProvider(this.components);
            this.epOracleTable = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epODBCSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epODBCTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOracleSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOracleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtODBCTable);
            this.groupBox1.Controls.Add(this.txtODBCSchema);
            this.groupBox1.Controls.Add(this.lblODBCTable);
            this.groupBox1.Controls.Add(this.lblODBCSchema);
            this.groupBox1.Location = new System.Drawing.Point(37, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ODBC Table Details";
            // 
            // txtODBCTable
            // 
            this.txtODBCTable.Location = new System.Drawing.Point(143, 77);
            this.txtODBCTable.Name = "txtODBCTable";
            this.txtODBCTable.Size = new System.Drawing.Size(273, 22);
            this.txtODBCTable.TabIndex = 3;
            this.txtODBCTable.Validating += new System.ComponentModel.CancelEventHandler(this.txtODBCTable_Validating);
            // 
            // txtODBCSchema
            // 
            this.txtODBCSchema.Location = new System.Drawing.Point(143, 42);
            this.txtODBCSchema.Name = "txtODBCSchema";
            this.txtODBCSchema.Size = new System.Drawing.Size(273, 22);
            this.txtODBCSchema.TabIndex = 2;
            this.txtODBCSchema.Validating += new System.ComponentModel.CancelEventHandler(this.txtODBCSchema_Validating);
            // 
            // lblODBCTable
            // 
            this.lblODBCTable.AutoSize = true;
            this.lblODBCTable.Location = new System.Drawing.Point(46, 80);
            this.lblODBCTable.Name = "lblODBCTable";
            this.lblODBCTable.Size = new System.Drawing.Size(44, 17);
            this.lblODBCTable.TabIndex = 1;
            this.lblODBCTable.Text = "Table";
            // 
            // lblODBCSchema
            // 
            this.lblODBCSchema.AutoSize = true;
            this.lblODBCSchema.Location = new System.Drawing.Point(46, 42);
            this.lblODBCSchema.Name = "lblODBCSchema";
            this.lblODBCSchema.Size = new System.Drawing.Size(59, 17);
            this.lblODBCSchema.TabIndex = 0;
            this.lblODBCSchema.Text = "Schema";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOracleTable);
            this.groupBox2.Controls.Add(this.txtOracleSchema);
            this.groupBox2.Controls.Add(this.lblOracleTable);
            this.groupBox2.Controls.Add(this.lblOracleSchema);
            this.groupBox2.Location = new System.Drawing.Point(37, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oracle Table Details";
            // 
            // txtOracleTable
            // 
            this.txtOracleTable.Location = new System.Drawing.Point(143, 87);
            this.txtOracleTable.Name = "txtOracleTable";
            this.txtOracleTable.Size = new System.Drawing.Size(273, 22);
            this.txtOracleTable.TabIndex = 5;
            this.txtOracleTable.Validating += new System.ComponentModel.CancelEventHandler(this.txtOracleTable_Validating);
            // 
            // txtOracleSchema
            // 
            this.txtOracleSchema.Location = new System.Drawing.Point(143, 46);
            this.txtOracleSchema.Name = "txtOracleSchema";
            this.txtOracleSchema.Size = new System.Drawing.Size(273, 22);
            this.txtOracleSchema.TabIndex = 4;
            this.txtOracleSchema.Validating += new System.ComponentModel.CancelEventHandler(this.txtOracleSchema_Validating);
            // 
            // lblOracleTable
            // 
            this.lblOracleTable.AutoSize = true;
            this.lblOracleTable.Location = new System.Drawing.Point(46, 87);
            this.lblOracleTable.Name = "lblOracleTable";
            this.lblOracleTable.Size = new System.Drawing.Size(44, 17);
            this.lblOracleTable.TabIndex = 3;
            this.lblOracleTable.Text = "Table";
            // 
            // lblOracleSchema
            // 
            this.lblOracleSchema.AutoSize = true;
            this.lblOracleSchema.Location = new System.Drawing.Point(46, 49);
            this.lblOracleSchema.Name = "lblOracleSchema";
            this.lblOracleSchema.Size = new System.Drawing.Size(59, 17);
            this.lblOracleSchema.TabIndex = 2;
            this.lblOracleSchema.Text = "Schema";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(217, 396);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(108, 33);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // epODBCSchema
            // 
            this.epODBCSchema.ContainerControl = this;
            // 
            // epODBCTable
            // 
            this.epODBCTable.ContainerControl = this;
            // 
            // epOracleSchema
            // 
            this.epOracleSchema.ContainerControl = this;
            // 
            // epOracleTable
            // 
            this.epOracleTable.ContainerControl = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 466);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Export Data to Oracle Server";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epODBCSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epODBCTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOracleSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epOracleTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtODBCTable;
        private System.Windows.Forms.TextBox txtODBCSchema;
        private System.Windows.Forms.Label lblODBCTable;
        private System.Windows.Forms.Label lblODBCSchema;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOracleTable;
        private System.Windows.Forms.TextBox txtOracleSchema;
        private System.Windows.Forms.Label lblOracleTable;
        private System.Windows.Forms.Label lblOracleSchema;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ErrorProvider epODBCSchema;
        private System.Windows.Forms.ErrorProvider epODBCTable;
        private System.Windows.Forms.ErrorProvider epOracleSchema;
        private System.Windows.Forms.ErrorProvider epOracleTable;
    }
}

