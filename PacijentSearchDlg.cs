using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Parovic
{
	/// <summary>
	/// Summary description for PacijentSearchDlg.
	/// </summary>
	public class PacijentSearchDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Windows.Forms.Button TraziBtn;
		private System.Windows.Forms.TextBox imeTB;
		private System.Windows.Forms.TextBox prezimeTB;
		private System.Windows.Forms.TextBox jmbgTB;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button OkBtn;		
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private Parovic.ParovicDS parovicDS1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.NumericUpDown nPacijentID;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PacijentSearchDlg()
		{
			//
			// Required for Windows Form Designer support
			//
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PacijentSearchDlg));
			this.imeTB = new System.Windows.Forms.TextBox();
			this.parovicDS1 = new Parovic.ParovicDS();
			this.prezimeTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.jmbgTB = new System.Windows.Forms.TextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.TraziBtn = new System.Windows.Forms.Button();
			this.OkBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.nPacijentID = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nPacijentID)).BeginInit();
			this.SuspendLayout();
			// 
			// imeTB
			// 
			this.imeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parovicDS1, "Pacijent.Ime"));
			this.imeTB.Location = new System.Drawing.Point(72, 16);
			this.imeTB.Name = "imeTB";
			this.imeTB.Size = new System.Drawing.Size(144, 20);
			this.imeTB.TabIndex = 0;
			this.imeTB.Text = "";
			// 
			// parovicDS1
			// 
			this.parovicDS1.DataSetName = "ParovicDS";
			this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-SP-Latn");
			// 
			// prezimeTB
			// 
			this.prezimeTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parovicDS1, "Pacijent.Prezime"));
			this.prezimeTB.Location = new System.Drawing.Point(72, 48);
			this.prezimeTB.Name = "prezimeTB";
			this.prezimeTB.Size = new System.Drawing.Size(144, 20);
			this.prezimeTB.TabIndex = 1;
			this.prezimeTB.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ime:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Prezime:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "JMBG:";
			// 
			// jmbgTB
			// 
			this.jmbgTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parovicDS1, "Pacijent.JMBG"));
			this.jmbgTB.Location = new System.Drawing.Point(72, 80);
			this.jmbgTB.Name = "jmbgTB";
			this.jmbgTB.Size = new System.Drawing.Size(96, 20);
			this.jmbgTB.TabIndex = 2;
			this.jmbgTB.Text = "";
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionText = "Svi nadjeni pacijenti";
			this.dataGrid1.DataMember = "Pacijent";
			this.dataGrid1.DataSource = this.parovicDS1;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 128);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.PreferredColumnWidth = 95;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(456, 176);
			this.dataGrid1.TabIndex = 6;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn7,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn6,
																												  this.dataGridTextBoxColumn5});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "Pacijent";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "JMBG";
			this.dataGridTextBoxColumn1.MappingName = "JMBG";
			this.dataGridTextBoxColumn1.Width = 90;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "Ime";
			this.dataGridTextBoxColumn3.MappingName = "Ime";
			this.dataGridTextBoxColumn3.Width = 75;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "Srednje Ime";
			this.dataGridTextBoxColumn7.MappingName = "Ime Srednje";
			this.dataGridTextBoxColumn7.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "Prezime";
			this.dataGridTextBoxColumn2.MappingName = "Prezime";
			this.dataGridTextBoxColumn2.Width = 75;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Rodjena";
			this.dataGridTextBoxColumn4.MappingName = "Rodjen";
			this.dataGridTextBoxColumn4.Width = 75;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Format = "";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = "Adresa";
			this.dataGridTextBoxColumn6.MappingName = "Adresa";
			this.dataGridTextBoxColumn6.Width = 150;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "Mesto";
			this.dataGridTextBoxColumn5.MappingName = "Mesto";
			this.dataGridTextBoxColumn5.Width = 75;
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Pacijent", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("PacijentID", "PacijentID"),
																																																				  new System.Data.Common.DataColumnMapping("Ime", "Ime"),
																																																				  new System.Data.Common.DataColumnMapping("Ime Srednje", "Ime Srednje"),
																																																				  new System.Data.Common.DataColumnMapping("Prezime", "Prezime"),
																																																				  new System.Data.Common.DataColumnMapping("JMBG", "JMBG"),
																																																				  new System.Data.Common.DataColumnMapping("Mesto", "Mesto"),
																																																				  new System.Data.Common.DataColumnMapping("Telefon", "Telefon"),
																																																				  new System.Data.Common.DataColumnMapping("Adresa", "Adresa"),
																																																				  new System.Data.Common.DataColumnMapping("Zanimanje", "Zanimanje"),
																																																				  new System.Data.Common.DataColumnMapping("Rodjen", "Rodjen")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = @"SELECT DISTINCT Pacijent.PacijentID, Pacijent.Ime, Pacijent.[Ime Srednje], Pacijent.Prezime, Pacijent.JMBG, Pacijent.Mesto, Pacijent.Telefon, Pacijent.Adresa, Pacijent.Zanimanje, Pacijent.Rodjen FROM Pacijent INNER JOIN Protokol ON Pacijent.PacijentID = Protokol.PacijentID WHERE (Pacijent.Ime LIKE @Ime + N'%') AND (Protokol.Grupa = 1) OR (Pacijent.Prezime = @Prezime) AND (Protokol.Grupa = 1) OR (Pacijent.JMBG = @JMBG) AND (Protokol.Grupa = 1) ORDER BY Pacijent.Prezime DESC";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ime", System.Data.SqlDbType.NVarChar, 50, "Ime"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Prezime", System.Data.SqlDbType.NVarChar, 50, "Prezime"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@JMBG", System.Data.SqlDbType.NVarChar, 50, "JMBG"));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=ALBA;packet size=4096;integrated security=SSPI;data source=\"(local" +
				")\";persist security info=False;initial catalog=Parovic";
			// 
			// TraziBtn
			// 
			this.TraziBtn.Location = new System.Drawing.Point(384, 16);
			this.TraziBtn.Name = "TraziBtn";
			this.TraziBtn.TabIndex = 3;
			this.TraziBtn.Text = "Trazi >>";
			this.TraziBtn.Click += new System.EventHandler(this.TraziBtn_Click);
			// 
			// OkBtn
			// 
			this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OkBtn.Enabled = false;
			this.OkBtn.Location = new System.Drawing.Point(296, 328);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.TabIndex = 4;
			this.OkBtn.Text = "OK";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(392, 328);
			this.button2.Name = "button2";
			this.button2.TabIndex = 5;
			this.button2.Text = "Cancel";
			// 
			// nPacijentID
			// 
			this.nPacijentID.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.parovicDS1, "Pacijent.PacijentID"));
			this.nPacijentID.Location = new System.Drawing.Point(368, 256);
			this.nPacijentID.Maximum = new System.Decimal(new int[] {
																		100000,
																		0,
																		0,
																		0});
			this.nPacijentID.Name = "nPacijentID";
			this.nPacijentID.ReadOnly = true;
			this.nPacijentID.Size = new System.Drawing.Size(88, 20);
			this.nPacijentID.TabIndex = 10;
			// 
			// PacijentSearchDlg
			// 
			this.AcceptButton = this.TraziBtn;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(480, 357);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.OkBtn);
			this.Controls.Add(this.TraziBtn);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.jmbgTB);
			this.Controls.Add(this.prezimeTB);
			this.Controls.Add(this.imeTB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nPacijentID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PacijentSearchDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Pretraga Pacijenata";
			((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nPacijentID)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void TraziBtn_Click(object sender, System.EventArgs e)
		{
			int count = 0;
			this.BindingContext[parovicDS1, "Pacijent"].EndCurrentEdit();
			sqlDataAdapter1.SelectCommand.Parameters["@JMBG"].Value = jmbgTB.Text;
			sqlDataAdapter1.SelectCommand.Parameters["@Ime"].Value = imeTB.Text;
			sqlDataAdapter1.SelectCommand.Parameters["@Prezime"].Value = prezimeTB.Text;

			try
			{
				if(sqlConnection1.State != ConnectionState.Open	)
					sqlConnection1.Open();

				parovicDS1.Pacijent.Clear();
				count = sqlDataAdapter1.Fill(parovicDS1);
			}
			catch(Exception ex)
			{
				MessageBox.Show(this.Name + ": " + ex.Message);
			}

			OkBtn.Enabled = count > 0 ? true : false ;
		}

		public Int32 PacijentID
		{
			get
			{
				return (Int32) nPacijentID.Value;
			}
		}
	}
}
