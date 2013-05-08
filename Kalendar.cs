using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for Kalendar.
	/// </summary>
	public class Kalendar : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ParovicDS parovicDS1;
        private System.Windows.Forms.Button btnCancel;
        private RichTextBox rtKom;
        private DataGridTextBoxColumn Vreme;
        private DataGridTextBoxColumn Pacijent;
        private Label label1;
        private System.Data.SqlClient.SqlCommand sqlKomentar;
        private Label lKalendarID;
        private DataGridTextBoxColumn Pacijent2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Kalendar()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            Datum = DateTime.Now.ToShortDateString();
            dataGrid1.CaptionText = "Raspored pregleda za datum: " + DateTime.Now.ToLongDateString();
            LoadKalendar();

			BoldDates();
            //parovicDS1.Kalendar.TableNewRow += new DataTableNewRowEventHandler(Kalendar_TableNewRow);
        }

        private void LoadKalendar()
        {            
            int count;
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                    sqlConnection1.Open();

                parovicDS1.Kalendar.Clear();
                count = sqlDataAdapter1.Fill(parovicDS1);
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Kalendar_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            //ParovicDS.KalendarRow row = (ParovicDS.KalendarRow)e.Row;
            //row.Datum = monthCalendar1.SelectionStart;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalendar));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtKom = new System.Windows.Forms.RichTextBox();
            this.parovicDS1 = new ParovicDS();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlKomentar = new System.Data.SqlClient.SqlCommand();
            this.lKalendarID = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.Vreme = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Pacijent = new System.Windows.Forms.DataGridTextBoxColumn();
            this.Pacijent2 = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(8, 8);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Kalendar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("KalendarID", "KalendarID"),
                        new System.Data.Common.DataColumnMapping("Vreme", "Vreme"),
                        new System.Data.Common.DataColumnMapping("Komentar", "Komentar"),
                        new System.Data.Common.DataColumnMapping("Datum", "Datum"),
                        new System.Data.Common.DataColumnMapping("Pacijent", "Pacijent"),
                        new System.Data.Common.DataColumnMapping("ZakazanoID", "ZakazanoID"),
                        new System.Data.Common.DataColumnMapping("Pacijent2", "Pacijent2")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Datum", System.Data.SqlDbType.SmallDateTime, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Datum", System.Data.DataRowVersion.Current, "21.1.2006")});
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
            new System.Data.SqlClient.SqlParameter("@Pacijent", System.Data.SqlDbType.NVarChar, 100, "Pacijent"),
            new System.Data.SqlClient.SqlParameter("@Pacijent2", System.Data.SqlDbType.NVarChar, 100, "Pacijent2"),
            new System.Data.SqlClient.SqlParameter("@Original_KalendarID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KalendarID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ZakazanoID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ZakazanoID", System.Data.DataRowVersion.Original, null)});
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(753, 544);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            // 
            // rtKom
            // 
            this.rtKom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parovicDS1, "Kalendar.Komentar", true));
            this.rtKom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rtKom.Location = new System.Drawing.Point(8, 438);
            this.rtKom.Name = "rtKom";
            this.rtKom.Size = new System.Drawing.Size(820, 96);
            this.rtKom.TabIndex = 4;
            this.rtKom.Text = "";
            // 
            // parovicDS1
            // 
            this.parovicDS1.DataSetName = "ParovicDS";
            this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-Latn-cs");
            this.parovicDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notes";
            // 
            // sqlKomentar
            // 
            this.sqlKomentar.CommandText = "UPDATE    Kalendar\r\nSET              Komentar = @Komentar\r\nWHERE     (KalendarID " +
                "= @KalendarID)";
            this.sqlKomentar.Connection = this.sqlConnection1;
            this.sqlKomentar.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Komentar", System.Data.SqlDbType.NVarChar, 1000, "Komentar"),
            new System.Data.SqlClient.SqlParameter("@KalendarID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KalendarID", System.Data.DataRowVersion.Original, null)});
            // 
            // lKalendarID
            // 
            this.lKalendarID.AutoSize = true;
            this.lKalendarID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parovicDS1, "Kalendar.KalendarID", true));
            this.lKalendarID.Location = new System.Drawing.Point(165, 387);
            this.lKalendarID.Name = "lKalendarID";
            this.lKalendarID.Size = new System.Drawing.Size(35, 13);
            this.lKalendarID.TabIndex = 6;
            this.lKalendarID.Text = "label2";
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionText = "Raspored pregleda";
            this.dataGrid1.DataMember = "Kalendar";
            this.dataGrid1.DataSource = this.parovicDS1;
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(229, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(595, 392);
            this.dataGrid1.TabIndex = 1;
            this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.AllowSorting = false;
            this.dataGridTableStyle1.DataGrid = this.dataGrid1;
            this.dataGridTableStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.Vreme,
            this.Pacijent,
            this.Pacijent2});
            this.dataGridTableStyle1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "Kalendar";
            this.dataGridTableStyle1.PreferredRowHeight = 24;
            this.dataGridTableStyle1.RowHeadersVisible = false;
            // 
            // Vreme
            // 
            this.Vreme.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Vreme.Format = "HH:mm";
            this.Vreme.FormatInfo = null;
            this.Vreme.HeaderText = "Vreme";
            this.Vreme.MappingName = "Vreme";
            this.Vreme.NullText = "";
            this.Vreme.ReadOnly = true;
            this.Vreme.Width = 75;
            // 
            // Pacijent
            // 
            this.Pacijent.Format = "";
            this.Pacijent.FormatInfo = null;
            this.Pacijent.HeaderText = "Zoran";
            this.Pacijent.MappingName = "Pacijent";
            this.Pacijent.NullText = "";
            this.Pacijent.Width = 250;
            // 
            // Pacijent2
            // 
            this.Pacijent2.Format = "";
            this.Pacijent2.FormatInfo = null;
            this.Pacijent2.HeaderText = "Vlada";
            this.Pacijent2.MappingName = "Pacijent2";
            this.Pacijent2.NullText = "";
            this.Pacijent2.Width = 250;
            // 
            // Kalendar
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(840, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtKom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lKalendarID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kalendar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kalendar";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Kalendar_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void BoldDates()
		{		
			foreach(DataRow row in parovicDS1.Kalendar.Rows)
			{				
				ParovicDS.KalendarRow kr = (ParovicDS.KalendarRow) row;
				monthCalendar1.AddBoldedDate(kr.Datum);				
			}
		}

		public void SaveChanges(bool ask)
		{
			try
			{
				this.BindingContext[parovicDS1].EndCurrentEdit();
                UpdateKomentar();
				if(parovicDS1.HasChanges())
				{                  
                    sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Kalendar");				
					parovicDS1.Kalendar.Clear();
					sqlDataAdapter1.Fill(parovicDS1);				
			    }
			}
			catch(Exception e)
			{
                MessageBox.Show(e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		
		}

        private void UpdateKomentar()
        {
            try
            {
                sqlKomentar.Parameters["@Komentar"].Value = rtKom.Text;
                sqlKomentar.Parameters["@KalendarID"].Value = int.Parse(lKalendarID.Text);
                sqlKomentar.ExecuteNonQuery();
            }
            catch(Exception)
            {

            }
        }

		private void Kalendar_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
            SaveChanges(false);
		}

		private void monthCalendar1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
            
		}

        private string Datum
        {
            set
            {
                sqlDataAdapter1.SelectCommand.Parameters["@Datum"].Value = value;
            }
        }

        public string UserName
        {
            set
            {
                String commandText;
                if (value == "Vlada")
                {
                    commandText = "UPDATE Zakazivanje SET Pacijent2 = @Pacijent2 FROM Kalendar INNER JOIN Zakazivanje ON Kalendar.KalendarID = Zakazivanje.KalendarID WHERE(Kalendar.KalendarID = @Original_KalendarID) AND (Zakazivanje.ZakazanoID = @Original_ZakazanoID)";
                    dataGrid1.TableStyles[0].GridColumnStyles["Pacijent"].ReadOnly = true;
                }
                else
                {
                    commandText = "UPDATE Zakazivanje SET Pacijent = @Pacijent FROM Kalendar INNER JOIN Zakazivanje ON Kalendar.KalendarID = Zakazivanje.KalendarID WHERE (Kalendar.KalendarID = @Original_KalendarID) AND (Zakazivanje.ZakazanoID = @Original_ZakazanoID)";
                    dataGrid1.TableStyles[0].GridColumnStyles["Pacijent2"].ReadOnly = true;
                }
                sqlDataAdapter1.UpdateCommand.CommandText = commandText;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            SaveChanges(false);

            Datum = e.End.ToShortDateString();
            dataGrid1.CaptionText = "Raspored pregleda za datum: " + e.End.ToLongDateString();
            LoadKalendar();
        }
	}
}
