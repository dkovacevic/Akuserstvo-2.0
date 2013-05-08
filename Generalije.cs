using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for Generalije.
	/// </summary>
	public class Generalije : System.Windows.Forms.UserControl
	{
#region
		private System.Windows.Forms.GroupBox groupBox33;
		private System.Windows.Forms.Label label97;
		private System.Windows.Forms.Label label96;
		private System.Windows.Forms.Label label95;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label103;
		private System.Windows.Forms.Label label100;
		private System.Windows.Forms.TextBox ImeTB;
		private System.Windows.Forms.TextBox PrezimeTB;
        private System.Windows.Forms.TextBox jmbgTB;
        private IContainer components;
		private System.Windows.Forms.DateTimePicker rodjenaDP;		
		private System.Windows.Forms.TextBox mestoTB;
		private System.Windows.Forms.TextBox zanimanjeTB;
		private System.Windows.Forms.TextBox adresaTB;
		private System.Windows.Forms.TextBox telefonTB;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private ParovicDS parovicDS1;
		private System.Data.DataView dataView1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox tPacijentID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Data.SqlClient.SqlCommand getLastPatientIDsqlCmd;
        private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Label label1;
#endregion


        public Generalije()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();            
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generalije));
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tPacijentID = new System.Windows.Forms.TextBox();
            this.dataView1 = new System.Data.DataView();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.telefonTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jmbgTB = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.rodjenaDP = new System.Windows.Forms.DateTimePicker();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.ImeTB = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.PrezimeTB = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.mestoTB = new System.Windows.Forms.TextBox();
            this.adresaTB = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.zanimanjeTB = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.getLastPatientIDsqlCmd = new System.Data.SqlClient.SqlCommand();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox33.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.label3);
            this.groupBox33.Controls.Add(this.tPacijentID);
            this.groupBox33.Controls.Add(this.label2);
            this.groupBox33.Controls.Add(this.textBox1);
            this.groupBox33.Controls.Add(this.telefonTB);
            this.groupBox33.Controls.Add(this.label1);
            this.groupBox33.Controls.Add(this.jmbgTB);
            this.groupBox33.Controls.Add(this.label97);
            this.groupBox33.Controls.Add(this.rodjenaDP);
            this.groupBox33.Controls.Add(this.label96);
            this.groupBox33.Controls.Add(this.label95);
            this.groupBox33.Controls.Add(this.ImeTB);
            this.groupBox33.Controls.Add(this.label56);
            this.groupBox33.Controls.Add(this.PrezimeTB);
            this.groupBox33.Controls.Add(this.label52);
            this.groupBox33.Controls.Add(this.mestoTB);
            this.groupBox33.Controls.Add(this.adresaTB);
            this.groupBox33.Controls.Add(this.label100);
            this.groupBox33.Controls.Add(this.zanimanjeTB);
            this.groupBox33.Controls.Add(this.label103);
            this.groupBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox33.Location = new System.Drawing.Point(8, 16);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(432, 383);
            this.groupBox33.TabIndex = 1;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Pacijentkinja";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Srednje ime:";
            // 
            // tPacijentID
            // 
            this.tPacijentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "PacijentID", true));
            this.tPacijentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPacijentID.Location = new System.Drawing.Point(160, 344);
            this.tPacijentID.Name = "tPacijentID";
            this.tPacijentID.ReadOnly = true;
            this.tPacijentID.Size = new System.Drawing.Size(48, 26);
            this.tPacijentID.TabIndex = 21;
            this.tPacijentID.TabStop = false;
            // 
            // dataView1
            // 
            this.dataView1.Table = this.parovicDS1.Pacijent;
            // 
            // parovicDS1
            // 
            this.parovicDS1.DataSetName = "ParovicDS";
            this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.parovicDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "PacijentID:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Ime Srednje", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 1;
            // 
            // telefonTB
            // 
            this.telefonTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Telefon", true));
            this.telefonTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonTB.Location = new System.Drawing.Point(160, 312);
            this.telefonTB.Name = "telefonTB";
            this.telefonTB.Size = new System.Drawing.Size(256, 26);
            this.telefonTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Telefon:";
            // 
            // jmbgTB
            // 
            this.jmbgTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "JMBG", true));
            this.jmbgTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmbgTB.Location = new System.Drawing.Point(160, 152);
            this.jmbgTB.Name = "jmbgTB";
            this.jmbgTB.Size = new System.Drawing.Size(176, 26);
            this.jmbgTB.TabIndex = 3;
            // 
            // label97
            // 
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.Location = new System.Drawing.Point(24, 216);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(120, 23);
            this.label97.TabIndex = 8;
            this.label97.Text = "Mesto rodjenja:";
            // 
            // rodjenaDP
            // 
            this.rodjenaDP.CustomFormat = "dd.MMMM, yyyy";
            this.rodjenaDP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Rodjen", true));
            this.rodjenaDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rodjenaDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rodjenaDP.Location = new System.Drawing.Point(160, 184);
            this.rodjenaDP.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.rodjenaDP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.rodjenaDP.Name = "rodjenaDP";
            this.rodjenaDP.Size = new System.Drawing.Size(220, 26);
            this.rodjenaDP.TabIndex = 4;
            // 
            // label96
            // 
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(24, 184);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(120, 23);
            this.label96.TabIndex = 6;
            this.label96.Text = "Datum rodenja:";
            // 
            // label95
            // 
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.Location = new System.Drawing.Point(24, 152);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(96, 23);
            this.label95.TabIndex = 4;
            this.label95.Text = "JMBG:";
            // 
            // ImeTB
            // 
            this.ImeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Ime", true));
            this.ImeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeTB.Location = new System.Drawing.Point(160, 56);
            this.ImeTB.Name = "ImeTB";
            this.ImeTB.Size = new System.Drawing.Size(176, 26);
            this.ImeTB.TabIndex = 0;
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(24, 56);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(112, 23);
            this.label56.TabIndex = 2;
            this.label56.Text = "Ime:";
            // 
            // PrezimeTB
            // 
            this.PrezimeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Prezime", true));
            this.PrezimeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrezimeTB.Location = new System.Drawing.Point(160, 120);
            this.PrezimeTB.Name = "PrezimeTB";
            this.PrezimeTB.Size = new System.Drawing.Size(176, 26);
            this.PrezimeTB.TabIndex = 2;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(24, 120);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(96, 23);
            this.label52.TabIndex = 0;
            this.label52.Text = "Prezime:";
            // 
            // mestoTB
            // 
            this.mestoTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Mesto", true));
            this.mestoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mestoTB.Location = new System.Drawing.Point(160, 216);
            this.mestoTB.Name = "mestoTB";
            this.mestoTB.Size = new System.Drawing.Size(220, 26);
            this.mestoTB.TabIndex = 5;
            // 
            // adresaTB
            // 
            this.adresaTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Adresa", true));
            this.adresaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresaTB.Location = new System.Drawing.Point(160, 248);
            this.adresaTB.Name = "adresaTB";
            this.adresaTB.Size = new System.Drawing.Size(256, 26);
            this.adresaTB.TabIndex = 6;
            // 
            // label100
            // 
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(24, 248);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(136, 23);
            this.label100.TabIndex = 14;
            this.label100.Text = "Adresa, Mesto:";
            // 
            // zanimanjeTB
            // 
            this.zanimanjeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Zanimanje", true));
            this.zanimanjeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zanimanjeTB.Location = new System.Drawing.Point(160, 280);
            this.zanimanjeTB.Name = "zanimanjeTB";
            this.zanimanjeTB.Size = new System.Drawing.Size(256, 26);
            this.zanimanjeTB.TabIndex = 7;
            // 
            // label103
            // 
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(24, 280);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(112, 23);
            this.label103.TabIndex = 20;
            this.label103.Text = "Zanimanje:";
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Pacijent", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PacijentID", "PacijentID"),
                        new System.Data.Common.DataColumnMapping("Ime", "Ime"),
                        new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
                        new System.Data.Common.DataColumnMapping("JMBG", "JMBG"),
                        new System.Data.Common.DataColumnMapping("Mesto", "Mesto"),
                        new System.Data.Common.DataColumnMapping("Telefon", "Telefon"),
                        new System.Data.Common.DataColumnMapping("Adresa", "Adresa"),
                        new System.Data.Common.DataColumnMapping("Zanimanje", "Zanimanje"),
                        new System.Data.Common.DataColumnMapping("Rodjen", "Rodjen"),
                        new System.Data.Common.DataColumnMapping("Opstina", "Opstina")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_PacijentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PacijentID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Adresa", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresa", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ime", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_JMBG", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JMBG", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Mesto", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mesto", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Prezime", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Prezime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Rodjen", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rodjen", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Telefon", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telefon", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Zanimanje", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Zanimanje", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Pacijent\r\n                      (Ime)\r\nVALUES     (@Ime)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Ime", System.Data.SqlDbType.NVarChar, 50, "Ime")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userID", System.Data.SqlDbType.Int, 4, "UserID"),
            new System.Data.SqlClient.SqlParameter("@IsAdmin", System.Data.SqlDbType.Int)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Ime", System.Data.SqlDbType.NVarChar, 50, "Ime"),
            new System.Data.SqlClient.SqlParameter("@Prezime", System.Data.SqlDbType.NVarChar, 50, "Prezime"),
            new System.Data.SqlClient.SqlParameter("@JMBG", System.Data.SqlDbType.NVarChar, 50, "JMBG"),
            new System.Data.SqlClient.SqlParameter("@Mesto", System.Data.SqlDbType.NVarChar, 50, "Mesto"),
            new System.Data.SqlClient.SqlParameter("@Telefon", System.Data.SqlDbType.NVarChar, 50, "Telefon"),
            new System.Data.SqlClient.SqlParameter("@Adresa", System.Data.SqlDbType.NVarChar, 50, "Adresa"),
            new System.Data.SqlClient.SqlParameter("@Zanimanje", System.Data.SqlDbType.NVarChar, 50, "Zanimanje"),
            new System.Data.SqlClient.SqlParameter("@Rodjen", System.Data.SqlDbType.SmallDateTime, 4, "Rodjen"),
            new System.Data.SqlClient.SqlParameter("@Param15", System.Data.SqlDbType.NVarChar, 50, "Ime Srednje"),
            new System.Data.SqlClient.SqlParameter("@Param16", System.Data.SqlDbType.SmallInt, 2, "Opstina"),
            new System.Data.SqlClient.SqlParameter("@Original_PacijentID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PacijentID", System.Data.DataRowVersion.Original, null)});
            // 
            // getLastPatientIDsqlCmd
            // 
            this.getLastPatientIDsqlCmd.CommandText = "SELECT MAX(PacijentID) AS LastPatientID FROM Pacijent";
            this.getLastPatientIDsqlCmd.Connection = this.sqlConnection1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(456, 24);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(528, 216);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // Generalije
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.groupBox33);
            this.Controls.Add(this.pbLogo);
            this.Name = "Generalije";
            this.Size = new System.Drawing.Size(992, 520);
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        public void LoadControl()
        {
            int count;
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                    sqlConnection1.Open();

                parovicDS1.Pacijent.Clear();
                count = sqlDataAdapter1.Fill(parovicDS1);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

		public void SaveChanges()
		{			
			try
			{
				this.BindingContext[dataView1].EndCurrentEdit();
				if(parovicDS1.HasChanges())
				{					
				    sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Pacijent");										
				    LoadControl();			
				}
			}
			catch(Exception e)
			{
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
			}
		}

		public int NewPacijent()
		{
			int ret = -1;
			try
			{
				parovicDS1.Pacijent.AddPacijentRow("","","Nepoznat","","","","",DateTime.Now,"",0);				
				sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Pacijent");
				ret = (int)getLastPatientIDsqlCmd.ExecuteScalar();
			}
			catch(Exception e)
			{
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
			}

			return ret;
		}		

		public Int32 PacijentID
		{
			get
			{
                return Int32.Parse(tPacijentID.Text);
			}			
		}

		public int CurrentPosition
		{
			get
			{
				return this.BindingContext[dataView1].Position;
			}
			set
			{
				this.BindingContext[dataView1].Position = value;
			}
		}

		public string Ime
		{
			get
			{
                return ImeTB.Text;
			}
		}

		public string Prezime
		{
			get
			{
                return PrezimeTB.Text;
			}
		}
		
		public User User
		{
			set
			{
				sqlDataAdapter1.SelectCommand.Parameters["@userID"].Value = value.UserID;
				sqlDataAdapter1.SelectCommand.Parameters["@IsAdmin"].Value = value.Admin;
			}
		}

		public void PrepareForReport(ParovicDS.StampaRow stampa)
		{
			this.BindingContext[dataView1].EndCurrentEdit();
			
			stampa.Ime = ImeTB.Text + " " + PrezimeTB.Text + ", " + rodjenaDP.Value.Year.ToString();
			stampa.Adresa = adresaTB.Text;			
		}

		public String Filter
		{
			get	{return dataView1.RowFilter;}
			set {dataView1.RowFilter = value;}			
		}
	}
}
