using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for PrintPreview.
	/// </summary>
	public class PrintPreview : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private Statistika statistika1;
        private Report _generalReport;
        private PAReport _paReport;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlCommand sqlStatStarost;
        private System.Data.SqlClient.SqlCommand sqlStatTrim;
        private System.Data.SqlClient.SqlCommand sqlStatAnomalije;
        private System.Data.SqlClient.SqlCommand sqlStatOpstine;
        private System.Data.SqlClient.SqlCommand sqlStatGinStarost;
        private System.Data.SqlClient.SqlCommand sqlStatDijag;
        private DiagStat diagStat1;
        private ParovicDS parovicDS1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PrintPreview()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreview));
            this.sqlStatStarost = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlStatTrim = new System.Data.SqlClient.SqlCommand();
            this.sqlStatAnomalije = new System.Data.SqlClient.SqlCommand();
            this.sqlStatOpstine = new System.Data.SqlClient.SqlCommand();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this._generalReport = new Parovic.Akuserstvo.Report();
            this._paReport = new Parovic.Akuserstvo.PAReport();
            this.sqlStatGinStarost = new System.Data.SqlClient.SqlCommand();
            this.statistika1 = new Parovic.Akuserstvo.Statistika();
            this.sqlStatDijag = new System.Data.SqlClient.SqlCommand();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.diagStat1 = new Parovic.Akuserstvo.DiagStat();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlStatStarost
            // 
            this.sqlStatStarost.CommandText = resources.GetString("sqlStatStarost.CommandText");
            this.sqlStatStarost.Connection = this.sqlConnection1;
            this.sqlStatStarost.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@starostHi", System.Data.SqlDbType.Int, 4, "Godiste"),
            new System.Data.SqlClient.SqlParameter("@starostLo", System.Data.SqlDbType.Int, 4, "Godiste"),
            new System.Data.SqlClient.SqlParameter("@start", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum"),
            new System.Data.SqlClient.SqlParameter("@end", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum")});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlStatTrim
            // 
            this.sqlStatTrim.CommandText = resources.GetString("sqlStatTrim.CommandText");
            this.sqlStatTrim.Connection = this.sqlConnection1;
            this.sqlStatTrim.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@trim", System.Data.SqlDbType.SmallInt, 2, "Trimestar"),
            new System.Data.SqlClient.SqlParameter("@start", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum"),
            new System.Data.SqlClient.SqlParameter("@end", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum")});
            // 
            // sqlStatAnomalije
            // 
            this.sqlStatAnomalije.CommandText = resources.GetString("sqlStatAnomalije.CommandText");
            this.sqlStatAnomalije.Connection = this.sqlConnection1;
            this.sqlStatAnomalije.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@trim", System.Data.SqlDbType.SmallInt, 2, "Trimestar"),
            new System.Data.SqlClient.SqlParameter("@start", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum"),
            new System.Data.SqlClient.SqlParameter("@end", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum")});
            // 
            // sqlStatOpstine
            // 
            this.sqlStatOpstine.CommandText = resources.GetString("sqlStatOpstine.CommandText");
            this.sqlStatOpstine.Connection = this.sqlConnection1;
            this.sqlStatOpstine.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@starostHi", System.Data.SqlDbType.Int, 4, "Godiste"),
            new System.Data.SqlClient.SqlParameter("@starostLo", System.Data.SqlDbType.Int, 4, "Godiste"),
            new System.Data.SqlClient.SqlParameter("@start", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum"),
            new System.Data.SqlClient.SqlParameter("@end", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum"),
            new System.Data.SqlClient.SqlParameter("@opstina", System.Data.SqlDbType.SmallInt, 2, "Opstina")});
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this._generalReport;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(946, 753);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // _paReport
            // 
            this._paReport.InitReport += new System.EventHandler(this._paReport_InitReport);
            // 
            // sqlStatGinStarost
            // 
            this.sqlStatGinStarost.CommandText = resources.GetString("sqlStatGinStarost.CommandText");
            this.sqlStatGinStarost.Connection = this.sqlConnection1;
            this.sqlStatGinStarost.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@starostHi", System.Data.SqlDbType.Int, 4, "Godiste"),
            new System.Data.SqlClient.SqlParameter("@starostLo", System.Data.SqlDbType.Int, 4, "Godiste"),
            new System.Data.SqlClient.SqlParameter("@start", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum"),
            new System.Data.SqlClient.SqlParameter("@end", System.Data.SqlDbType.SmallDateTime, 4, "Pregled_datum")});
            // 
            // statistika1
            // 
            this.statistika1.InitReport += new System.EventHandler(this.statistika1_InitReport);
            // 
            // sqlStatDijag
            // 
            this.sqlStatDijag.CommandText = resources.GetString("sqlStatDijag.CommandText");
            this.sqlStatDijag.Connection = this.sqlConnection1;
            this.sqlStatDijag.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@start", System.Data.SqlDbType.SmallDateTime, 4, "Datum"),
            new System.Data.SqlClient.SqlParameter("@end", System.Data.SqlDbType.SmallDateTime, 4, "Datum")});
            // 
            // parovicDS1
            // 
            this.parovicDS1.DataSetName = "ParovicDS";
            this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.parovicDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlStatDijag;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "DijagStat", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Count", "Count"),
                        new System.Data.Common.DataColumnMapping("Diag sifra", "Sifra")})});
            // 
            // PrintPreview
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(946, 753);
            this.Controls.Add(this.crystalReportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Preview";
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        public Report Izvestaj
        {
            get
            {
                crystalReportViewer1.ReportSource = _generalReport;
                return _generalReport;
            }
        }

        public PAReport PaReport
        {
            get
            {
                crystalReportViewer1.ReportSource = _paReport;
                return _paReport;
            }
        }

        public Statistika Stat
        {
            get
            {
                crystalReportViewer1.ReportSource = statistika1;
                return statistika1;
            }
        }

        private void statistika1_InitReport(object sender, EventArgs e)
        {

        }

        public void DiagStatReport(DateTime start, DateTime end)
        {
            if (sqlConnection1.State != ConnectionState.Open)
                sqlConnection1.Open();

            sqlStatDijag.Parameters["@start"].Value = start;
            sqlStatDijag.Parameters["@end"].Value = end;
            int count = sqlDataAdapter1.Fill(parovicDS1);
            diagStat1.SetDataSource(parovicDS1);
            crystalReportViewer1.ReportSource = diagStat1;            
        }

        public void PrepareForReport(ParovicDS.StatistikaRow statRow, DateTime start, DateTime end)
        {
            if (sqlConnection1.State != ConnectionState.Open)
                sqlConnection1.Open();

            statRow.Start = start;
            statRow.End = end;

            sqlStatStarost.Parameters["@start"].Value = start;
            sqlStatStarost.Parameters["@end"].Value = end;
            
            sqlStatTrim.Parameters["@start"].Value = start;
            sqlStatTrim.Parameters["@end"].Value = end;

            sqlStatAnomalije.Parameters["@start"].Value = start;
            sqlStatAnomalije.Parameters["@end"].Value = end;

            sqlStatOpstine.Parameters["@start"].Value = start;
            sqlStatOpstine.Parameters["@end"].Value = end;

            sqlStatGinStarost.Parameters["@start"].Value = start;
            sqlStatGinStarost.Parameters["@end"].Value = end;
            
            //po starosti
            sqlStatStarost.Parameters["@starostLo"].Value = 0;
            sqlStatStarost.Parameters["@starostHi"].Value = 19;
            statRow.TrudStarost1 = (int)sqlStatStarost.ExecuteScalar();

            sqlStatStarost.Parameters["@starostLo"].Value = 20;
            sqlStatStarost.Parameters["@starostHi"].Value = 29;
            statRow.TrudStarost2 = (int)sqlStatStarost.ExecuteScalar();

            sqlStatStarost.Parameters["@starostLo"].Value = 30;
            sqlStatStarost.Parameters["@starostHi"].Value = 39;
            statRow.TrudStarost3 = (int)sqlStatStarost.ExecuteScalar();

            sqlStatStarost.Parameters["@starostLo"].Value = 40;
            sqlStatStarost.Parameters["@starostHi"].Value = 49;
            statRow.TrudStarost4 = (int)sqlStatStarost.ExecuteScalar();
            statRow.sumTrudStarost = statRow.TrudStarost1 + statRow.TrudStarost2 + statRow.TrudStarost3 + statRow.TrudStarost4;

            //po trimestrima
            sqlStatTrim.Parameters["@trim"].Value = 1;
            statRow.TrudTrim1 = (int)sqlStatTrim.ExecuteScalar();

            sqlStatTrim.Parameters["@trim"].Value = 2;
            statRow.TrudTrim2 = (int)sqlStatTrim.ExecuteScalar();

            sqlStatTrim.Parameters["@trim"].Value = 3;
            statRow.TrudTrim3 = (int)sqlStatTrim.ExecuteScalar();
            statRow.sumTrudTrim = statRow.TrudTrim1 + statRow.TrudTrim2 + statRow.TrudTrim3;

            // patologija po trimestrima
            sqlStatAnomalije.Parameters["@trim"].Value = 1;
            statRow.TrudPatTrim1 = (int)sqlStatAnomalije.ExecuteScalar();

            sqlStatAnomalije.Parameters["@trim"].Value = 2;
            statRow.TrudPatTrim2 = (int)sqlStatAnomalije.ExecuteScalar();

            sqlStatAnomalije.Parameters["@trim"].Value = 3;
            statRow.TrudPatTrim3 = (int)sqlStatAnomalije.ExecuteScalar();
            statRow.sumTrudPat = statRow.TrudPatTrim1 + statRow.TrudPatTrim2 + statRow.TrudPatTrim3;

            //starost po opstinama            
            statRow.TrudStarostPA1 = GetStarostOpstina(0, 19, "1");
            statRow.TrudStarostPA2 = GetStarostOpstina(20, 29, "1");
            statRow.TrudStarostPA3 = GetStarostOpstina(30, 39, "1");
            statRow.TrudStarostPA4 = GetStarostOpstina(40, 49, "1");
            statRow.sumPA = statRow.TrudStarostPA1 + statRow.TrudStarostPA2 + statRow.TrudStarostPA3 + statRow.TrudStarostPA4;

            statRow.TrudStarostKO1 = GetStarostOpstina(0, 19, "4");
            statRow.TrudStarostKO2 = GetStarostOpstina(20, 29, "4");
            statRow.TrudStarostKO3 = GetStarostOpstina(30, 39, "4");
            statRow.TrudStarostKO4 = GetStarostOpstina(40, 49, "4");
            statRow.sumKO = statRow.TrudStarostKO1 + statRow.TrudStarostKO2 + statRow.TrudStarostKO3 + statRow.TrudStarostKO4;


            statRow.TrudStarostAL1 = GetStarostOpstina(0, 19, "3");
            statRow.TrudStarostAL2 = GetStarostOpstina(20, 29, "3");
            statRow.TrudStarostAL3 = GetStarostOpstina(30, 39, "3");
            statRow.TrudStarostAL4 = GetStarostOpstina(40, 49, "3");
            statRow.sumAL = statRow.TrudStarostAL1 + statRow.TrudStarostAL2 + statRow.TrudStarostAL3 + statRow.TrudStarostAL4;


            statRow.TrudStarostOP1 = GetStarostOpstina(0, 19, "5");
            statRow.TrudStarostOP2 = GetStarostOpstina(20, 29, "5");
            statRow.TrudStarostOP3 = GetStarostOpstina(30, 39, "5");
            statRow.TrudStarostOP4 = GetStarostOpstina(40, 49, "5");
            statRow.sumOP = statRow.TrudStarostOP1 + statRow.TrudStarostOP2 + statRow.TrudStarostOP3 + statRow.TrudStarostOP4;


            statRow.TrudStarostKI1 = GetStarostOpstina(0, 19, "2");
            statRow.TrudStarostKI2 = GetStarostOpstina(20, 29, "2");
            statRow.TrudStarostKI3 = GetStarostOpstina(30, 39, "2");
            statRow.TrudStarostKI4 = GetStarostOpstina(40, 49, "2");
            statRow.sumKN = statRow.TrudStarostKI1 + statRow.TrudStarostKI2 + statRow.TrudStarostKI3 + statRow.TrudStarostKI4;
            statRow.sumOpstine = statRow.sumPA + statRow.sumKO + statRow.sumOP + statRow.sumAL + statRow.sumKN;

            //ginekologija po starosti
            //po starosti
            sqlStatGinStarost.Parameters["@starostLo"].Value = 0;
            sqlStatGinStarost.Parameters["@starostHi"].Value = 19;
            statRow.GINStarost1 = (int)sqlStatGinStarost.ExecuteScalar();

            sqlStatGinStarost.Parameters["@starostLo"].Value = 20;
            sqlStatGinStarost.Parameters["@starostHi"].Value = 29;
            statRow.GINStarost2 = (int)sqlStatGinStarost.ExecuteScalar();

            sqlStatGinStarost.Parameters["@starostLo"].Value = 30;
            sqlStatGinStarost.Parameters["@starostHi"].Value = 39;
            statRow.GINStarost3 = (int)sqlStatGinStarost.ExecuteScalar();

            sqlStatGinStarost.Parameters["@starostLo"].Value = 40;
            sqlStatGinStarost.Parameters["@starostHi"].Value = 49;
            statRow.GINStarost4 = (int)sqlStatGinStarost.ExecuteScalar();

            sqlStatGinStarost.Parameters["@starostLo"].Value = 51;
            sqlStatGinStarost.Parameters["@starostHi"].Value = 125;
            statRow.GINStarost5 = (int)sqlStatGinStarost.ExecuteScalar();
            statRow.sumGIN = statRow.GINStarost1 + statRow.GINStarost2 + statRow.GINStarost3 + statRow.GINStarost4 + statRow.GINStarost5;
            
        }

        private int GetStarostOpstina(int lo, int hi, string ops)
        {
            sqlStatOpstine.Parameters["@starostLo"].Value = lo;
            sqlStatOpstine.Parameters["@starostHi"].Value = hi;
            sqlStatOpstine.Parameters["@opstina"].Value = ops;
            return (int)sqlStatOpstine.ExecuteScalar();
        }

        private void _paReport_InitReport(object sender, EventArgs e)
        {

        }
	}
}
