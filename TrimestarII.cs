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
    public class TrimestarII : System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ParovicDS parovicDS1;
        private System.Data.DataView dataView1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Windows.Forms.CheckBox bSkrining;
        private System.Windows.Forms.DateTimePicker dtSkrining;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Panel pSkrining;
        private NumericUpDown numTrimestar;
        private GroupBox groupBox5;
        private TextBox textBoxBrisovi;
        private GroupBox groupBox4;
        private TextBox textBoxAntitela;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox6;
        private Label label8;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public TrimestarII()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
        }

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

        public void SaveChanges()
        {
            try
            {
                this.BindingContext[dataView1].EndCurrentEdit();
                if (parovicDS1.HasChanges())
                {
                    sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Pregled");
                    LoadControl();
                }
            }
            catch (Exception e)
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
                if (sqlConnection1.State != ConnectionState.Open)
                    sqlConnection1.Open();

                parovicDS1.Pregled.Clear();
                col = sqlDataAdapter1.Fill(parovicDS1);

            }
            catch (Exception e)
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
                if (value != -1)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrimestarII));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataView1 = new System.Data.DataView();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.bSkrining = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pSkrining = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dtSkrining = new System.Windows.Forms.DateTimePicker();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.numTrimestar = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxBrisovi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAntitela = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.pSkrining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimestar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 198);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fetalni biomarkeri";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "InhibidAMo", true));
            this.textBox1.Location = new System.Drawing.Point(200, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "textBox1";
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
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "InhibidA", true));
            this.textBox2.Location = new System.Drawing.Point(96, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "textBox2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(160, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "MoM:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Inhibid A:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "sec scr", true));
            this.textBox6.Location = new System.Drawing.Point(200, 166);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "textBox6";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Rezultati biohemijskog skrininga :";
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Estriol Mo", true));
            this.textBox11.Location = new System.Drawing.Point(200, 80);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(40, 20);
            this.textBox11.TabIndex = 5;
            this.textBox11.Text = "textBox11";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "AFP Mo", true));
            this.textBox12.Location = new System.Drawing.Point(200, 48);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(40, 20);
            this.textBox12.TabIndex = 3;
            this.textBox12.Text = "textBox12";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "HCG Mo", true));
            this.textBox13.Location = new System.Drawing.Point(200, 24);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(40, 20);
            this.textBox13.TabIndex = 1;
            this.textBox13.Text = "textBox13";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Estriol", true));
            this.textBox10.Location = new System.Drawing.Point(96, 80);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(40, 20);
            this.textBox10.TabIndex = 4;
            this.textBox10.Text = "textBox10";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "AFP", true));
            this.textBox9.Location = new System.Drawing.Point(96, 48);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(40, 20);
            this.textBox9.TabIndex = 2;
            this.textBox9.Text = "textBox9";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "HCG", true));
            this.textBox8.Location = new System.Drawing.Point(96, 24);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(40, 20);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "textBox8";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(160, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "MoM:";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(8, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 38);
            this.label16.TabIndex = 18;
            this.label16.Text = "Nekonjugovani Estriol:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(160, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "MoM:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(8, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "AFP:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Location = new System.Drawing.Point(160, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "MoM:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "hCG:";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(136, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(40, 23);
            this.label31.TabIndex = 52;
            this.label31.Text = "60min:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(8, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 23);
            this.label32.TabIndex = 50;
            this.label32.Text = "0min:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bSkrining
            // 
            this.bSkrining.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "Skr glukoza", true));
            this.bSkrining.Location = new System.Drawing.Point(24, 24);
            this.bSkrining.Name = "bSkrining";
            this.bSkrining.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bSkrining.Size = new System.Drawing.Size(72, 24);
            this.bSkrining.TabIndex = 0;
            this.bSkrining.Text = "Radjen";
            this.bSkrining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(242, 8);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 16);
            this.label33.TabIndex = 54;
            this.label33.Text = "mmol/l";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(88, 8);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 16);
            this.label34.TabIndex = 55;
            this.label34.Text = "mmol/l";
            this.label34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bSkrining);
            this.groupBox3.Controls.Add(this.pSkrining);
            this.groupBox3.Location = new System.Drawing.Point(8, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 59);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skrining sa 50 gr glukoze ";
            // 
            // pSkrining
            // 
            this.pSkrining.Controls.Add(this.label31);
            this.pSkrining.Controls.Add(this.label32);
            this.pSkrining.Controls.Add(this.textBox3);
            this.pSkrining.Controls.Add(this.label33);
            this.pSkrining.Controls.Add(this.label34);
            this.pSkrining.Controls.Add(this.textBox5);
            this.pSkrining.Controls.Add(this.dtSkrining);
            this.pSkrining.Location = new System.Drawing.Point(112, 16);
            this.pSkrining.Name = "pSkrining";
            this.pSkrining.Size = new System.Drawing.Size(512, 40);
            this.pSkrining.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Skr glukoza  IgG1", true));
            this.textBox3.Location = new System.Drawing.Point(40, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "textBox3";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Skr glukoza  IgM1", true));
            this.textBox5.Location = new System.Drawing.Point(184, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.Text = "textBox5";
            // 
            // dtSkrining
            // 
            this.dtSkrining.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Skr glukoza Datum1", true));
            this.dtSkrining.Location = new System.Drawing.Point(304, 8);
            this.dtSkrining.Name = "dtSkrining";
            this.dtSkrining.Size = new System.Drawing.Size(200, 20);
            this.dtSkrining.TabIndex = 2;
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
                        new System.Data.Common.DataColumnMapping("Trimestar", "Trimestar"),
                        new System.Data.Common.DataColumnMapping("Cordocenthesis Res", "Cordocenthesis Res"),
                        new System.Data.Common.DataColumnMapping("Amniocenthesis Res", "Amniocenthesis Res"),
                        new System.Data.Common.DataColumnMapping("HemolCervikalni Res", "HemolCervikalni Res"),
                        new System.Data.Common.DataColumnMapping("HemolCervikalni", "HemolCervikalni"),
                        new System.Data.Common.DataColumnMapping("HemolUrino Res", "HemolUrino Res"),
                        new System.Data.Common.DataColumnMapping("HemolUrino", "HemolUrino"),
                        new System.Data.Common.DataColumnMapping("HbS Ag Res", "HbS Ag Res"),
                        new System.Data.Common.DataColumnMapping("HbS Ag", "HbS Ag"),
                        new System.Data.Common.DataColumnMapping("HIV Res", "HIV Res"),
                        new System.Data.Common.DataColumnMapping("HIV", "HIV"),
                        new System.Data.Common.DataColumnMapping("Profil7", "Profil7"),
                        new System.Data.Common.DataColumnMapping("Profil6", "Profil6"),
                        new System.Data.Common.DataColumnMapping("Profil5", "Profil5"),
                        new System.Data.Common.DataColumnMapping("Profil4", "Profil4"),
                        new System.Data.Common.DataColumnMapping("Profil3", "Profil3"),
                        new System.Data.Common.DataColumnMapping("Profil2", "Profil2"),
                        new System.Data.Common.DataColumnMapping("Profil1", "Profil1"),
                        new System.Data.Common.DataColumnMapping("Profil0", "Profil0"),
                        new System.Data.Common.DataColumnMapping("Glikemije 2hDor", "Glikemije 2hDor"),
                        new System.Data.Common.DataColumnMapping("Glikemije2hRuc", "Glikemije2hRuc"),
                        new System.Data.Common.DataColumnMapping("Glikemije Nataste", "Glikemije Nataste"),
                        new System.Data.Common.DataColumnMapping("Glikemije 2hVec", "Glikemije 2hVec"),
                        new System.Data.Common.DataColumnMapping("Prirastaj", "Prirastaj"),
                        new System.Data.Common.DataColumnMapping("PacijentID", "PacijentID"),
                        new System.Data.Common.DataColumnMapping("cvs rezultat", "cvs rezultat"),
                        new System.Data.Common.DataColumnMapping("BrisText", "BrisText"),
                        new System.Data.Common.DataColumnMapping("AntitelaText", "AntitelaText")})});
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
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.NVarChar, 2147483647, "BrisText"),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.VarChar, 2147483647, "AntitelaText"),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.SmallDateTime, 4, "Skr glukoza Datum1"),
            new System.Data.SqlClient.SqlParameter("@p4", System.Data.SqlDbType.Float, 8, "Skr glukoza  IgM1"),
            new System.Data.SqlClient.SqlParameter("@p5", System.Data.SqlDbType.Float, 8, "Skr glukoza  IgG1"),
            new System.Data.SqlClient.SqlParameter("@p6", System.Data.SqlDbType.Bit, 1, "Skr glukoza"),
            new System.Data.SqlClient.SqlParameter("@p7", System.Data.SqlDbType.Float, 8, "Estriol Mo"),
            new System.Data.SqlClient.SqlParameter("@p8", System.Data.SqlDbType.Float, 8, "Estriol"),
            new System.Data.SqlClient.SqlParameter("@p9", System.Data.SqlDbType.Float, 8, "AFP Mo"),
            new System.Data.SqlClient.SqlParameter("@p10", System.Data.SqlDbType.Float, 8, "AFP"),
            new System.Data.SqlClient.SqlParameter("@p11", System.Data.SqlDbType.Float, 8, "sec scr"),
            new System.Data.SqlClient.SqlParameter("@p12", System.Data.SqlDbType.Float, 8, "HCG Mo"),
            new System.Data.SqlClient.SqlParameter("@p13", System.Data.SqlDbType.Float, 8, "HCG"),
            new System.Data.SqlClient.SqlParameter("@p14", System.Data.SqlDbType.Float, 8, "InhibidA"),
            new System.Data.SqlClient.SqlParameter("@p15", System.Data.SqlDbType.Float, 8, "InhibidAMo"),
            new System.Data.SqlClient.SqlParameter("@Original_PregledID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PregledID", System.Data.DataRowVersion.Original, null)});
            // 
            // numTrimestar
            // 
            this.numTrimestar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataView1, "Trimestar", true));
            this.numTrimestar.Location = new System.Drawing.Point(584, 285);
            this.numTrimestar.Name = "numTrimestar";
            this.numTrimestar.ReadOnly = true;
            this.numTrimestar.Size = new System.Drawing.Size(56, 20);
            this.numTrimestar.TabIndex = 23;
            this.numTrimestar.ValueChanged += new System.EventHandler(this.numTrimestar_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxBrisovi);
            this.groupBox5.Location = new System.Drawing.Point(259, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 75);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bris";
            // 
            // textBoxBrisovi
            // 
            this.textBoxBrisovi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "BrisText", true));
            this.textBoxBrisovi.Location = new System.Drawing.Point(5, 19);
            this.textBoxBrisovi.Multiline = true;
            this.textBoxBrisovi.Name = "textBoxBrisovi";
            this.textBoxBrisovi.Size = new System.Drawing.Size(276, 50);
            this.textBoxBrisovi.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAntitela);
            this.groupBox4.Location = new System.Drawing.Point(259, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 76);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Antitela";
            // 
            // textBoxAntitela
            // 
            this.textBoxAntitela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "AntitelaText", true));
            this.textBoxAntitela.Location = new System.Drawing.Point(7, 20);
            this.textBoxAntitela.Multiline = true;
            this.textBoxAntitela.Name = "textBoxAntitela";
            this.textBoxAntitela.Size = new System.Drawing.Size(276, 50);
            this.textBoxAntitela.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(561, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 38);
            this.panel1.TabIndex = 26;
            // 
            // TrimestarII
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.numTrimestar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "TrimestarII";
            this.Size = new System.Drawing.Size(657, 322);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.pSkrining.ResumeLayout(false);
            this.pSkrining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimestar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void numTrimestar_ValueChanged(object sender, System.EventArgs e)
        {
            if ((sender as NumericUpDown).Value == 2M)
                this.Visible = true;
            else
                this.Visible = false;
        }

        public String Filter
        {
            get { return dataView1.RowFilter; }
            set { dataView1.RowFilter = value; }
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
