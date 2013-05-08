using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parovic.Akuserstvo
{
    public partial class Kolpo
    {
        #region "Atr"
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CheckList clKolpo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rPAIV;
        private System.Windows.Forms.RadioButton rPAIII;
        private System.Windows.Forms.RadioButton rPAII;
        private System.Windows.Forms.NumericUpDown nPA;
        private System.Windows.Forms.TextBox tKomentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rHPVt;
        private System.Windows.Forms.RadioButton rHPVf;
        private CheckList clHPV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBiopsijaF;
        private System.Windows.Forms.RadioButton rBiopsijaT;
        private CheckList clBiopsija;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox bHisterektomija;
        private System.Windows.Forms.ComboBox cbHisterektomija;
        private System.Windows.Forms.CheckBox bEkscizione;
        private System.Windows.Forms.ComboBox cbEkscizione;
        private System.Windows.Forms.CheckBox bDestr;
        private System.Windows.Forms.ComboBox cbDestr;
        private System.Windows.Forms.Label label2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ParovicDS dataSet11;
        private System.Data.DataView dataView1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.GroupBox groupBox6;
        private ImageControl imageControl1;
        private System.Windows.Forms.Label labelProtokolID;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kolpo));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataView1 = new System.Data.DataView();
            this.dataSet11 = new Parovic.Akuserstvo.ParovicDS();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rPAIV = new System.Windows.Forms.RadioButton();
            this.rPAIII = new System.Windows.Forms.RadioButton();
            this.rPAII = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nPA = new System.Windows.Forms.NumericUpDown();
            this.tKomentar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rHPVf = new System.Windows.Forms.RadioButton();
            this.rHPVt = new System.Windows.Forms.RadioButton();
            this.clHPV = new Parovic.Akuserstvo.CheckList();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBiopsijaF = new System.Windows.Forms.RadioButton();
            this.rBiopsijaT = new System.Windows.Forms.RadioButton();
            this.clBiopsija = new Parovic.Akuserstvo.CheckList();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bHisterektomija = new System.Windows.Forms.CheckBox();
            this.cbHisterektomija = new System.Windows.Forms.ComboBox();
            this.bEkscizione = new System.Windows.Forms.CheckBox();
            this.cbEkscizione = new System.Windows.Forms.ComboBox();
            this.bDestr = new System.Windows.Forms.CheckBox();
            this.cbDestr = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clKolpo = new Parovic.Akuserstvo.CheckList();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.imageControl1 = new Parovic.Akuserstvo.ImageControl();
            this.labelProtokolID = new System.Windows.Forms.Label();
            this.bipsijaText = new System.Windows.Forms.TextBox();
            this.hpvText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Datum", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataView1
            // 
            this.dataView1.Table = this.dataSet11.Kolpo;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rPAIV);
            this.groupBox3.Controls.Add(this.rPAIII);
            this.groupBox3.Controls.Add(this.rPAII);
            this.groupBox3.Location = new System.Drawing.Point(8, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(64, 128);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PA";
            // 
            // rPAIV
            // 
            this.rPAIV.Location = new System.Drawing.Point(8, 88);
            this.rPAIV.Name = "rPAIV";
            this.rPAIV.Size = new System.Drawing.Size(48, 24);
            this.rPAIV.TabIndex = 2;
            this.rPAIV.Text = "IV";
            this.rPAIV.CheckedChanged += new System.EventHandler(this.rPAIV_CheckedChanged);
            // 
            // rPAIII
            // 
            this.rPAIII.Location = new System.Drawing.Point(8, 56);
            this.rPAIII.Name = "rPAIII";
            this.rPAIII.Size = new System.Drawing.Size(48, 24);
            this.rPAIII.TabIndex = 1;
            this.rPAIII.Text = "III";
            this.rPAIII.CheckedChanged += new System.EventHandler(this.rPAIII_CheckedChanged);
            // 
            // rPAII
            // 
            this.rPAII.Location = new System.Drawing.Point(8, 24);
            this.rPAII.Name = "rPAII";
            this.rPAII.Size = new System.Drawing.Size(48, 24);
            this.rPAII.TabIndex = 0;
            this.rPAII.Text = "II";
            this.rPAII.CheckedChanged += new System.EventHandler(this.rPAII_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(120, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 58);
            this.panel2.TabIndex = 24;
            // 
            // nPA
            // 
            this.nPA.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataView1, "PA", true));
            this.nPA.Location = new System.Drawing.Point(120, 400);
            this.nPA.Name = "nPA";
            this.nPA.ReadOnly = true;
            this.nPA.Size = new System.Drawing.Size(40, 20);
            this.nPA.TabIndex = 6;
            this.nPA.ValueChanged += new System.EventHandler(this.nPA_ValueChanged);
            // 
            // tKomentar
            // 
            this.tKomentar.AcceptsReturn = true;
            this.tKomentar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Komentar", true));
            this.tKomentar.HideSelection = false;
            this.tKomentar.Location = new System.Drawing.Point(8, 504);
            this.tKomentar.Multiline = true;
            this.tKomentar.Name = "tKomentar";
            this.tKomentar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tKomentar.Size = new System.Drawing.Size(633, 146);
            this.tKomentar.TabIndex = 3;
            this.tKomentar.Text = "textBox1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Komentar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hpvText);
            this.groupBox1.Controls.Add(this.rHPVf);
            this.groupBox1.Controls.Add(this.rHPVt);
            this.groupBox1.Controls.Add(this.clHPV);
            this.groupBox1.Location = new System.Drawing.Point(669, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HPV Tipizacija";
            // 
            // rHPVf
            // 
            this.rHPVf.Checked = true;
            this.rHPVf.Location = new System.Drawing.Point(120, 16);
            this.rHPVf.Name = "rHPVf";
            this.rHPVf.Size = new System.Drawing.Size(90, 24);
            this.rHPVf.TabIndex = 1;
            this.rHPVf.TabStop = true;
            this.rHPVf.Text = "Nije radjena";
            // 
            // rHPVt
            // 
            this.rHPVt.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "bHPV", true));
            this.rHPVt.Location = new System.Drawing.Point(24, 16);
            this.rHPVt.Name = "rHPVt";
            this.rHPVt.Size = new System.Drawing.Size(79, 24);
            this.rHPVt.TabIndex = 0;
            this.rHPVt.Text = "Radjena";
            this.rHPVt.CheckedChanged += new System.EventHandler(this.rHPVt_CheckedChanged);
            // 
            // clHPV
            // 
            this.clHPV.ColumnWidth = 0;
            this.clHPV.ListMultiColumn = false;
            this.clHPV.Location = new System.Drawing.Point(16, 48);
            this.clHPV.Name = "clHPV";
            this.clHPV.SelectedIndex = 0;
            this.clHPV.SingleSelected = true;
            this.clHPV.Size = new System.Drawing.Size(184, 80);
            this.clHPV.StringItems = new string[] {
        "negativan nalaz",
        "6/11 pozitivno",
        "16/18 pozitivno",
        "31/33 pozitivno"};
            this.clHPV.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bipsijaText);
            this.groupBox2.Controls.Add(this.rBiopsijaF);
            this.groupBox2.Controls.Add(this.rBiopsijaT);
            this.groupBox2.Controls.Add(this.clBiopsija);
            this.groupBox2.Location = new System.Drawing.Point(670, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 218);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Biopsija";
            // 
            // rBiopsijaF
            // 
            this.rBiopsijaF.Checked = true;
            this.rBiopsijaF.Location = new System.Drawing.Point(120, 16);
            this.rBiopsijaF.Name = "rBiopsijaF";
            this.rBiopsijaF.Size = new System.Drawing.Size(88, 24);
            this.rBiopsijaF.TabIndex = 1;
            this.rBiopsijaF.TabStop = true;
            this.rBiopsijaF.Text = "Nije radjena";
            // 
            // rBiopsijaT
            // 
            this.rBiopsijaT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "bBiopsija", true));
            this.rBiopsijaT.Location = new System.Drawing.Point(24, 16);
            this.rBiopsijaT.Name = "rBiopsijaT";
            this.rBiopsijaT.Size = new System.Drawing.Size(79, 24);
            this.rBiopsijaT.TabIndex = 0;
            this.rBiopsijaT.Text = "Radjena";
            this.rBiopsijaT.CheckedChanged += new System.EventHandler(this.rBiopsijaT_CheckedChanged);
            // 
            // clBiopsija
            // 
            this.clBiopsija.ColumnWidth = 0;
            this.clBiopsija.ListMultiColumn = false;
            this.clBiopsija.Location = new System.Drawing.Point(16, 48);
            this.clBiopsija.Name = "clBiopsija";
            this.clBiopsija.SelectedIndex = 0;
            this.clBiopsija.SingleSelected = true;
            this.clBiopsija.Size = new System.Drawing.Size(184, 96);
            this.clBiopsija.StringItems = new string[] {
        "benigno ",
        "L-SIL",
        "H-SIL",
        "Mikroinvazivni-Ca ",
        "Invazivni Ca"};
            this.clBiopsija.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bHisterektomija);
            this.groupBox4.Controls.Add(this.cbHisterektomija);
            this.groupBox4.Controls.Add(this.bEkscizione);
            this.groupBox4.Controls.Add(this.cbEkscizione);
            this.groupBox4.Controls.Add(this.bDestr);
            this.groupBox4.Controls.Add(this.cbDestr);
            this.groupBox4.Location = new System.Drawing.Point(670, 467);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 183);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Terapije";
            // 
            // bHisterektomija
            // 
            this.bHisterektomija.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "bHisterektomija", true));
            this.bHisterektomija.Location = new System.Drawing.Point(16, 128);
            this.bHisterektomija.Name = "bHisterektomija";
            this.bHisterektomija.Size = new System.Drawing.Size(136, 24);
            this.bHisterektomija.TabIndex = 4;
            this.bHisterektomija.Text = "Histerektomija ";
            this.bHisterektomija.CheckedChanged += new System.EventHandler(this.bHisterektomija_CheckedChanged);
            // 
            // cbHisterektomija
            // 
            this.cbHisterektomija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHisterektomija.Items.AddRange(new object[] {
            "",
            "Klasicna",
            "Radikalna"});
            this.cbHisterektomija.Location = new System.Drawing.Point(152, 128);
            this.cbHisterektomija.Name = "cbHisterektomija";
            this.cbHisterektomija.Size = new System.Drawing.Size(168, 21);
            this.cbHisterektomija.TabIndex = 5;
            // 
            // bEkscizione
            // 
            this.bEkscizione.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "bEkscizione", true));
            this.bEkscizione.Location = new System.Drawing.Point(16, 88);
            this.bEkscizione.Name = "bEkscizione";
            this.bEkscizione.Size = new System.Drawing.Size(136, 24);
            this.bEkscizione.TabIndex = 2;
            this.bEkscizione.Text = "Ekscizione metode";
            this.bEkscizione.CheckedChanged += new System.EventHandler(this.bEkscizione_CheckedChanged);
            // 
            // cbEkscizione
            // 
            this.cbEkscizione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEkscizione.Items.AddRange(new object[] {
            "",
            "Konizacija nožem",
            "Konizacija laserom",
            "Loop ekscizija"});
            this.cbEkscizione.Location = new System.Drawing.Point(152, 88);
            this.cbEkscizione.Name = "cbEkscizione";
            this.cbEkscizione.Size = new System.Drawing.Size(168, 21);
            this.cbEkscizione.TabIndex = 3;
            // 
            // bDestr
            // 
            this.bDestr.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "bDestruktivne", true));
            this.bDestr.Location = new System.Drawing.Point(16, 48);
            this.bDestr.Name = "bDestr";
            this.bDestr.Size = new System.Drawing.Size(136, 24);
            this.bDestr.TabIndex = 0;
            this.bDestr.Text = "Destruktivne metode";
            this.bDestr.CheckedChanged += new System.EventHandler(this.bDestr_CheckedChanged);
            // 
            // cbDestr
            // 
            this.cbDestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestr.Items.AddRange(new object[] {
            "",
            "Krioterapija",
            "Hladna koagulacija",
            "Elektrokauterizacija",
            "Laser – vaporizacija"});
            this.cbDestr.Location = new System.Drawing.Point(152, 48);
            this.cbDestr.Name = "cbDestr";
            this.cbDestr.Size = new System.Drawing.Size(168, 21);
            this.cbDestr.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clKolpo);
            this.groupBox5.Location = new System.Drawing.Point(8, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 171);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kolposkopski nalaz";
            // 
            // clKolpo
            // 
            this.clKolpo.ColumnWidth = 0;
            this.clKolpo.Enabled = false;
            this.clKolpo.ListMultiColumn = false;
            this.clKolpo.Location = new System.Drawing.Point(8, 29);
            this.clKolpo.Name = "clKolpo";
            this.clKolpo.SelectedIndex = 0;
            this.clKolpo.SingleSelected = false;
            this.clKolpo.Size = new System.Drawing.Size(167, 128);
            this.clKolpo.StringItems = new string[] {
        "Aceto – white ",
        "Punktacija",
        "Mozaik",
        "Leukoplakia ",
        "Jod negativno polje ",
        "Atipicna vaskularizacija ",
        "Ostalo "};
            this.clKolpo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Pregled uradjen:";
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Kolpo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PacijentID", "PacijentID"),
                        new System.Data.Common.DataColumnMapping("KolpoID", "KolpoID"),
                        new System.Data.Common.DataColumnMapping("ProtokolID", "ProtokolID"),
                        new System.Data.Common.DataColumnMapping("Datum", "Datum"),
                        new System.Data.Common.DataColumnMapping("bKolpo", "bKolpo"),
                        new System.Data.Common.DataColumnMapping("Kolpo", "Kolpo"),
                        new System.Data.Common.DataColumnMapping("PA", "PA"),
                        new System.Data.Common.DataColumnMapping("Komentar", "Komentar"),
                        new System.Data.Common.DataColumnMapping("bHPV", "bHPV"),
                        new System.Data.Common.DataColumnMapping("HPV", "HPV"),
                        new System.Data.Common.DataColumnMapping("bBiopsija", "bBiopsija"),
                        new System.Data.Common.DataColumnMapping("Biopsija", "Biopsija"),
                        new System.Data.Common.DataColumnMapping("bDestruktivne", "bDestruktivne"),
                        new System.Data.Common.DataColumnMapping("Destruktivne", "Destruktivne"),
                        new System.Data.Common.DataColumnMapping("bEkscizione", "bEkscizione"),
                        new System.Data.Common.DataColumnMapping("Ekscizione", "Ekscizione"),
                        new System.Data.Common.DataColumnMapping("bHisterektomija", "bHisterektomija"),
                        new System.Data.Common.DataColumnMapping("bZracna", "bZracna"),
                        new System.Data.Common.DataColumnMapping("Zracna", "Zracna"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Fullname", "Doctor")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlCommand1;
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
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Param1", System.Data.SqlDbType.DateTime, 4, "Datum"),
            new System.Data.SqlClient.SqlParameter("@Param2", System.Data.SqlDbType.Bit, 1, "bKolpo"),
            new System.Data.SqlClient.SqlParameter("@Param3", System.Data.SqlDbType.Int, 4, "Kolpo"),
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.SmallInt, 2, "PA"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 3000, "Komentar"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.Bit, 1, "bHPV"),
            new System.Data.SqlClient.SqlParameter("@Param7", System.Data.SqlDbType.Int, 4, "HPV"),
            new System.Data.SqlClient.SqlParameter("@Param8", System.Data.SqlDbType.SmallInt, 2, "Zracna"),
            new System.Data.SqlClient.SqlParameter("@Param9", System.Data.SqlDbType.Bit, 1, "bZracna"),
            new System.Data.SqlClient.SqlParameter("@Param10", System.Data.SqlDbType.Bit, 1, "bHisterektomija"),
            new System.Data.SqlClient.SqlParameter("@Param11", System.Data.SqlDbType.SmallInt, 2, "Ekscizione"),
            new System.Data.SqlClient.SqlParameter("@Param12", System.Data.SqlDbType.Bit, 1, "bEkscizione"),
            new System.Data.SqlClient.SqlParameter("@Param13", System.Data.SqlDbType.SmallInt, 2, "Destruktivne"),
            new System.Data.SqlClient.SqlParameter("@Param14", System.Data.SqlDbType.Bit, 1, "bDestruktivne"),
            new System.Data.SqlClient.SqlParameter("@Param15", System.Data.SqlDbType.Int, 4, "Biopsija"),
            new System.Data.SqlClient.SqlParameter("@Param16", System.Data.SqlDbType.Bit, 1, "bBiopsija"),
            new System.Data.SqlClient.SqlParameter("@Param17", System.Data.SqlDbType.SmallInt, 2, "Histerektomija"),
            new System.Data.SqlClient.SqlParameter("@Original_KolpoID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "KolpoID", System.Data.DataRowVersion.Original, null)});
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox6.Location = new System.Drawing.Point(647, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(16, 642);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            // 
            // imageControl1
            // 
            this.imageControl1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.imageControl1.Image = ((System.Drawing.Image)(resources.GetObject("imageControl1.Image")));
            this.imageControl1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageControl1.InitialImage")));
            this.imageControl1.Location = new System.Drawing.Point(214, 8);
            this.imageControl1.Name = "imageControl1";
            this.imageControl1.RenderInitialImage = true;
            this.imageControl1.Size = new System.Drawing.Size(427, 386);
            this.imageControl1.TabIndex = 34;
            // 
            // labelProtokolID
            // 
            this.labelProtokolID.AutoSize = true;
            this.labelProtokolID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "ProtokolID", true));
            this.labelProtokolID.Location = new System.Drawing.Point(117, 435);
            this.labelProtokolID.Name = "labelProtokolID";
            this.labelProtokolID.Size = new System.Drawing.Size(31, 13);
            this.labelProtokolID.TabIndex = 35;
            this.labelProtokolID.Text = "8425";
            // 
            // bipsijaText
            // 
            this.bipsijaText.AcceptsReturn = true;
            this.bipsijaText.Location = new System.Drawing.Point(16, 150);
            this.bipsijaText.Multiline = true;
            this.bipsijaText.Name = "bipsijaText";
            this.bipsijaText.Size = new System.Drawing.Size(183, 49);
            this.bipsijaText.TabIndex = 3;
            // 
            // hpvText
            // 
            this.hpvText.AcceptsReturn = true;
            this.hpvText.Location = new System.Drawing.Point(16, 134);
            this.hpvText.Multiline = true;
            this.hpvText.Name = "hpvText";
            this.hpvText.Size = new System.Drawing.Size(183, 49);
            this.hpvText.TabIndex = 4;
            // 
            // Kolpo
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelProtokolID);
            this.Controls.Add(this.imageControl1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tKomentar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nPA);
            this.Name = "Kolpo";
            this.Size = new System.Drawing.Size(1009, 653);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nPA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox hpvText;
        private System.Windows.Forms.TextBox bipsijaText;
    }
}
