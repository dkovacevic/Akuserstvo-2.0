using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for TrimestarI.
	/// </summary>
	public class TrimestarI : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private ParovicDS parovicDS1;
		private System.Data.DataView dataView1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.NumericUpDown numTrimestar;
        private TextBox textBoxAntitela;
        private TextBox textBoxBrisovi;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TrimestarI()
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
			Int32 col;
			try
			{
				if(sqlConnection1.State != ConnectionState.Open	)
					sqlConnection1.Open();

				parovicDS1.Pregled.Clear();
				col =  sqlDataAdapter1.Fill(parovicDS1);

			}
			catch(Exception e)
			{
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
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
				if(value != -1)
					this.BindingContext[dataView1].Position = value;
			}
		}
		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrimestarI));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataView1 = new System.Data.DataView();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAntitela = new System.Windows.Forms.TextBox();
            this.numTrimestar = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxBrisovi = new System.Windows.Forms.TextBox();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimestar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 143);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fetalni biomarkeri";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "sec scr", true));
            this.textBox6.Location = new System.Drawing.Point(192, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "textBox6";
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
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "HCG Mo", true));
            this.textBox5.Location = new System.Drawing.Point(192, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "textBox5";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "PAPP-A Mo", true));
            this.textBox3.Location = new System.Drawing.Point(192, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "textBox3";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "HCG", true));
            this.textBox2.Location = new System.Drawing.Point(96, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "textBox2";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "PAPP-A", true));
            this.textBox4.Location = new System.Drawing.Point(96, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "textBox4";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rezultati sekvencijalnog skrininga 1 :";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(152, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "MoM:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "free Beta HCG:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(152, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "MoM:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "PAPP-A:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAntitela);
            this.groupBox4.Location = new System.Drawing.Point(262, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 69);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Antitela";
            // 
            // textBoxAntitela
            // 
            this.textBoxAntitela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "AntitelaText", true));
            this.textBoxAntitela.Location = new System.Drawing.Point(5, 19);
            this.textBoxAntitela.Multiline = true;
            this.textBoxAntitela.Name = "textBoxAntitela";
            this.textBoxAntitela.Size = new System.Drawing.Size(276, 39);
            this.textBoxAntitela.TabIndex = 0;
            // 
            // numTrimestar
            // 
            this.numTrimestar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataView1, "Trimestar", true));
            this.numTrimestar.Location = new System.Drawing.Point(495, 152);
            this.numTrimestar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTrimestar.Name = "numTrimestar";
            this.numTrimestar.ReadOnly = true;
            this.numTrimestar.Size = new System.Drawing.Size(56, 20);
            this.numTrimestar.TabIndex = 6;
            this.numTrimestar.ValueChanged += new System.EventHandler(this.numTrimestar_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxBrisovi);
            this.groupBox5.Location = new System.Drawing.Point(262, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 65);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bris";
            // 
            // textBoxBrisovi
            // 
            this.textBoxBrisovi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "BrisText", true));
            this.textBoxBrisovi.Location = new System.Drawing.Point(6, 19);
            this.textBoxBrisovi.Multiline = true;
            this.textBoxBrisovi.Name = "textBoxBrisovi";
            this.textBoxBrisovi.Size = new System.Drawing.Size(276, 39);
            this.textBoxBrisovi.TabIndex = 1;
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
                        new System.Data.Common.DataColumnMapping("PA", "PA")})});
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
            new System.Data.SqlClient.SqlParameter("@Param24", System.Data.SqlDbType.Float, 8, "PAPP-A"),
            new System.Data.SqlClient.SqlParameter("@Param25", System.Data.SqlDbType.Float, 8, "PAPP-A Mo"),
            new System.Data.SqlClient.SqlParameter("@HCG", System.Data.SqlDbType.Float, 8, "HCG"),
            new System.Data.SqlClient.SqlParameter("@Param26", System.Data.SqlDbType.Float, 8, "HCG Mo"),
            new System.Data.SqlClient.SqlParameter("@Param27", System.Data.SqlDbType.Float, 8, "sec scr"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.NVarChar, 2147483647, "BrisText"),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.VarChar, 2147483647, "AntitelaText"),
            new System.Data.SqlClient.SqlParameter("@Original_PregledID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PregledID", System.Data.DataRowVersion.Original, null)});
            // 
            // TrimestarI
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.numTrimestar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "TrimestarI";
            this.Size = new System.Drawing.Size(561, 321);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimestar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		
		private void numTrimestar_ValueChanged(object sender, System.EventArgs e)
		{
			if((sender as NumericUpDown).Value == 1M)
				this.Visible = true;
			else
				this.Visible = false;
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
	}
}
