using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parovic.Akuserstvo
{
    partial class Anamneza
    {
        #region "Atributes"

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ParovicDS parovicDS1;
        private System.Data.DataView dataView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public DateTime TerminDT;
        public TimeSpan TrudnocaTS;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private CheckList AlergijeCL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtUZTP;
        private System.Windows.Forms.DateTimePicker dtPM;
        private System.Windows.Forms.DateTimePicker dtOTP;
        private System.Windows.Forms.Label labelIotp;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbKG;
        private System.Windows.Forms.ComboBox cbRhF;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox tPorVreme;
        private System.Windows.Forms.TextBox tPorPre;
        public System.Windows.Forms.TextBox tVisina;
        public System.Windows.Forms.TextBox tTezina;

        private System.Windows.Forms.TextBox tAlergije;
        private System.Windows.Forms.TextBox tOperacije;
        private System.Windows.Forms.TextBox tSpontanih;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tNamernih;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lPorodjaja;
        private System.Windows.Forms.Label lPobacaja;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbRhF_Suprug;
        private System.Windows.Forms.ComboBox cbKG_suprug;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxMenstruacije;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBMI;
        #endregion

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anamneza));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBMI = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbKG = new System.Windows.Forms.ComboBox();
            this.cbRhF_Suprug = new System.Windows.Forms.ComboBox();
            this.cbRhF = new System.Windows.Forms.ComboBox();
            this.cbKG_suprug = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tAlergije = new System.Windows.Forms.TextBox();
            this.dataView1 = new System.Data.DataView();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.tOperacije = new System.Windows.Forms.TextBox();
            this.tVisina = new System.Windows.Forms.TextBox();
            this.tTezina = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.AlergijeCL = new Parovic.Akuserstvo.CheckList();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMenstruacije = new System.Windows.Forms.TextBox();
            this.labelIotp = new System.Windows.Forms.Label();
            this.dtUZTP = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtPM = new System.Windows.Forms.DateTimePicker();
            this.dtOTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lPobacaja = new System.Windows.Forms.Label();
            this.lPorodjaja = new System.Windows.Forms.Label();
            this.tNamernih = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tSpontanih = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tPorVreme = new System.Windows.Forms.TextBox();
            this.tPorPre = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zivorodjene dece:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mrtvorodjene dece:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Pobacaja:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tAlergije);
            this.groupBox1.Controls.Add(this.tOperacije);
            this.groupBox1.Controls.Add(this.AlergijeCL);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Licna";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMI.Location = new System.Drawing.Point(589, 519);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(77, 20);
            this.labelBMI.TabIndex = 38;
            this.labelBMI.Text = "BMI: 0:00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbKG);
            this.groupBox5.Controls.Add(this.cbRhF_Suprug);
            this.groupBox5.Controls.Add(this.cbRhF);
            this.groupBox5.Controls.Add(this.cbKG_suprug);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(757, 516);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 124);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Krvna grupa";
            // 
            // cbKG
            // 
            this.cbKG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cbKG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbKG.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "AB",
            "0"});
            this.cbKG.Location = new System.Drawing.Point(115, 34);
            this.cbKG.Name = "cbKG";
            this.cbKG.Size = new System.Drawing.Size(48, 29);
            this.cbKG.TabIndex = 14;
            // 
            // cbRhF_Suprug
            // 
            this.cbRhF_Suprug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRhF_Suprug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cbRhF_Suprug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbRhF_Suprug.Items.AddRange(new object[] {
            "",
            "+",
            "-"});
            this.cbRhF_Suprug.Location = new System.Drawing.Point(171, 75);
            this.cbRhF_Suprug.Name = "cbRhF_Suprug";
            this.cbRhF_Suprug.Size = new System.Drawing.Size(40, 29);
            this.cbRhF_Suprug.TabIndex = 35;
            // 
            // cbRhF
            // 
            this.cbRhF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRhF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cbRhF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbRhF.Items.AddRange(new object[] {
            "",
            "+",
            "-"});
            this.cbRhF.Location = new System.Drawing.Point(171, 34);
            this.cbRhF.Name = "cbRhF";
            this.cbRhF.Size = new System.Drawing.Size(40, 29);
            this.cbRhF.TabIndex = 15;
            // 
            // cbKG_suprug
            // 
            this.cbKG_suprug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKG_suprug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cbKG_suprug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbKG_suprug.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "AB",
            "0"});
            this.cbKG_suprug.Location = new System.Drawing.Point(115, 75);
            this.cbKG_suprug.Name = "cbKG_suprug";
            this.cbKG_suprug.Size = new System.Drawing.Size(48, 29);
            this.cbKG_suprug.TabIndex = 34;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(6, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 23);
            this.label24.TabIndex = 33;
            this.label24.Text = "Pacijentkinja:";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(6, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 23);
            this.label26.TabIndex = 36;
            this.label26.Text = "Suprug:";
            // 
            // tAlergije
            // 
            this.tAlergije.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Alergije Drugo", true));
            this.tAlergije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAlergije.Location = new System.Drawing.Point(8, 184);
            this.tAlergije.Multiline = true;
            this.tAlergije.Name = "tAlergije";
            this.tAlergije.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tAlergije.Size = new System.Drawing.Size(192, 56);
            this.tAlergije.TabIndex = 1;
            // 
            // dataView1
            // 
            this.dataView1.Table = this.parovicDS1.Anamneza;
            // 
            // parovicDS1
            // 
            this.parovicDS1.DataSetName = "ParovicDS";
            this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.parovicDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tOperacije
            // 
            this.tOperacije.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Operacije", true));
            this.tOperacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOperacije.HideSelection = false;
            this.tOperacije.Location = new System.Drawing.Point(206, 51);
            this.tOperacije.Multiline = true;
            this.tOperacije.Name = "tOperacije";
            this.tOperacije.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tOperacije.Size = new System.Drawing.Size(370, 189);
            this.tOperacije.TabIndex = 16;
            // 
            // tVisina
            // 
            this.tVisina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Visina", true));
            this.tVisina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVisina.Location = new System.Drawing.Point(468, 547);
            this.tVisina.Name = "tVisina";
            this.tVisina.Size = new System.Drawing.Size(57, 26);
            this.tVisina.TabIndex = 13;
            this.tVisina.Text = "textBox12";
            this.tVisina.TextChanged += new System.EventHandler(this.tVisina_TextChanged);
            // 
            // tTezina
            // 
            this.tTezina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Tezina", true));
            this.tTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTezina.Location = new System.Drawing.Point(468, 515);
            this.tTezina.Name = "tTezina";
            this.tTezina.Size = new System.Drawing.Size(57, 26);
            this.tTezina.TabIndex = 12;
            this.tTezina.Text = "textBox13";
            this.tTezina.TextChanged += new System.EventHandler(this.tTezina_TextChanged);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(533, 547);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 24);
            this.label19.TabIndex = 30;
            this.label19.Text = "cm";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(533, 515);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 24);
            this.label20.TabIndex = 29;
            this.label20.Text = "kg";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(398, 547);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 24);
            this.label18.TabIndex = 28;
            this.label18.Text = "Visina:";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(398, 515);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 24);
            this.label17.TabIndex = 26;
            this.label17.Text = "Tezina:";
            // 
            // AlergijeCL
            // 
            this.AlergijeCL.ColumnWidth = 0;
            this.AlergijeCL.ListMultiColumn = false;
            this.AlergijeCL.Location = new System.Drawing.Point(8, 48);
            this.AlergijeCL.Name = "AlergijeCL";
            this.AlergijeCL.SelectedIndex = 0;
            this.AlergijeCL.SingleSelected = false;
            this.AlergijeCL.Size = new System.Drawing.Size(192, 144);
            this.AlergijeCL.StringItems = new string[] {
        "Penicillin",
        "Bactrim",
        "Jod",
        "Acetilsalicilna kiselina",
        "Cefalosporine",
        "Gentamycin"};
            this.AlergijeCL.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(208, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Prethodne bolesti i operacije:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Alergije:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMenstruacije);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anamneza Menstruacije";
            // 
            // textBoxMenstruacije
            // 
            this.textBoxMenstruacije.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "MenstruacijeText", true));
            this.textBoxMenstruacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMenstruacije.HideSelection = false;
            this.textBoxMenstruacije.Location = new System.Drawing.Point(12, 128);
            this.textBoxMenstruacije.Multiline = true;
            this.textBoxMenstruacije.Name = "textBoxMenstruacije";
            this.textBoxMenstruacije.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMenstruacije.Size = new System.Drawing.Size(460, 100);
            this.textBoxMenstruacije.TabIndex = 83;
            // 
            // labelIotp
            // 
            this.labelIotp.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIotp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelIotp.Location = new System.Drawing.Point(70, 592);
            this.labelIotp.Name = "labelIotp";
            this.labelIotp.Size = new System.Drawing.Size(312, 43);
            this.labelIotp.TabIndex = 81;
            this.labelIotp.Text = "lOTP";
            this.labelIotp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtUZTP
            // 
            this.dtUZTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "UZTP", true));
            this.dtUZTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtUZTP.Location = new System.Drawing.Point(74, 564);
            this.dtUZTP.Name = "dtUZTP";
            this.dtUZTP.Size = new System.Drawing.Size(280, 26);
            this.dtUZTP.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(10, 604);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 23);
            this.label21.TabIndex = 79;
            this.label21.Text = "OTP:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(10, 564);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 23);
            this.label13.TabIndex = 77;
            this.label13.Text = "UZTP:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(10, 516);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 23);
            this.label14.TabIndex = 75;
            this.label14.Text = "PM:";
            // 
            // dtPM
            // 
            this.dtPM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "PM", true));
            this.dtPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtPM.Location = new System.Drawing.Point(74, 516);
            this.dtPM.Name = "dtPM";
            this.dtPM.Size = new System.Drawing.Size(280, 26);
            this.dtPM.TabIndex = 6;
            this.dtPM.ValueChanged += new System.EventHandler(this.dtPM_ValueChanged);
            // 
            // dtOTP
            // 
            this.dtOTP.Enabled = false;
            this.dtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtOTP.Location = new System.Drawing.Point(82, 604);
            this.dtOTP.Name = "dtOTP";
            this.dtOTP.Size = new System.Drawing.Size(224, 26);
            this.dtOTP.TabIndex = 80;
            this.dtOTP.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lPobacaja);
            this.groupBox3.Controls.Add(this.lPorodjaja);
            this.groupBox3.Controls.Add(this.tNamernih);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.tSpontanih);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tPorVreme);
            this.groupBox3.Controls.Add(this.tPorPre);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(495, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 234);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prethodni Porodjaji";
            // 
            // lPobacaja
            // 
            this.lPobacaja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Pobacaja", true));
            this.lPobacaja.Location = new System.Drawing.Point(286, 86);
            this.lPobacaja.Name = "lPobacaja";
            this.lPobacaja.Size = new System.Drawing.Size(40, 23);
            this.lPobacaja.TabIndex = 95;
            this.lPobacaja.Text = "label27";
            // 
            // lPorodjaja
            // 
            this.lPorodjaja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Porodjaja", true));
            this.lPorodjaja.Location = new System.Drawing.Point(439, 86);
            this.lPorodjaja.Name = "lPorodjaja";
            this.lPorodjaja.Size = new System.Drawing.Size(40, 23);
            this.lPorodjaja.TabIndex = 94;
            this.lPorodjaja.Text = "label26";
            // 
            // tNamernih
            // 
            this.tNamernih.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Pobacaja Namernih", true));
            this.tNamernih.Location = new System.Drawing.Point(286, 54);
            this.tNamernih.Name = "tNamernih";
            this.tNamernih.Size = new System.Drawing.Size(40, 26);
            this.tNamernih.TabIndex = 3;
            this.tNamernih.Text = "textBox10";
            this.tNamernih.TextChanged += new System.EventHandler(this.tNamernih_TextChanged);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(198, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 24);
            this.label25.TabIndex = 93;
            this.label25.Text = "Namernih:";
            // 
            // tSpontanih
            // 
            this.tSpontanih.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Pobacaja Spontanih", true));
            this.tSpontanih.Location = new System.Drawing.Point(286, 22);
            this.tSpontanih.Name = "tSpontanih";
            this.tSpontanih.Size = new System.Drawing.Size(40, 26);
            this.tSpontanih.TabIndex = 2;
            this.tSpontanih.Text = "textBox10";
            this.tSpontanih.TextChanged += new System.EventHandler(this.tSpontanih_TextChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(198, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 24);
            this.label15.TabIndex = 91;
            this.label15.Text = "Spontanih:";
            // 
            // tPorVreme
            // 
            this.tPorVreme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Porodjaja Vreme", true));
            this.tPorVreme.Location = new System.Drawing.Point(439, 54);
            this.tPorVreme.Name = "tPorVreme";
            this.tPorVreme.Size = new System.Drawing.Size(40, 26);
            this.tPorVreme.TabIndex = 5;
            this.tPorVreme.Text = "textBox12";
            this.tPorVreme.TextChanged += new System.EventHandler(this.tPorVreme_TextChanged);
            // 
            // tPorPre
            // 
            this.tPorPre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Porodjaja Pre", true));
            this.tPorPre.Location = new System.Drawing.Point(439, 22);
            this.tPorPre.Name = "tPorPre";
            this.tPorPre.Size = new System.Drawing.Size(40, 26);
            this.tPorPre.TabIndex = 4;
            this.tPorPre.Text = "textBox13";
            this.tPorPre.TextChanged += new System.EventHandler(this.tPorPre_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Dece mrtvo", true));
            this.textBox9.Location = new System.Drawing.Point(152, 56);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(40, 26);
            this.textBox9.TabIndex = 1;
            this.textBox9.Text = "textBox9";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Dece zivo", true));
            this.textBox8.Location = new System.Drawing.Point(152, 24);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(40, 26);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "textBox8";
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Porodjaji", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point(8, 128);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(479, 100);
            this.textBox3.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(342, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 24);
            this.label23.TabIndex = 27;
            this.label23.Text = "Porodjaja:";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(342, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 24);
            this.label22.TabIndex = 25;
            this.label22.Text = "Na vreme:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prevremenih:";
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Anamneza", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("AnamnezaID", "AnamnezaID"),
                        new System.Data.Common.DataColumnMapping("PacijentID", "PacijentID"),
                        new System.Data.Common.DataColumnMapping("Alergije", "Alergije"),
                        new System.Data.Common.DataColumnMapping("Licna", "Licna"),
                        new System.Data.Common.DataColumnMapping("Porodicna", "Porodicna"),
                        new System.Data.Common.DataColumnMapping("Alergije Drugo", "Alergije Drugo"),
                        new System.Data.Common.DataColumnMapping("Operacije", "Operacije"),
                        new System.Data.Common.DataColumnMapping("Menarha", "Menarha"),
                        new System.Data.Common.DataColumnMapping("Ciklus od", "Ciklus od"),
                        new System.Data.Common.DataColumnMapping("ciklus do", "ciklus do"),
                        new System.Data.Common.DataColumnMapping("ciklus trajanje", "ciklus trajanje"),
                        new System.Data.Common.DataColumnMapping("Rizici", "Rizici"),
                        new System.Data.Common.DataColumnMapping("Porodjaja", "Porodjaja"),
                        new System.Data.Common.DataColumnMapping("Pobacaja", "Pobacaja"),
                        new System.Data.Common.DataColumnMapping("Dece zivo", "Dece zivo"),
                        new System.Data.Common.DataColumnMapping("Dece mrtvo", "Dece mrtvo"),
                        new System.Data.Common.DataColumnMapping("Kontracepcija", "Kontracepcija"),
                        new System.Data.Common.DataColumnMapping("Mens kol", "Mens kol"),
                        new System.Data.Common.DataColumnMapping("Mens bol", "Mens bol"),
                        new System.Data.Common.DataColumnMapping("PM", "PM"),
                        new System.Data.Common.DataColumnMapping("UZTP", "UZTP"),
                        new System.Data.Common.DataColumnMapping("KG Suprug", "KG Suprug"),
                        new System.Data.Common.DataColumnMapping("RhFactor Suprug", "RhFactor Suprug")})});
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
            new System.Data.SqlClient.SqlParameter("@Alergije", System.Data.SqlDbType.Int, 4, "Alergije"),
            new System.Data.SqlClient.SqlParameter("@Param9", System.Data.SqlDbType.NVarChar, 111, "Alergije Drugo"),
            new System.Data.SqlClient.SqlParameter("@Operacije", System.Data.SqlDbType.NVarChar, 950, "Operacije"),
            new System.Data.SqlClient.SqlParameter("@Porodjaja", System.Data.SqlDbType.SmallInt, 2, "Porodjaja"),
            new System.Data.SqlClient.SqlParameter("@Pobacaja", System.Data.SqlDbType.SmallInt, 2, "Pobacaja"),
            new System.Data.SqlClient.SqlParameter("@DeceZivo", System.Data.SqlDbType.SmallInt, 2, "Dece zivo"),
            new System.Data.SqlClient.SqlParameter("@DeceMrtvo", System.Data.SqlDbType.SmallInt, 2, "Dece mrtvo"),
            new System.Data.SqlClient.SqlParameter("@PM", System.Data.SqlDbType.SmallDateTime, 4, "PM"),
            new System.Data.SqlClient.SqlParameter("@UZTP", System.Data.SqlDbType.SmallDateTime, 4, "UZTP"),
            new System.Data.SqlClient.SqlParameter("@tezina", System.Data.SqlDbType.Float, 8, "Tezina"),
            new System.Data.SqlClient.SqlParameter("@visina", System.Data.SqlDbType.SmallInt, 2, "Visina"),
            new System.Data.SqlClient.SqlParameter("@param18", System.Data.SqlDbType.SmallInt, 2, "Porodjaja Pre"),
            new System.Data.SqlClient.SqlParameter("@param19", System.Data.SqlDbType.SmallInt, 2, "Porodjaja Vreme"),
            new System.Data.SqlClient.SqlParameter("@param20", System.Data.SqlDbType.SmallInt, 2, "KG"),
            new System.Data.SqlClient.SqlParameter("@param21", System.Data.SqlDbType.SmallInt, 2, "RhFactor"),
            new System.Data.SqlClient.SqlParameter("@param32", System.Data.SqlDbType.SmallInt, 2, "Pobacaja Spontanih"),
            new System.Data.SqlClient.SqlParameter("@param33", System.Data.SqlDbType.SmallInt, 2, "Pobacaja Namernih"),
            new System.Data.SqlClient.SqlParameter("@param34", System.Data.SqlDbType.SmallInt, 2, "KG Suprug"),
            new System.Data.SqlClient.SqlParameter("@param35", System.Data.SqlDbType.SmallInt, 2, "RhFactor Suprug"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.VarChar, 1050, "Porodjaji"),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.NVarChar, 2147483647, "PorodicnaText"),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.NVarChar, 2147483647, "MenstruacijeText"),
            new System.Data.SqlClient.SqlParameter("@Original_AnamnezaID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AnamnezaID", System.Data.DataRowVersion.Original, null)});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(602, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 256);
            this.groupBox4.TabIndex = 96;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Porodicna Anamneza i faktori rizika";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "PorodicnaText", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(11, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(366, 199);
            this.textBox1.TabIndex = 84;
            // 
            // Anamneza
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.labelIotp);
            this.Controls.Add(this.dtUZTP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tTezina);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tVisina);
            this.Controls.Add(this.dtPM);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtOTP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Anamneza";
            this.Size = new System.Drawing.Size(992, 654);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

    }
}
