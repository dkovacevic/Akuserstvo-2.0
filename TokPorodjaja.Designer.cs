using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parovic.Akuserstvo
{
    public partial class TokPorodjaja
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ParovicDS parovicDS1;
        private System.Data.DataView dataView1;
        private System.Windows.Forms.NumericUpDown trim;
        private System.Windows.Forms.NumericUpDown protokolID;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tTAsis;
        private System.Windows.Forms.TextBox tTAdias;
        private System.Windows.Forms.Label labelPrirastaj;
        public System.Windows.Forms.Label labelVisina;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Windows.Forms.TextBox tTrenutnaTezina;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.TextBox tRazlog;
        private System.Windows.Forms.TextBox tAdnesa;
        private System.Windows.Forms.TextBox tSMU;
        private System.Windows.Forms.TextBox tUterus;
        private System.Windows.Forms.TextBox tGrlic;
        private System.Windows.Forms.TextBox tVagina;
        private System.Windows.Forms.TextBox tOstalo;
        private System.Windows.Forms.CheckBox bPrikazi;        
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelPocetnaTezina;
        
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokPorodjaja));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPocetnaTezina = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tTrenutnaTezina = new System.Windows.Forms.TextBox();
            this.dataView1 = new System.Data.DataView();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bPrikazi = new System.Windows.Forms.CheckBox();
            this.labelBMI = new System.Windows.Forms.Label();
            this.labelPrirastaj = new System.Windows.Forms.Label();
            this.tTAdias = new System.Windows.Forms.TextBox();
            this.tTAsis = new System.Windows.Forms.TextBox();
            this.tAdnesa = new System.Windows.Forms.TextBox();
            this.tSMU = new System.Windows.Forms.TextBox();
            this.tUterus = new System.Windows.Forms.TextBox();
            this.tGrlic = new System.Windows.Forms.TextBox();
            this.tVagina = new System.Windows.Forms.TextBox();
            this.tOstalo = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tRazlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.trim = new System.Windows.Forms.NumericUpDown();
            this.labelVisina = new System.Windows.Forms.Label();
            this.protokolID = new System.Windows.Forms.NumericUpDown();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolID)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.labelPocetnaTezina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tTrenutnaTezina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bPrikazi);
            this.groupBox1.Controls.Add(this.labelBMI);
            this.groupBox1.Controls.Add(this.labelPrirastaj);
            this.groupBox1.Controls.Add(this.tTAdias);
            this.groupBox1.Controls.Add(this.tTAsis);
            this.groupBox1.Controls.Add(this.tAdnesa);
            this.groupBox1.Controls.Add(this.tSMU);
            this.groupBox1.Controls.Add(this.tUterus);
            this.groupBox1.Controls.Add(this.tGrlic);
            this.groupBox1.Controls.Add(this.tVagina);
            this.groupBox1.Controls.Add(this.tOstalo);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tRazlog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.trim);
            this.groupBox1.Controls.Add(this.labelVisina);
            this.groupBox1.Controls.Add(this.protokolID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 658);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelPocetnaTezina
            // 
            this.labelPocetnaTezina.AutoSize = true;
            this.labelPocetnaTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPocetnaTezina.Location = new System.Drawing.Point(173, 185);
            this.labelPocetnaTezina.Name = "labelPocetnaTezina";
            this.labelPocetnaTezina.Size = new System.Drawing.Size(27, 20);
            this.labelPocetnaTezina.TabIndex = 110;
            this.labelPocetnaTezina.Text = "50";
            this.labelPocetnaTezina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPocetnaTezina.TextChanged += new System.EventHandler(this.labelPocetnaTezina_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(211, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 23);
            this.label5.TabIndex = 114;
            this.label5.Text = "kg";
            // 
            // tTrenutnaTezina
            // 
            this.tTrenutnaTezina.CausesValidation = false;
            this.tTrenutnaTezina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Prirastaj", true));
            this.tTrenutnaTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTrenutnaTezina.Location = new System.Drawing.Point(124, 157);
            this.tTrenutnaTezina.Name = "tTrenutnaTezina";
            this.tTrenutnaTezina.Size = new System.Drawing.Size(44, 26);
            this.tTrenutnaTezina.TabIndex = 2;
            this.tTrenutnaTezina.Text = "70";
            this.toolTip1.SetToolTip(this.tTrenutnaTezina, "Prirastaj");
            this.tTrenutnaTezina.TextChanged += new System.EventHandler(this.tTrenutnaTezina_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Tezina pre trudnoce:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Trenutna tezina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "cm";
            // 
            // bPrikazi
            // 
            this.bPrikazi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "Valid", true));
            this.bPrikazi.Location = new System.Drawing.Point(218, 9);
            this.bPrikazi.Name = "bPrikazi";
            this.bPrikazi.Size = new System.Drawing.Size(48, 24);
            this.bPrikazi.TabIndex = 5;
            this.bPrikazi.Text = "reg.";
            this.bPrikazi.Click += new System.EventHandler(this.bPrikazi_Click);
            // 
            // labelBMI
            // 
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(4, 208);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(143, 23);
            this.labelBMI.TabIndex = 109;
            this.labelBMI.Text = "BMI: ";
            // 
            // labelPrirastaj
            // 
            this.labelPrirastaj.AutoSize = true;
            this.labelPrirastaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrirastaj.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelPrirastaj.Location = new System.Drawing.Point(197, 161);
            this.labelPrirastaj.Name = "labelPrirastaj";
            this.labelPrirastaj.Size = new System.Drawing.Size(80, 20);
            this.labelPrirastaj.TabIndex = 3;
            this.labelPrirastaj.Text = "(+20.1) kg";
            this.labelPrirastaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tTAdias
            // 
            this.tTAdias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "TA dia", true));
            this.tTAdias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTAdias.Location = new System.Drawing.Point(101, 233);
            this.tTAdias.Name = "tTAdias";
            this.tTAdias.Size = new System.Drawing.Size(46, 26);
            this.tTAdias.TabIndex = 4;
            this.tTAdias.Text = "textBox12";
            this.toolTip1.SetToolTip(this.tTAdias, "Prirastaj");
            // 
            // tTAsis
            // 
            this.tTAsis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "TA sis", true));
            this.tTAsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTAsis.Location = new System.Drawing.Point(42, 233);
            this.tTAsis.Name = "tTAsis";
            this.tTAsis.Size = new System.Drawing.Size(43, 26);
            this.tTAsis.TabIndex = 3;
            this.tTAsis.Text = "textBox11";
            this.toolTip1.SetToolTip(this.tTAsis, "Prirastaj");
            // 
            // tAdnesa
            // 
            this.tAdnesa.AcceptsReturn = true;
            this.tAdnesa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Adnesa", true));
            this.tAdnesa.Location = new System.Drawing.Point(6, 571);
            this.tAdnesa.Multiline = true;
            this.tAdnesa.Name = "tAdnesa";
            this.tAdnesa.Size = new System.Drawing.Size(258, 81);
            this.tAdnesa.TabIndex = 12;
            this.tAdnesa.Text = "Adnesa:";
            this.toolTip1.SetToolTip(this.tAdnesa, "Adneksa");
            // 
            // tSMU
            // 
            this.tSMU.AcceptsReturn = true;
            this.tSMU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "SMU", true));
            this.tSMU.Location = new System.Drawing.Point(6, 434);
            this.tSMU.Multiline = true;
            this.tSMU.Name = "tSMU";
            this.tSMU.Size = new System.Drawing.Size(258, 65);
            this.tSMU.TabIndex = 10;
            this.tSMU.Text = "SMU:";
            this.toolTip1.SetToolTip(this.tSMU, "SMU");
            // 
            // tUterus
            // 
            this.tUterus.AcceptsReturn = true;
            this.tUterus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Uterus", true));
            this.tUterus.Location = new System.Drawing.Point(6, 504);
            this.tUterus.Multiline = true;
            this.tUterus.Name = "tUterus";
            this.tUterus.Size = new System.Drawing.Size(258, 62);
            this.tUterus.TabIndex = 11;
            this.tUterus.Text = "Uterus:";
            this.toolTip1.SetToolTip(this.tUterus, "Uterus");
            // 
            // tGrlic
            // 
            this.tGrlic.AcceptsReturn = true;
            this.tGrlic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Grlic", true));
            this.tGrlic.Location = new System.Drawing.Point(6, 374);
            this.tGrlic.Multiline = true;
            this.tGrlic.Name = "tGrlic";
            this.tGrlic.Size = new System.Drawing.Size(258, 55);
            this.tGrlic.TabIndex = 9;
            this.tGrlic.Text = "Grlic:";
            this.toolTip1.SetToolTip(this.tGrlic, "Grlic");
            // 
            // tVagina
            // 
            this.tVagina.AcceptsReturn = true;
            this.tVagina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Vagina", true));
            this.tVagina.Location = new System.Drawing.Point(6, 318);
            this.tVagina.Multiline = true;
            this.tVagina.Name = "tVagina";
            this.tVagina.Size = new System.Drawing.Size(258, 51);
            this.tVagina.TabIndex = 8;
            this.tVagina.Text = "Vagina:";
            this.toolTip1.SetToolTip(this.tVagina, "Vagina");
            // 
            // tOstalo
            // 
            this.tOstalo.AcceptsReturn = true;
            this.tOstalo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Ekarteri ostalo", true));
            this.tOstalo.Location = new System.Drawing.Point(6, 270);
            this.tOstalo.Multiline = true;
            this.tOstalo.Name = "tOstalo";
            this.tOstalo.Size = new System.Drawing.Size(258, 43);
            this.tOstalo.TabIndex = 7;
            this.tOstalo.Text = "ekateri";
            this.toolTip1.SetToolTip(this.tOstalo, "Pod ekarterima");
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "Srcana akcija", true));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(8, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Srcana akcija ploda";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 23);
            this.label9.TabIndex = 84;
            this.label9.Text = "/";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 23);
            this.label8.TabIndex = 82;
            this.label8.Text = "TA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "kg";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tRazlog
            // 
            this.tRazlog.AcceptsReturn = true;
            this.tRazlog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Razlog", true));
            this.tRazlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRazlog.HideSelection = false;
            this.tRazlog.Location = new System.Drawing.Point(8, 52);
            this.tRazlog.Multiline = true;
            this.tRazlog.Name = "tRazlog";
            this.tRazlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tRazlog.Size = new System.Drawing.Size(261, 68);
            this.tRazlog.TabIndex = 1;
            this.tRazlog.Text = "Redovna kontrola";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Razlog posete:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Datum", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Vreme pregleda");
            // 
            // trim
            // 
            this.trim.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataView1, "trimestar", true));
            this.trim.Enabled = false;
            this.trim.Location = new System.Drawing.Point(123, 283);
            this.trim.Maximum = new decimal(new int[] {
            34,
            0,
            0,
            0});
            this.trim.Name = "trim";
            this.trim.ReadOnly = true;
            this.trim.Size = new System.Drawing.Size(32, 20);
            this.trim.TabIndex = 100;
            this.trim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelVisina
            // 
            this.labelVisina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisina.Location = new System.Drawing.Point(160, 208);
            this.labelVisina.Name = "labelVisina";
            this.labelVisina.Size = new System.Drawing.Size(45, 23);
            this.labelVisina.TabIndex = 107;
            this.labelVisina.Text = "180";
            this.labelVisina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVisina.TextChanged += new System.EventHandler(this.labelVisina_TextChanged);
            // 
            // protokolID
            // 
            this.protokolID.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataView1, "ProtokolID", true));
            this.protokolID.Enabled = false;
            this.protokolID.Location = new System.Drawing.Point(190, 271);
            this.protokolID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.protokolID.Name = "protokolID";
            this.protokolID.ReadOnly = true;
            this.protokolID.Size = new System.Drawing.Size(53, 20);
            this.protokolID.TabIndex = 101;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlCommand2;
            this.sqlDataAdapter1.InsertCommand = this.sqlCommand1;
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
                        new System.Data.Common.DataColumnMapping("Fullname", "Doctor")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "DELETE FROM Protokol WHERE (ProtokolID = @ProtokolID)";
            this.sqlCommand2.Connection = this.sqlConnection1;
            this.sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProtokolID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProtokolID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "INSERT INTO Protokol (PacijentID, Trimestar, UserID, Grupa) VALUES (@PacijentID, " +
    "@Trimestar, @userID, @Grupa)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PacijentID", System.Data.SqlDbType.Int, 4, "PacijentID"),
            new System.Data.SqlClient.SqlParameter("@Trimestar", System.Data.SqlDbType.SmallInt, 2, "Trimestar"),
            new System.Data.SqlClient.SqlParameter("@userID", System.Data.SqlDbType.Int, 4, "UserID"),
            new System.Data.SqlClient.SqlParameter("@Grupa", System.Data.SqlDbType.SmallInt, 2, "Grupa")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userID", System.Data.SqlDbType.Int, 4, "UserID"),
            new System.Data.SqlClient.SqlParameter("@IsAdmin", System.Data.SqlDbType.Bit, 1024)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Datum", System.Data.SqlDbType.SmallDateTime, 4, "Datum"),
            new System.Data.SqlClient.SqlParameter("@Razlog", System.Data.SqlDbType.NVarChar, 1024, "Razlog"),
            new System.Data.SqlClient.SqlParameter("@Param39", System.Data.SqlDbType.SmallInt, 2, "TA sis"),
            new System.Data.SqlClient.SqlParameter("@Param40", System.Data.SqlDbType.SmallInt, 2, "TA dia"),
            new System.Data.SqlClient.SqlParameter("@Param41", System.Data.SqlDbType.Bit, 1, "Srcana akcija"),
            new System.Data.SqlClient.SqlParameter("@Param42", System.Data.SqlDbType.NVarChar, 300, "Ekarteri ostalo"),
            new System.Data.SqlClient.SqlParameter("@Vagina", System.Data.SqlDbType.NVarChar, 300, "Vagina"),
            new System.Data.SqlClient.SqlParameter("@Grlic", System.Data.SqlDbType.NVarChar, 300, "Grlic"),
            new System.Data.SqlClient.SqlParameter("@Uterus", System.Data.SqlDbType.NVarChar, 300, "Uterus"),
            new System.Data.SqlClient.SqlParameter("@SMU", System.Data.SqlDbType.NVarChar, 300, "SMU"),
            new System.Data.SqlClient.SqlParameter("@Parametrija", System.Data.SqlDbType.NVarChar, 300, "Parametrija"),
            new System.Data.SqlClient.SqlParameter("@Adnesa", System.Data.SqlDbType.NVarChar, 300, "Adnesa"),
            new System.Data.SqlClient.SqlParameter("@Duglas", System.Data.SqlDbType.NVarChar, 300, "Duglas"),
            new System.Data.SqlClient.SqlParameter("@Prirastaj", System.Data.SqlDbType.Float, 8, "Prirastaj"),
            new System.Data.SqlClient.SqlParameter("@Original_PregledID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PregledID", System.Data.DataRowVersion.Original, null)});
            // 
            // TokPorodjaja
            // 
            this.Controls.Add(this.groupBox1);
            this.Name = "TokPorodjaja";
            this.Size = new System.Drawing.Size(282, 658);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protokolID)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label label5;


    }
}
