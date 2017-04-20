using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
//
namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for Anomalije.
	/// </summary>
	public class Anomalije : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private ParovicDS parovicDS1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private CheckList clCNS;
		private CheckList clSrce;
		private System.Data.DataView dataView1;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox10;
		private CheckList clOstalo;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.GroupBox groupBox5;
		private CheckList clGenTrakt;
		private System.Windows.Forms.GroupBox groupBox3;
		private CheckList clBlizanci;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.GroupBox groupBox8;
		private CheckList clLice;
		private System.Windows.Forms.GroupBox groupBox4;
		private CheckList clKicmeniStub;
		private System.Windows.Forms.GroupBox groupBox14;
		private CheckList clVrat;
		private System.Windows.Forms.GroupBox groupBox6;
		private CheckList clGrudniKos;
		private System.Windows.Forms.GroupBox groupBox16;
		private CheckList clPupcanaVrpca;
		private System.Windows.Forms.GroupBox groupBox1;
		private CheckList clAbdomen;
		private System.Windows.Forms.GroupBox groupBox2;
		private CheckList clGastrointestilni;
		private System.Windows.Forms.GroupBox groupBox9;
		private CheckList clUrinarni;
		private System.Windows.Forms.GroupBox groupBox11;
		private CheckList clSkelet;
		private System.Windows.Forms.GroupBox groupBox13;
		private CheckList clDisplSkeleta;
		private System.Windows.Forms.GroupBox groupBox12;
		private CheckList clSakaStopalo;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Anomalije(Int32 _protokolID)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			clKicmeniStub.ValBind.Add("Value", dataView1, "Kicmeni stub");
			clGrudniKos.ValBind.Add("Value", dataView1, "Grudni kos");
			clGastrointestilni.ValBind.Add("Value", dataView1, "Gastrointestilni trakt");
			clGenTrakt.ValBind.Add("Value", dataView1, "Genitalni trakt");
			clCNS.ValBind.Add("Value", dataView1, "Centralni nervni sistem");
			clBlizanci.ValBind.Add("Value", dataView1, "Blizanci");
			clAbdomen.ValBind.Add("Value", dataView1, "Abdomenalni zid");
			clUrinarni.ValBind.Add("Value", dataView1, "Urinarni trakt");
			clSrce.ValBind.Add("Value", dataView1, "Srce");
			clLice.ValBind.Add("Value", dataView1, "Lice");
			clDisplSkeleta.ValBind.Add("Value", dataView1, "Displazija skeleta");
			clVrat.ValBind.Add("Value", dataView1, "Vrat");
			clSakaStopalo.ValBind.Add("Value", dataView1, "Saka i stopalo");
			clSkelet.ValBind.Add("Value", dataView1, "Skelet");
			clPupcanaVrpca.ValBind.Add("Value", dataView1, "Pupcana vrpca");
			clOstalo.ValBind.Add("Value", dataView1, "Ostalo");

			ProtokolID = _protokolID;
			LoadControl();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anomalije));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clKicmeniStub = new CheckList();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.clVrat = new CheckList();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.clLice = new CheckList();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.clCNS = new CheckList();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clGrudniKos = new CheckList();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.clSrce = new CheckList();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clGastrointestilni = new CheckList();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clAbdomen = new CheckList();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.clPupcanaVrpca = new CheckList();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.clUrinarni = new CheckList();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clGenTrakt = new CheckList();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clBlizanci = new CheckList();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.clOstalo = new CheckList();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.clSakaStopalo = new CheckList();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.clDisplSkeleta = new CheckList();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.clSkelet = new CheckList();
            this.parovicDS1 = new ParovicDS();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dataView1 = new System.Data.DataView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 615);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(802, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "I";
            this.tabPage1.ToolTipText = "Lice CNS Vrat Kicma";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clKicmeniStub);
            this.groupBox4.Location = new System.Drawing.Point(536, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 144);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kicmeni Stub";
            // 
            // clKicmeniStub
            // 
            this.clKicmeniStub.ColumnWidth = 0;
            this.clKicmeniStub.ListMultiColumn = false;
            this.clKicmeniStub.Location = new System.Drawing.Point(16, 24);
            this.clKicmeniStub.Name = "clKicmeniStub";
            this.clKicmeniStub.SelectedIndex = 0;
            this.clKicmeniStub.SingleSelected = false;
            this.clKicmeniStub.Size = new System.Drawing.Size(160, 112);
            this.clKicmeniStub.StringItems = new string[] {
        "Agenesio sacruma",
        "Diastematomyelia",
        "Hemivertebre",
        "Meningo(myelo)coela",
        "Platyspondilia",
        "Sacrococcygealni teratom"};
            this.clKicmeniStub.TabIndex = 7;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.clVrat);
            this.groupBox14.Location = new System.Drawing.Point(536, 16);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(216, 144);
            this.groupBox14.TabIndex = 5;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Vrat";
            // 
            // clVrat
            // 
            this.clVrat.ColumnWidth = 0;
            this.clVrat.ListMultiColumn = false;
            this.clVrat.Location = new System.Drawing.Point(16, 32);
            this.clVrat.Name = "clVrat";
            this.clVrat.SelectedIndex = 0;
            this.clVrat.SingleSelected = false;
            this.clVrat.Size = new System.Drawing.Size(184, 99);
            this.clVrat.StringItems = new string[] {
        "Hygroma colli cysticum",
        "Nuchal oedema",
        "Nuchal translucency",
        "Struma (guavost)",
        "Teratoma reg. colli"};
            this.clVrat.TabIndex = 23;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.clLice);
            this.groupBox8.Location = new System.Drawing.Point(16, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(216, 296);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Lice";
            // 
            // clLice
            // 
            this.clLice.ColumnWidth = 0;
            this.clLice.ListMultiColumn = false;
            this.clLice.Location = new System.Drawing.Point(16, 24);
            this.clLice.Name = "clLice";
            this.clLice.SelectedIndex = 0;
            this.clLice.SingleSelected = false;
            this.clLice.Size = new System.Drawing.Size(184, 267);
            this.clLice.StringItems = new string[] {
        "Arhinia",
        "Cataracta",
        "Cyclopia",
        "Dacryocystocoela",
        "Epicanthalni nabor",
        "Epignathus",
        "Hypertelorisam",
        "Hypotelorisam",
        "Macroglossia",
        "Microphthalmia-anophthalmia",
        "Otocephalia",
        "Proboscis",
        "Rascep tvrdog nepca",
        "Rascepi lica",
        "Retinalno odlubljivanje",
        "Robin-ova anomalija"};
            this.clLice.TabIndex = 8;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.clCNS);
            this.groupBox7.Location = new System.Drawing.Point(264, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(240, 440);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Centralni Nervni System";
            // 
            // clCNS
            // 
            this.clCNS.ColumnWidth = 0;
            this.clCNS.ListMultiColumn = false;
            this.clCNS.Location = new System.Drawing.Point(16, 32);
            this.clCNS.Name = "clCNS";
            this.clCNS.SelectedIndex = 0;
            this.clCNS.SingleSelected = false;
            this.clCNS.Size = new System.Drawing.Size(208, 400);
            this.clCNS.StringItems = new string[] {
        "Acrania",
        "Agenezija cerebellum-a",
        "Anencephaly-a",
        "Aneurisma Galenove vene",
        "Aqueductalna stenoza",
        "Colpocephaly-a",
        "Cysta chorioidnog plexusa",
        "Dandy-Walker malformacija",
        "Disgenezija corpus callosuma",
        "Encephalocoela",
        "Hipoplazija cerebellarnog vermisa",
        "Holoprosencephalia",
        "Hydranencephalia",
        "Hydrocephalus",
        "Iniencephalia",
        "Intracranialna arachnoidna cysta",
        "Intrakranijalni tumori",
        "Komunikantni hydrocephalus",
        "Lissencephalia",
        "Macrocephalia",
        "Microcephalia",
        "Papilom chorioidnog plexusa",
        "Porencephalia",
        "Schizencephalia",
        "Spina bifida",
        "Unilateralna ventrikulomegalija"};
            this.clCNS.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(802, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "II";
            this.tabPage2.ToolTipText = "Grdni kos Srce";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clGrudniKos);
            this.groupBox6.Location = new System.Drawing.Point(16, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(280, 144);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Grudni Kos";
            // 
            // clGrudniKos
            // 
            this.clGrudniKos.ColumnWidth = 0;
            this.clGrudniKos.ListMultiColumn = false;
            this.clGrudniKos.Location = new System.Drawing.Point(16, 24);
            this.clGrudniKos.Name = "clGrudniKos";
            this.clGrudniKos.SelectedIndex = 0;
            this.clGrudniKos.SingleSelected = false;
            this.clGrudniKos.Size = new System.Drawing.Size(248, 112);
            this.clGrudniKos.StringItems = new string[] {
        "Bronhogene ciste",
        "Chylotorax",
        "Cisticna adenomatozna malformacija pluca",
        "Laringealna atresia",
        "Pleuralna efuzija",
        "Plucna sekvestracija"};
            this.clGrudniKos.TabIndex = 6;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.clSrce);
            this.groupBox10.Location = new System.Drawing.Point(16, 200);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(520, 304);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Srce";
            // 
            // clSrce
            // 
            this.clSrce.ColumnWidth = 240;
            this.clSrce.ListMultiColumn = true;
            this.clSrce.Location = new System.Drawing.Point(16, 32);
            this.clSrce.Name = "clSrce";
            this.clSrce.SelectedIndex = 0;
            this.clSrce.SingleSelected = false;
            this.clSrce.Size = new System.Drawing.Size(488, 264);
            this.clSrce.StringItems = new string[] {
        "Aneurisma levog venrticuluma",
        "Aortna stenosa",
        "ASD-Atrial septal defect",
        "Atrialna septalna aneurizma",
        "AV blok-Atrioventrikularni blok",
        "AVSD-Atrivoventricular septal defect",
        "Cardiosplenicni syndrom",
        "Double-outlet desni ventrikulum",
        "Ebstein-ova anomalija",
        "Ectopio cordis",
        "Endocardialna fibroelastosa",
        "Hemopericardium",
        "Hypoplasio levog srca",
        "Idiopatske infantilne arterialne kalcifikacije",
        "Intraperikardni teratom",
        "Isomerisam levog atriuma sa aspleniom",
        "Kardiomiopatije",
        "Koarktacija i tubularna hipoplazija aortnog luka",
        "Kompletna transpozicija velikih arterija",
        "Korigovana transpozicija velikih arterija",
        "Mitralna atresia",
        "Perikardna cista",
        "Perkardni teratom",
        "Prematurna atrialna I ventrikularna kontrakcija",
        "Pulmonalna stenoza",
        "Supraventrikularne tachyarrhytmia-e",
        "Tetralogio Fallot",
        "Trombosa vene cavae",
        "Truncus arteriosus",
        "Tumori srca",
        "Univentricularno srce",
        "VSD-Ventricular septal defect"};
            this.clSrce.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox16);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(802, 589);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "III";
            this.tabPage3.ToolTipText = "Abdomen Gastrointestilni trakt Pupcana vrpca";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clGastrointestilni);
            this.groupBox2.Location = new System.Drawing.Point(8, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 352);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastro-Intestilni Trakt";
            // 
            // clGastrointestilni
            // 
            this.clGastrointestilni.ColumnWidth = 0;
            this.clGastrointestilni.ListMultiColumn = false;
            this.clGastrointestilni.Location = new System.Drawing.Point(16, 32);
            this.clGastrointestilni.Name = "clGastrointestilni";
            this.clGastrointestilni.SelectedIndex = 0;
            this.clGastrointestilni.SingleSelected = false;
            this.clGastrointestilni.Size = new System.Drawing.Size(296, 312);
            this.clGastrointestilni.StringItems = new string[] {
        "Asplenio",
        "Atresio duodeni",
        "Atresio jejuni",
        "Atresio oesophagusa bez tracheo-esophagealne fistu",
        "Atresio oesophagusa sa tracheo-esophagealnom fistu",
        "Atresio pylori",
        "Ciste mesenterijuma,omentuma i retroperitoneuma",
        "Cystis ducti choledochi",
        "Cystis in hepatae",
        "Cystis in splene",
        "Duplicatio vesicae felleae",
        "Fibrosis cystica",
        "Hemangioma in hepatae",
        "Hepatomegalio",
        "Hirprungova bolest",
        "Mekonijalni peritonitis",
        "Obstrukcija creva",
        "Septatio vesicae felleae",
        "Splenomegalio"};
            this.clGastrointestilni.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clAbdomen);
            this.groupBox1.Location = new System.Drawing.Point(416, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abdomen";
            // 
            // clAbdomen
            // 
            this.clAbdomen.ColumnWidth = 0;
            this.clAbdomen.ListMultiColumn = false;
            this.clAbdomen.Location = new System.Drawing.Point(16, 24);
            this.clAbdomen.Name = "clAbdomen";
            this.clAbdomen.SelectedIndex = 0;
            this.clAbdomen.SingleSelected = false;
            this.clAbdomen.Size = new System.Drawing.Size(272, 120);
            this.clAbdomen.StringItems = new string[] {
        "Body stalk anomaly (anomalija telesnog stabla )",
        "Diafragmalna hernia",
        "Exstrophio vesicae urinariae et cloacae",
        "Gastroshisis (Gastroiza)",
        "Omphalocoela",
        "Pentalogio Cantrel"};
            this.clAbdomen.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.clPupcanaVrpca);
            this.groupBox16.Location = new System.Drawing.Point(416, 210);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(248, 168);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Pupcana Vrpca";
            // 
            // clPupcanaVrpca
            // 
            this.clPupcanaVrpca.ColumnWidth = 0;
            this.clPupcanaVrpca.ListMultiColumn = false;
            this.clPupcanaVrpca.Location = new System.Drawing.Point(16, 32);
            this.clPupcanaVrpca.Name = "clPupcanaVrpca";
            this.clPupcanaVrpca.SelectedIndex = 0;
            this.clPupcanaVrpca.SingleSelected = false;
            this.clPupcanaVrpca.Size = new System.Drawing.Size(216, 128);
            this.clPupcanaVrpca.StringItems = new string[] {
        "Allantoidna cista",
        "Hemangiom pupcanika",
        "Hematom pupcanika",
        "Omfalomezentericna cista",
        "Pravi cvor pupcanika",
        "Single umbillical artery",
        "Tromboza umbilikalnih krvnih sudova"};
            this.clPupcanaVrpca.TabIndex = 22;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox15);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(802, 589);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IV";
            this.tabPage4.ToolTipText = "Urinarni trakt Genitalni trakt Blizanci Ostalo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.clUrinarni);
            this.groupBox9.Location = new System.Drawing.Point(8, 16);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(520, 208);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Urinarni Trakt";
            // 
            // clUrinarni
            // 
            this.clUrinarni.ColumnWidth = 240;
            this.clUrinarni.ListMultiColumn = true;
            this.clUrinarni.Location = new System.Drawing.Point(16, 32);
            this.clUrinarni.Name = "clUrinarni";
            this.clUrinarni.SelectedIndex = 0;
            this.clUrinarni.SingleSelected = false;
            this.clUrinarni.Size = new System.Drawing.Size(488, 168);
            this.clUrinarni.StringItems = new string[] {
        "Agenesio meatus urethralis",
        "Bilateralna agenezija bubrega",
        "Ectopio renis ( pelvic ren )",
        "Infantilni policistcni bubrezi",
        "Intestinalni hipoperistalticki sindrom",
        "Izolovana cysta bubrega",
        "Kongenitalna adrenalna hiperplazija",
        "Kongenitalni adrenalni neuroblastom",
        "Kongenitalni mesoblastni nephrom",
        "Meckelov syndrom",
        "Megaureter",
        "Megaurethra",
        "Megavesica (Megabeika)",
        "Multicisticni bubrezi",
        "Obstrukcija ureteropelvicnog spoja",
        "Posteriorna (zadnja uretralna valvula )",
        "Prune-Belly syndroma",
        "Unilateralna agenezija bubrega",
        "Ureterocoela"};
            this.clUrinarni.TabIndex = 14;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clGenTrakt);
            this.groupBox5.Location = new System.Drawing.Point(256, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 160);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Genitalni Trakt";
            // 
            // clGenTrakt
            // 
            this.clGenTrakt.ColumnWidth = 0;
            this.clGenTrakt.ListMultiColumn = false;
            this.clGenTrakt.Location = new System.Drawing.Point(16, 24);
            this.clGenTrakt.Name = "clGenTrakt";
            this.clGenTrakt.SelectedIndex = 0;
            this.clGenTrakt.SingleSelected = false;
            this.clGenTrakt.Size = new System.Drawing.Size(184, 128);
            this.clGenTrakt.StringItems = new string[] {
        "Ambigiozne genitalije",
        "Cryptorchisam",
        "Cystis ovarii",
        "Edema labiae major",
        "Hydrocoella",
        "Hydrometrocolpos",
        "Hypospadia"};
            this.clGenTrakt.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clBlizanci);
            this.groupBox3.Location = new System.Drawing.Point(504, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 112);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blizanci";
            // 
            // clBlizanci
            // 
            this.clBlizanci.ColumnWidth = 0;
            this.clBlizanci.ListMultiColumn = false;
            this.clBlizanci.Location = new System.Drawing.Point(16, 24);
            this.clBlizanci.Name = "clBlizanci";
            this.clBlizanci.SelectedIndex = 0;
            this.clBlizanci.SingleSelected = false;
            this.clBlizanci.Size = new System.Drawing.Size(184, 80);
            this.clBlizanci.StringItems = new string[] {
        "Acardius",
        "Fetus in fetu",
        "Spojeni blizanci",
        "Twin to twin transfuzioni syndrom"};
            this.clBlizanci.TabIndex = 1;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.clOstalo);
            this.groupBox15.Location = new System.Drawing.Point(8, 280);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(216, 104);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Ostalo";
            // 
            // clOstalo
            // 
            this.clOstalo.ColumnWidth = 0;
            this.clOstalo.ListMultiColumn = false;
            this.clOstalo.Location = new System.Drawing.Point(16, 32);
            this.clOstalo.Name = "clOstalo";
            this.clOstalo.SelectedIndex = 0;
            this.clOstalo.SingleSelected = false;
            this.clOstalo.Size = new System.Drawing.Size(184, 64);
            this.clOstalo.StringItems = new string[] {
        "Amniotic band syndrom",
        "Neimuni fetalni hydrops",
        "Vaskularna hamartoza"};
            this.clOstalo.TabIndex = 21;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage5.Controls.Add(this.groupBox12);
            this.tabPage5.Controls.Add(this.groupBox13);
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(802, 589);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "V";
            this.tabPage5.ToolTipText = "Skelet Dispanzije skeleta Saka i Stopalo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.clSakaStopalo);
            this.groupBox12.Location = new System.Drawing.Point(8, 336);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(296, 248);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Saka i Stopalo";
            // 
            // clSakaStopalo
            // 
            this.clSakaStopalo.ColumnWidth = 0;
            this.clSakaStopalo.ListMultiColumn = false;
            this.clSakaStopalo.Location = new System.Drawing.Point(16, 32);
            this.clSakaStopalo.Name = "clSakaStopalo";
            this.clSakaStopalo.SelectedIndex = 0;
            this.clSakaStopalo.SingleSelected = false;
            this.clSakaStopalo.Size = new System.Drawing.Size(264, 208);
            this.clSakaStopalo.StringItems = new string[] {
        "Acheiria",
        "Acheiropodia",
        "Apodia",
        "Brachydactilia",
        "Ectrodactilia",
        "Hitchhiker thumb",
        "Kontraktura zglobova",
        "Kontrakturni deformiteti gornjih i donjih ekstremi",
        "Macrodactilia",
        "Postaxialna polydactilia",
        "Preaxialna polydactilia",
        "Rcker-bottom foot",
        "Syndactilia"};
            this.clSakaStopalo.TabIndex = 19;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.clDisplSkeleta);
            this.groupBox13.Location = new System.Drawing.Point(384, 8);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(360, 512);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Displazija skeleta";
            // 
            // clDisplSkeleta
            // 
            this.clDisplSkeleta.ColumnWidth = 0;
            this.clDisplSkeleta.ListMultiColumn = false;
            this.clDisplSkeleta.Location = new System.Drawing.Point(16, 32);
            this.clDisplSkeleta.Name = "clDisplSkeleta";
            this.clDisplSkeleta.SelectedIndex = 0;
            this.clDisplSkeleta.SingleSelected = false;
            this.clDisplSkeleta.Size = new System.Drawing.Size(328, 472);
            this.clDisplSkeleta.StringItems = new string[] {
        "Achondrogenesio",
        "Achondroplasio",
        "Apertov syndrom",
        "Arthrogryposis multiplex congenita",
        "Asfiksicna torakalna dysplasia",
        "Carpenterov syndrom",
        "Chondrodysplasio punctata",
        "Crouzon-ov syndrom",
        "Diastroficna dysplasia",
        "Displasia kolena",
        "Dyssegmentalna dysplasia",
        "Ellias-van Creveld-ov  syndrom",
        "Femoralna hypoplasia",
        "Fibrochondrogeneza",
        "Fryn-ov syndrom",
        "Hypophosphatasio",
        "Kamptomelicna dysplasia",
        "Klippel-Trenaunay-Weber-ov syndrom",
        "Kratko rebro-polydactilio syndrom",
        "Larsen-ov syndrom",
        "McKusik-ov syndrom",
        "Mesomelicna dysplasia",
        "Metatropicna dysplasia",
        "Osteogenesis imperfecta",
        "Otopalatodigitalni syndrom , tip II",
        "Pena-Shokeir syndrom",
        "Robert-ov syndrom",
        "Spondylo-epiphysealna  dysplasia",
        "Spondylo-torakalna displazija (Jarcho-Levin syndro",
        "Tantoforicna displazija",
        "Trombocitopenija sa odsutnim radijusom ( TAR syndr"};
            this.clDisplSkeleta.TabIndex = 21;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.clSkelet);
            this.groupBox11.Location = new System.Drawing.Point(8, 8);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(232, 320);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Skelet";
            // 
            // clSkelet
            // 
            this.clSkelet.ColumnWidth = 0;
            this.clSkelet.ListMultiColumn = false;
            this.clSkelet.Location = new System.Drawing.Point(16, 32);
            this.clSkelet.Name = "clSkelet";
            this.clSkelet.SelectedIndex = 0;
            this.clSkelet.SingleSelected = false;
            this.clSkelet.Size = new System.Drawing.Size(200, 280);
            this.clSkelet.StringItems = new string[] {
        "Aplazija ili hipoplazija dugih kostiju",
        "Demineralizacija kostiju",
        "Fraktura kostiju",
        "Frontalni bosing",
        "Hemivertebrae",
        "Hypoplasio clavicula",
        "Hypoplasio scapulae",
        "Hypoplasio thoracis",
        "Kratka rebra",
        "Kratki thorax",
        "Phocomelio",
        "Sacralna agenezija",
        "Scoliosis,kyphosis",
        "Strawberry shaped skull",
        "Syrenomelia",
        "Uzani thorax",
        "Vertebralna disorganizacija",
        "Zakrivljene duge kosti"};
            this.clSkelet.TabIndex = 18;
            // 
            // parovicDS1
            // 
            this.parovicDS1.DataSetName = "ParovicDS";
            this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-Latn-cs");
            this.parovicDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Anomalije", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("AnomalijeID", "AnomalijeID"),
                        new System.Data.Common.DataColumnMapping("ProtokolID", "ProtokolID"),
                        new System.Data.Common.DataColumnMapping("Abdomenalni zid", "Abdomenalni zid"),
                        new System.Data.Common.DataColumnMapping("Blizanci", "Blizanci"),
                        new System.Data.Common.DataColumnMapping("Centralni nervni sistem", "Centralni nervni sistem"),
                        new System.Data.Common.DataColumnMapping("Displazija skeleta", "Displazija skeleta"),
                        new System.Data.Common.DataColumnMapping("Gastrointestilni trakt", "Gastrointestilni trakt"),
                        new System.Data.Common.DataColumnMapping("Genitalni trakt", "Genitalni trakt"),
                        new System.Data.Common.DataColumnMapping("Grudni ko", "Grudni ko"),
                        new System.Data.Common.DataColumnMapping("Kicmeni stub", "Kicmeni stub"),
                        new System.Data.Common.DataColumnMapping("Lice", "Lice"),
                        new System.Data.Common.DataColumnMapping("Ostalo", "Ostalo"),
                        new System.Data.Common.DataColumnMapping("Pupcana vrpca", "Pupcana vrpca"),
                        new System.Data.Common.DataColumnMapping("aka i stopalo", "aka i stopalo"),
                        new System.Data.Common.DataColumnMapping("Skelet", "Skelet"),
                        new System.Data.Common.DataColumnMapping("Srce", "Srce"),
                        new System.Data.Common.DataColumnMapping("Urinarni trakt", "Urinarni trakt"),
                        new System.Data.Common.DataColumnMapping("Vrat", "Vrat")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Anomalije WHERE (AnomalijeID = @Original_AnomalijeID)";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_AnomalijeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AnomalijeID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProtokolID", System.Data.SqlDbType.Int, 4, "ProtokolID"),
            new System.Data.SqlClient.SqlParameter("@Param1", System.Data.SqlDbType.BigInt, 8, "Abdomenalni zid"),
            new System.Data.SqlClient.SqlParameter("@Blizanci", System.Data.SqlDbType.BigInt, 8, "Blizanci"),
            new System.Data.SqlClient.SqlParameter("@Param2", System.Data.SqlDbType.BigInt, 8, "Centralni nervni sistem"),
            new System.Data.SqlClient.SqlParameter("@Param3", System.Data.SqlDbType.BigInt, 8, "Displazija skeleta"),
            new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.BigInt, 8, "Gastrointestilni trakt"),
            new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.BigInt, 8, "Genitalni trakt"),
            new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.BigInt, 8, "Grudni kos"),
            new System.Data.SqlClient.SqlParameter("@Param7", System.Data.SqlDbType.BigInt, 8, "Kicmeni stub"),
            new System.Data.SqlClient.SqlParameter("@Lice", System.Data.SqlDbType.BigInt, 8, "Lice"),
            new System.Data.SqlClient.SqlParameter("@Ostalo", System.Data.SqlDbType.BigInt, 8, "Ostalo"),
            new System.Data.SqlClient.SqlParameter("@Param8", System.Data.SqlDbType.BigInt, 8, "Pupcana vrpca"),
            new System.Data.SqlClient.SqlParameter("@Param9", System.Data.SqlDbType.BigInt, 8, "Saka i stopalo"),
            new System.Data.SqlClient.SqlParameter("@Skelet", System.Data.SqlDbType.BigInt, 8, "Skelet"),
            new System.Data.SqlClient.SqlParameter("@Srce", System.Data.SqlDbType.BigInt, 8, "Srce"),
            new System.Data.SqlClient.SqlParameter("@Param10", System.Data.SqlDbType.BigInt, 8, "Urinarni trakt"),
            new System.Data.SqlClient.SqlParameter("@Vrat", System.Data.SqlDbType.BigInt, 8, "Vrat")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProtokolID", System.Data.SqlDbType.Int, 4, "ProtokolID")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProtokolID", System.Data.SqlDbType.Int, 4, "ProtokolID"),
            new System.Data.SqlClient.SqlParameter("@Param11", System.Data.SqlDbType.BigInt, 8, "Abdomenalni zid"),
            new System.Data.SqlClient.SqlParameter("@Blizanci", System.Data.SqlDbType.BigInt, 8, "Blizanci"),
            new System.Data.SqlClient.SqlParameter("@Param12", System.Data.SqlDbType.BigInt, 8, "Centralni nervni sistem"),
            new System.Data.SqlClient.SqlParameter("@Param13", System.Data.SqlDbType.BigInt, 8, "Displazija skeleta"),
            new System.Data.SqlClient.SqlParameter("@Param14", System.Data.SqlDbType.BigInt, 8, "Gastrointestilni trakt"),
            new System.Data.SqlClient.SqlParameter("@Param15", System.Data.SqlDbType.BigInt, 8, "Genitalni trakt"),
            new System.Data.SqlClient.SqlParameter("@Param16", System.Data.SqlDbType.BigInt, 8, "Grudni kos"),
            new System.Data.SqlClient.SqlParameter("@Param17", System.Data.SqlDbType.BigInt, 8, "Kicmeni stub"),
            new System.Data.SqlClient.SqlParameter("@Lice", System.Data.SqlDbType.BigInt, 8, "Lice"),
            new System.Data.SqlClient.SqlParameter("@Ostalo", System.Data.SqlDbType.BigInt, 8, "Ostalo"),
            new System.Data.SqlClient.SqlParameter("@Param18", System.Data.SqlDbType.BigInt, 8, "Pupcana vrpca"),
            new System.Data.SqlClient.SqlParameter("@Param19", System.Data.SqlDbType.BigInt, 8, "Saka i stopalo"),
            new System.Data.SqlClient.SqlParameter("@Skelet", System.Data.SqlDbType.BigInt, 8, "Skelet"),
            new System.Data.SqlClient.SqlParameter("@Srce", System.Data.SqlDbType.BigInt, 8, "Srce"),
            new System.Data.SqlClient.SqlParameter("@Param20", System.Data.SqlDbType.BigInt, 8, "Urinarni trakt"),
            new System.Data.SqlClient.SqlParameter("@Vrat", System.Data.SqlDbType.BigInt, 8, "Vrat"),
            new System.Data.SqlClient.SqlParameter("@Original_AnomalijeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AnomalijeID", System.Data.DataRowVersion.Original, null)});
            // 
            // dataView1
            // 
            this.dataView1.Table = this.parovicDS1.Anomalije;
            // 
            // Anomalije
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(810, 615);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anomalije";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fetalne Anomalije";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Anomalije_Closing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public bool SaveChanges(bool ask)
		{
			bool ret = false;
			try
			{
				this.BindingContext[dataView1].EndCurrentEdit();
				if(parovicDS1.HasChanges())
				{
					DialogResult res = DialogResult.Yes;
					if(ask)
						res = MessageBox.Show(this, "Zelite li da sacuvate nacinjene promene?", "Fetalne Anomalije", 
							MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

					if(res == DialogResult.Yes)
					{
						sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Anomalije");				
						ret = true;
					}
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(this.Name + e.Message);
			}
			return ret;
		}	

		public void LoadControl()
		{
			try
			{
				if(sqlConnection1.State != ConnectionState.Open	)
					sqlConnection1.Open();

				parovicDS1.Anomalije.Clear();
				Int32 count = sqlDataAdapter1.Fill(parovicDS1);
				if(count == 0)
				{
					parovicDS1.Anomalije.AddAnomalijeRow(ProtokolID, 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);
					sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Anomalije");
					parovicDS1.Anomalije.Clear();
					sqlDataAdapter1.Fill(parovicDS1);
				}
			}
			catch(Exception e)
			{
				MessageBox.Show(this.Name + e.Message);
			}
		}

		private void Anomalije_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			SaveChanges(true);
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SaveChanges(false);
		}

		internal Int32 ProtokolID
		{
			set
			{
				//protokolID = value;
				sqlDataAdapter1.SelectCommand.Parameters["@ProtokolID"].Value = value;
			}
			get
			{
				return (Int32) sqlDataAdapter1.SelectCommand.Parameters["@ProtokolID"].Value;
			}
		}

	}
}
