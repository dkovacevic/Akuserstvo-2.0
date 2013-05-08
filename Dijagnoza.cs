using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for Dijagnoza.
	/// </summary>
	public class Dijagnoza : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private ParovicDS parovicDS1;
		private System.Data.DataView dataView1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private CheckList UputCl;
		private System.Windows.Forms.TextBox tKomentar;
		private System.Windows.Forms.TextBox tTerapija;
		private System.Windows.Forms.TextBox tDijagnoza;
        private CheckBox bPatologija;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Dijagnoza()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			UputCl.ValBind.Add("Value", dataView1, "Uput");
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
		public void SaveChanges()
		{
			try
			{
				this.BindingContext[dataView1].EndCurrentEdit();
				if(parovicDS1.HasChanges())
				{					
					sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Pregled");
					LoadControl();								
				}
			}
			catch(Exception e)
			{
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
			}
		}

		public void LoadControl()
		{			
			try
			{
				if(sqlConnection1.State != ConnectionState.Open	)
					sqlConnection1.Open();

				parovicDS1.Pregled.Clear();
				var count =  sqlDataAdapter1.Fill(parovicDS1);
			}
			catch(Exception e)
			{
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
			}
		}

		public void PrepareForReport(ParovicDS.StampaRow stampa)
		{
			this.BindingContext[dataView1].EndCurrentEdit();

			stampa.Dijagnoza = tDijagnoza.Text.ToUpper();
            stampa.Terapija = tTerapija.Text.ToUpper();
            stampa.Komentar = tKomentar.Text.ToUpper();

			if(UputCl.Report.Length != 0)
				stampa.Uput = "Izdati uputi za:   " + UputCl.Report;
		
		}

		public int CurrentPosition
		{
			get
			{
				return this.BindingContext[dataView1].Position;
			}
			set
			{
				if(value != -1)
					this.BindingContext[dataView1].Position = value;
			}
		}

		public String Filter
		{
			get	{return dataView1.RowFilter;}
			set {dataView1.RowFilter = value;}			
		}
		public User User
		{
			set
			{
				sqlDataAdapter1.SelectCommand.Parameters["@userID"].Value = value.UserID;
				sqlDataAdapter1.SelectCommand.Parameters["@IsAdmin"].Value = value.Admin;
			}
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dijagnoza));
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataView1 = new System.Data.DataView();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.tKomentar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tTerapija = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tDijagnoza = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.bPatologija = new System.Windows.Forms.CheckBox();
            this.UputCl = new Parovic.Akuserstvo.CheckList();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 23);
            this.label16.TabIndex = 38;
            this.label16.Text = "Kontrola:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Kontrola", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dataView1
            // 
            this.dataView1.Table = this.parovicDS1.Pregled;
            // 
            // parovicDS1
            // 
            this.parovicDS1.DataSetName = "ParovicDS";
            this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.parovicDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKomentar
            // 
            this.tKomentar.AcceptsReturn = true;
            this.tKomentar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Dijag Kom", true));
            this.tKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tKomentar.HideSelection = false;
            this.tKomentar.Location = new System.Drawing.Point(56, 57);
            this.tKomentar.Multiline = true;
            this.tKomentar.Name = "tKomentar";
            this.tKomentar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tKomentar.Size = new System.Drawing.Size(710, 120);
            this.tKomentar.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 23);
            this.label15.TabIndex = 35;
            this.label15.Text = "Komentar:";
            // 
            // tTerapija
            // 
            this.tTerapija.AcceptsReturn = true;
            this.tTerapija.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Terapija", true));
            this.tTerapija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tTerapija.Location = new System.Drawing.Point(494, 0);
            this.tTerapija.Multiline = true;
            this.tTerapija.Name = "tTerapija";
            this.tTerapija.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tTerapija.Size = new System.Drawing.Size(272, 51);
            this.tTerapija.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(449, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "Terapija:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Diag sifra", true));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox5.Location = new System.Drawing.Point(359, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 22);
            this.textBox5.TabIndex = 1;
            // 
            // tDijagnoza
            // 
            this.tDijagnoza.AcceptsReturn = true;
            this.tDijagnoza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Dijag", true));
            this.tDijagnoza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tDijagnoza.Location = new System.Drawing.Point(56, 0);
            this.tDijagnoza.Multiline = true;
            this.tDijagnoza.Name = "tDijagnoza";
            this.tDijagnoza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDijagnoza.Size = new System.Drawing.Size(301, 51);
            this.tDijagnoza.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "Dijagnoza:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(282, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Uput za:";
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Pregled", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PregledID", "PregledID"),
                        new System.Data.Common.DataColumnMapping("ProtokolID", "ProtokolID"),
                        new System.Data.Common.DataColumnMapping("Datum", "Datum"),
                        new System.Data.Common.DataColumnMapping("Razlog", "Razlog"),
                        new System.Data.Common.DataColumnMapping("TA sis", "TA sis"),
                        new System.Data.Common.DataColumnMapping("TA dia", "TA dia"),
                        new System.Data.Common.DataColumnMapping("Srcana akcija", "Srcana akcija"),
                        new System.Data.Common.DataColumnMapping("Ekarteri", "Ekarteri"),
                        new System.Data.Common.DataColumnMapping("Ekarteri ostalo", "Ekarteri ostalo"),
                        new System.Data.Common.DataColumnMapping("Vagina", "Vagina"),
                        new System.Data.Common.DataColumnMapping("Grlic", "Grlic"),
                        new System.Data.Common.DataColumnMapping("Uterus", "Uterus"),
                        new System.Data.Common.DataColumnMapping("SMU", "SMU"),
                        new System.Data.Common.DataColumnMapping("Parametrija", "Parametrija"),
                        new System.Data.Common.DataColumnMapping("Adnesa", "Adnesa"),
                        new System.Data.Common.DataColumnMapping("Duglas", "Duglas"),
                        new System.Data.Common.DataColumnMapping("Komentar", "Komentar"),
                        new System.Data.Common.DataColumnMapping("Dijag", "Dijag"),
                        new System.Data.Common.DataColumnMapping("Diag sifra", "Diag sifra"),
                        new System.Data.Common.DataColumnMapping("Terapija", "Terapija"),
                        new System.Data.Common.DataColumnMapping("Dijag Kom", "Dijag Kom"),
                        new System.Data.Common.DataColumnMapping("Kontrola", "Kontrola"),
                        new System.Data.Common.DataColumnMapping("Uput", "Uput"),
                        new System.Data.Common.DataColumnMapping("PAPP-A", "PAPP-A"),
                        new System.Data.Common.DataColumnMapping("PAPP-A Mo", "PAPP-A Mo"),
                        new System.Data.Common.DataColumnMapping("HCG", "HCG"),
                        new System.Data.Common.DataColumnMapping("HCG Mo", "HCG Mo"),
                        new System.Data.Common.DataColumnMapping("sec scr", "sec scr"),
                        new System.Data.Common.DataColumnMapping("Kolpo", "Kolpo"),
                        new System.Data.Common.DataColumnMapping("cvs", "cvs"),
                        new System.Data.Common.DataColumnMapping("Antitela", "Antitela"),
                        new System.Data.Common.DataColumnMapping("Antitela result", "Antitela result"),
                        new System.Data.Common.DataColumnMapping("Antitela vrsta", "Antitela vrsta"),
                        new System.Data.Common.DataColumnMapping("Antitela titar", "Antitela titar"),
                        new System.Data.Common.DataColumnMapping("Chlamidia", "Chlamidia"),
                        new System.Data.Common.DataColumnMapping("Chlamidia result", "Chlamidia result"),
                        new System.Data.Common.DataColumnMapping("Microplasma", "Microplasma"),
                        new System.Data.Common.DataColumnMapping("Microplasma result", "Microplasma result"),
                        new System.Data.Common.DataColumnMapping("Ureaplasma", "Ureaplasma"),
                        new System.Data.Common.DataColumnMapping("ureaplasma result", "ureaplasma result"),
                        new System.Data.Common.DataColumnMapping("Cervikalni", "Cervikalni"),
                        new System.Data.Common.DataColumnMapping("Cervikalni result", "Cervikalni result"),
                        new System.Data.Common.DataColumnMapping("PA", "PA"),
                        new System.Data.Common.DataColumnMapping("AFP", "AFP"),
                        new System.Data.Common.DataColumnMapping("AFP Mo", "AFP Mo"),
                        new System.Data.Common.DataColumnMapping("Estriol", "Estriol"),
                        new System.Data.Common.DataColumnMapping("Estriol Mo", "Estriol Mo"),
                        new System.Data.Common.DataColumnMapping("Cordocenthesis", "Cordocenthesis"),
                        new System.Data.Common.DataColumnMapping("Amniocenthesis", "Amniocenthesis"),
                        new System.Data.Common.DataColumnMapping("hromozomopatija", "hromozomopatija"),
                        new System.Data.Common.DataColumnMapping("Defekt NC", "Defekt NC"),
                        new System.Data.Common.DataColumnMapping("Toxoplazma", "Toxoplazma"),
                        new System.Data.Common.DataColumnMapping("Toxoplazma IgG", "Toxoplazma IgG"),
                        new System.Data.Common.DataColumnMapping("Toxoplazma IgM", "Toxoplazma IgM"),
                        new System.Data.Common.DataColumnMapping("Rubella", "Rubella"),
                        new System.Data.Common.DataColumnMapping("Rubella IgG", "Rubella IgG"),
                        new System.Data.Common.DataColumnMapping("Rubella IgM", "Rubella IgM"),
                        new System.Data.Common.DataColumnMapping("CVM", "CVM"),
                        new System.Data.Common.DataColumnMapping("CVM IgG", "CVM IgG"),
                        new System.Data.Common.DataColumnMapping("CVM IgM", "CVM IgM"),
                        new System.Data.Common.DataColumnMapping("HSV1", "HSV1"),
                        new System.Data.Common.DataColumnMapping("HSV1 IgG", "HSV1 IgG"),
                        new System.Data.Common.DataColumnMapping("HSV1 IgM", "HSV1 IgM"),
                        new System.Data.Common.DataColumnMapping("HSV2", "HSV2"),
                        new System.Data.Common.DataColumnMapping("HSV2 IgG", "HSV2 IgG"),
                        new System.Data.Common.DataColumnMapping("HSV2 IgM", "HSV2 IgM"),
                        new System.Data.Common.DataColumnMapping("Parvovirus B19", "Parvovirus B19"),
                        new System.Data.Common.DataColumnMapping("Parvovirus B19  IgG", "Parvovirus B19  IgG"),
                        new System.Data.Common.DataColumnMapping("Parvovirus B19  IgM", "Parvovirus B19  IgM"),
                        new System.Data.Common.DataColumnMapping("Parvovirus B19 Datum", "Parvovirus B19 Datum"),
                        new System.Data.Common.DataColumnMapping("Skr glukoza", "Skr glukoza"),
                        new System.Data.Common.DataColumnMapping("Skr glukoza  IgG1", "Skr glukoza  IgG1"),
                        new System.Data.Common.DataColumnMapping("Skr glukoza  IgM1", "Skr glukoza  IgM1"),
                        new System.Data.Common.DataColumnMapping("Skr glukoza Datum1", "Skr glukoza Datum1"),
                        new System.Data.Common.DataColumnMapping("Koprokultura", "Koprokultura"),
                        new System.Data.Common.DataColumnMapping("OGTT0", "OGTT0"),
                        new System.Data.Common.DataColumnMapping("OGTT60", "OGTT60"),
                        new System.Data.Common.DataColumnMapping("OGTT120", "OGTT120"),
                        new System.Data.Common.DataColumnMapping("OGTT180", "OGTT180"),
                        new System.Data.Common.DataColumnMapping("trimestar", "trimestar"),
                        new System.Data.Common.DataColumnMapping("bPatologija", "bPatologija")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userID", System.Data.SqlDbType.Int, 4, "UserID"),
            new System.Data.SqlClient.SqlParameter("@IsAdmin", System.Data.SqlDbType.Bit, 1024)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Dijag", System.Data.SqlDbType.NVarChar, 300, "Dijag"),
            new System.Data.SqlClient.SqlParameter("@Param43", System.Data.SqlDbType.NVarChar, 50, "Diag sifra"),
            new System.Data.SqlClient.SqlParameter("@Terapija", System.Data.SqlDbType.NVarChar, 300, "Terapija"),
            new System.Data.SqlClient.SqlParameter("@Param44", System.Data.SqlDbType.VarChar, 1050, "Dijag Kom"),
            new System.Data.SqlClient.SqlParameter("@Kontrola", System.Data.SqlDbType.SmallDateTime, 4, "Kontrola"),
            new System.Data.SqlClient.SqlParameter("@Uput", System.Data.SqlDbType.Int, 4, "Uput"),
            new System.Data.SqlClient.SqlParameter("@Param45", System.Data.SqlDbType.Int, 4, "ProtokolID"),
            new System.Data.SqlClient.SqlParameter("@Param46", System.Data.SqlDbType.Bit, 1, "bPatologija"),
            new System.Data.SqlClient.SqlParameter("@Original_PregledID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PregledID", System.Data.DataRowVersion.Original, null)});
            // 
            // bPatologija
            // 
            this.bPatologija.AutoSize = true;
            this.bPatologija.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "bPatologija", true));
            this.bPatologija.ForeColor = System.Drawing.Color.Blue;
            this.bPatologija.Location = new System.Drawing.Point(405, 3);
            this.bPatologija.Name = "bPatologija";
            this.bPatologija.Size = new System.Drawing.Size(45, 17);
            this.bPatologija.TabIndex = 41;
            this.bPatologija.Text = "Pat.";
            this.bPatologija.UseVisualStyleBackColor = true;
            this.bPatologija.CheckedChanged += new System.EventHandler(this.bPatologija_CheckedChanged);
            // 
            // UputCl
            // 
            this.UputCl.ColumnWidth = 82;
            this.UputCl.ListMultiColumn = true;
            this.UputCl.Location = new System.Drawing.Point(336, 183);
            this.UputCl.Name = "UputCl";
            this.UputCl.SelectedIndex = 0;
            this.UputCl.SingleSelected = false;
            this.UputCl.Size = new System.Drawing.Size(432, 24);
            this.UputCl.StringItems = new string[] {
        "Bolnicu",
        "Laboratoriju",
        "UZ",
        "PA - Kolpo",
        "Konsultacija"};
            this.UputCl.TabIndex = 5;
            // 
            // Dijagnoza
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.bPatologija);
            this.Controls.Add(this.UputCl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tKomentar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tTerapija);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tDijagnoza);
            this.Controls.Add(this.label13);
            this.Name = "Dijagnoza";
            this.Size = new System.Drawing.Size(769, 210);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private void bPatologija_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
                cb.ForeColor = Color.Red;
            else
                cb.ForeColor = Color.Blue;
        }

    }
}
