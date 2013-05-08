namespace Parovic.Akuserstvo
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public partial class MainForm
    {
        #region "Attributes"        
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage generalijeTabPage;
        private System.Windows.Forms.TabPage anamnezaTabPage;
        private System.Windows.Forms.TabPage tokTabPage;
        private Generalije generalije1;
        private Anamneza anamneza1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton separ1Btn;
        private System.Windows.Forms.ToolBarButton PrevBtn;
        private System.Windows.Forms.ToolBarButton NextBtn;
        private System.Windows.Forms.ToolBarButton allBtn;
        private System.Windows.Forms.ToolBarButton separ2Btn;
        private System.Windows.Forms.ToolBarButton separ3;
        private System.Windows.Forms.ToolBarButton delProtokolBtn;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton previewBtn;
        private System.Windows.Forms.ToolBarButton printBtn;
        private System.Windows.Forms.ToolBarButton aboutBtn;
        private System.Windows.Forms.StatusBar statusBar1;
        internal System.Windows.Forms.StatusBarPanel statusBarPanelID;
        internal System.Windows.Forms.StatusBarPanel statusBarPanelIme;
        internal System.Windows.Forms.StatusBarPanel statusBarPanelPrezime;
        private TokPorodjaja tokPorodjaja1;
        private TrimestarI trimestarI1;
        private Dijagnoza dijagnoza1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private TrimestarII trimestarII1;
        private TrimestarIII trimestarIII1;
        private System.Windows.Forms.MenuItem ImenuItem;
        private System.Windows.Forms.MenuItem IImenuItem;
        private System.Windows.Forms.MenuItem IIImenuItem;
        private System.Windows.Forms.StatusBarPanel statusBarPanelTermin;
        private System.Windows.Forms.ToolBarButton NewPregledBtn;
        private System.Windows.Forms.ToolBarButton NewPatientBtn;
        private System.Windows.Forms.StatusBarPanel statusBarPanelUZTP;
        private System.Windows.Forms.StatusBarPanel statusBarPanelPoli;
        private System.Windows.Forms.StatusBarPanel statusBarPanelGS;
        private System.Windows.Forms.StatusBarPanel lGS;
        private System.Windows.Forms.StatusBarPanel lTP;
        private System.Windows.Forms.StatusBarPanel lUZTP;
        private System.Windows.Forms.ToolBarButton filterBtn;
        private System.Windows.Forms.ToolBarButton separ4;
        private Info info1;
        private System.Windows.Forms.ToolBarButton kalendarBtn;
        private System.Windows.Forms.ToolBarButton separ5;
        private System.Windows.Forms.ToolBarButton FirstBtn;
        private System.Windows.Forms.ToolBarButton LastBtn;
        private System.Windows.Forms.MenuItem menuItemTrim1;
        private System.Windows.Forms.MenuItem menuItemTrim2;
        private System.Windows.Forms.MenuItem menuItemTrim3;
        private ParovicDS parovicDS1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.ComponentModel.IContainer components;
        private System.Data.SqlClient.SqlCommand sqlCmdLastPatID;
        
        private System.Windows.Forms.ToolBarButton saveBtn;
        private System.Windows.Forms.TabPage tabPageKolpo;
        private Kolpo kolpo1;
        private System.Windows.Forms.TabPage tabPageUZ;
        private UltrazvukControl _ultrazvukControl;
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTab = new System.Windows.Forms.TabControl();
            this.generalijeTabPage = new System.Windows.Forms.TabPage();
            this.generalije1 = new Parovic.Akuserstvo.Generalije();
            this.anamnezaTabPage = new System.Windows.Forms.TabPage();
            this.anamneza1 = new Parovic.Akuserstvo.Anamneza();
            this.tokTabPage = new System.Windows.Forms.TabPage();
            this.dijagnoza1 = new Parovic.Akuserstvo.Dijagnoza();
            this.info1 = new Parovic.Akuserstvo.Info();
            this.trimestarIII1 = new Parovic.Akuserstvo.TrimestarIII();
            this.trimestarII1 = new Parovic.Akuserstvo.TrimestarII();
            this.trimestarI1 = new Parovic.Akuserstvo.TrimestarI();
            this.tokPorodjaja1 = new Parovic.Akuserstvo.TokPorodjaja();
            this.tabPageKolpo = new System.Windows.Forms.TabPage();
            this.kolpo1 = new Parovic.Akuserstvo.Kolpo();
            this.tabPageUZ = new System.Windows.Forms.TabPage();
            this._ultrazvukControl = new Parovic.Akuserstvo.UltrazvukControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.NewPregledBtn = new System.Windows.Forms.ToolBarButton();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.ImenuItem = new System.Windows.Forms.MenuItem();
            this.IImenuItem = new System.Windows.Forms.MenuItem();
            this.IIImenuItem = new System.Windows.Forms.MenuItem();
            this.NewPatientBtn = new System.Windows.Forms.ToolBarButton();
            this.saveBtn = new System.Windows.Forms.ToolBarButton();
            this.separ1Btn = new System.Windows.Forms.ToolBarButton();
            this.FirstBtn = new System.Windows.Forms.ToolBarButton();
            this.PrevBtn = new System.Windows.Forms.ToolBarButton();
            this.NextBtn = new System.Windows.Forms.ToolBarButton();
            this.LastBtn = new System.Windows.Forms.ToolBarButton();
            this.allBtn = new System.Windows.Forms.ToolBarButton();
            this.separ2Btn = new System.Windows.Forms.ToolBarButton();
            this.separ3 = new System.Windows.Forms.ToolBarButton();
            this.delProtokolBtn = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.previewBtn = new System.Windows.Forms.ToolBarButton();
            this.printBtn = new System.Windows.Forms.ToolBarButton();
            this.separ4 = new System.Windows.Forms.ToolBarButton();
            this.filterBtn = new System.Windows.Forms.ToolBarButton();
            this.kalendarBtn = new System.Windows.Forms.ToolBarButton();
            this.separ5 = new System.Windows.Forms.ToolBarButton();
            this.aboutBtn = new System.Windows.Forms.ToolBarButton();
            this.menuItemTrim1 = new System.Windows.Forms.MenuItem();
            this.menuItemTrim2 = new System.Windows.Forms.MenuItem();
            this.menuItemTrim3 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanelID = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelIme = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelPrezime = new System.Windows.Forms.StatusBarPanel();
            this.lGS = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelGS = new System.Windows.Forms.StatusBarPanel();
            this.lTP = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelTermin = new System.Windows.Forms.StatusBarPanel();
            this.lUZTP = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelUZTP = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanelPoli = new System.Windows.Forms.StatusBarPanel();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCmdLastPatID = new System.Data.SqlClient.SqlCommand();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.mainTab.SuspendLayout();
            this.generalijeTabPage.SuspendLayout();
            this.anamnezaTabPage.SuspendLayout();
            this.tokTabPage.SuspendLayout();
            this.tabPageKolpo.SuspendLayout();
            this.tabPageUZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelTermin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUZTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelUZTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelPoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.generalijeTabPage);
            this.mainTab.Controls.Add(this.anamnezaTabPage);
            this.mainTab.Controls.Add(this.tokTabPage);
            this.mainTab.Controls.Add(this.tabPageKolpo);
            this.mainTab.Controls.Add(this.tabPageUZ);
            this.mainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTab.Location = new System.Drawing.Point(0, 32);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(1061, 680);
            this.mainTab.TabIndex = 0;
            this.mainTab.SelectedIndexChanged += new System.EventHandler(this.mainTab_SelectedIndexChanged);
            // 
            // generalijeTabPage
            // 
            this.generalijeTabPage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generalijeTabPage.Controls.Add(this.generalije1);
            this.generalijeTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalijeTabPage.Name = "generalijeTabPage";
            this.generalijeTabPage.Size = new System.Drawing.Size(1053, 654);
            this.generalijeTabPage.TabIndex = 0;
            this.generalijeTabPage.Text = "Generalije";
            this.generalijeTabPage.UseVisualStyleBackColor = true;
            // 
            // generalije1
            // 
            this.generalije1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.generalije1.CurrentPosition = -1;
            this.generalije1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalije1.Filter = "";
            this.generalije1.Location = new System.Drawing.Point(0, 0);
            this.generalije1.Name = "generalije1";
            this.generalije1.Size = new System.Drawing.Size(1053, 654);
            this.generalije1.TabIndex = 0;
            // 
            // anamnezaTabPage
            // 
            this.anamnezaTabPage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.anamnezaTabPage.Controls.Add(this.anamneza1);
            this.anamnezaTabPage.Location = new System.Drawing.Point(4, 22);
            this.anamnezaTabPage.Name = "anamnezaTabPage";
            this.anamnezaTabPage.Size = new System.Drawing.Size(192, 74);
            this.anamnezaTabPage.TabIndex = 1;
            this.anamnezaTabPage.Text = "Anamneza";
            this.anamnezaTabPage.UseVisualStyleBackColor = true;
            // 
            // anamneza1
            // 
            this.anamneza1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.anamneza1.CurrentPosition = -1;
            this.anamneza1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anamneza1.Filter = "";
            this.anamneza1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anamneza1.Location = new System.Drawing.Point(0, 0);
            this.anamneza1.Name = "anamneza1";
            this.anamneza1.Size = new System.Drawing.Size(192, 74);
            this.anamneza1.TabIndex = 0;
            // 
            // tokTabPage
            // 
            this.tokTabPage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tokTabPage.Controls.Add(this.dijagnoza1);
            this.tokTabPage.Controls.Add(this.info1);
            this.tokTabPage.Controls.Add(this.trimestarIII1);
            this.tokTabPage.Controls.Add(this.trimestarII1);
            this.tokTabPage.Controls.Add(this.trimestarI1);
            this.tokTabPage.Controls.Add(this.tokPorodjaja1);
            this.tokTabPage.Location = new System.Drawing.Point(4, 22);
            this.tokTabPage.Name = "tokTabPage";
            this.tokTabPage.Size = new System.Drawing.Size(192, 74);
            this.tokTabPage.TabIndex = 2;
            this.tokTabPage.Text = "Tok Trudnoce";
            this.tokTabPage.UseVisualStyleBackColor = true;
            // 
            // dijagnoza1
            // 
            this.dijagnoza1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dijagnoza1.CurrentPosition = -1;
            this.dijagnoza1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dijagnoza1.Filter = "";
            this.dijagnoza1.Location = new System.Drawing.Point(284, -80);
            this.dijagnoza1.Name = "dijagnoza1";
            this.dijagnoza1.Size = new System.Drawing.Size(0, 154);
            this.dijagnoza1.TabIndex = 2;
            // 
            // info1
            // 
            this.info1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.info1.Location = new System.Drawing.Point(908, 0);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(142, 144);
            this.info1.TabIndex = 5;
            // 
            // trimestarIII1
            // 
            this.trimestarIII1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.trimestarIII1.CurrentPosition = -1;
            this.trimestarIII1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trimestarIII1.Filter = "";
            this.trimestarIII1.Location = new System.Drawing.Point(284, 1032);
            this.trimestarIII1.Name = "trimestarIII1";
            this.trimestarIII1.Size = new System.Drawing.Size(0, 512);
            this.trimestarIII1.TabIndex = 4;
            // 
            // trimestarII1
            // 
            this.trimestarII1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.trimestarII1.CurrentPosition = -1;
            this.trimestarII1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trimestarII1.Filter = "";
            this.trimestarII1.Location = new System.Drawing.Point(284, 520);
            this.trimestarII1.Name = "trimestarII1";
            this.trimestarII1.Size = new System.Drawing.Size(0, 512);
            this.trimestarII1.TabIndex = 3;
            // 
            // trimestarI1
            // 
            this.trimestarI1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.trimestarI1.CurrentPosition = -1;
            this.trimestarI1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trimestarI1.Filter = "";
            this.trimestarI1.Location = new System.Drawing.Point(284, 0);
            this.trimestarI1.Name = "trimestarI1";
            this.trimestarI1.Size = new System.Drawing.Size(0, 520);
            this.trimestarI1.TabIndex = 1;
            // 
            // tokPorodjaja1
            // 
            this.tokPorodjaja1.BackColor = System.Drawing.SystemColors.Control;
            this.tokPorodjaja1.CurrentPosition = -1;
            this.tokPorodjaja1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tokPorodjaja1.Filter = "";
            this.tokPorodjaja1.Location = new System.Drawing.Point(0, 0);
            this.tokPorodjaja1.Name = "tokPorodjaja1";
            this.tokPorodjaja1.Size = new System.Drawing.Size(284, 74);
            this.tokPorodjaja1.TabIndex = 0;
            // 
            // tabPageKolpo
            // 
            this.tabPageKolpo.Controls.Add(this.kolpo1);
            this.tabPageKolpo.Location = new System.Drawing.Point(4, 22);
            this.tabPageKolpo.Name = "tabPageKolpo";
            this.tabPageKolpo.Size = new System.Drawing.Size(1053, 654);
            this.tabPageKolpo.TabIndex = 3;
            this.tabPageKolpo.Text = "Kolpo";
            this.tabPageKolpo.UseVisualStyleBackColor = true;
            // 
            // kolpo1
            // 
            this.kolpo1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.kolpo1.CurrentPosition = -1;
            this.kolpo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kolpo1.Filter = "";
            this.kolpo1.Location = new System.Drawing.Point(0, 0);
            this.kolpo1.Name = "kolpo1";
            this.kolpo1.Size = new System.Drawing.Size(1053, 654);
            this.kolpo1.TabIndex = 0;
            // 
            // tabPageUZ
            // 
            this.tabPageUZ.Controls.Add(this._ultrazvukControl);
            this.tabPageUZ.Location = new System.Drawing.Point(4, 22);
            this.tabPageUZ.Name = "tabPageUZ";
            this.tabPageUZ.Size = new System.Drawing.Size(1053, 654);
            this.tabPageUZ.TabIndex = 4;
            this.tabPageUZ.Text = "Ultrazvuk";
            this.tabPageUZ.UseVisualStyleBackColor = true;
            // 
            // _ultrazvukControl
            // 
            this._ultrazvukControl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._ultrazvukControl.CurrentPosition = -1;
            this._ultrazvukControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ultrazvukControl.Filter = null;
            this._ultrazvukControl.Location = new System.Drawing.Point(0, 0);
            this._ultrazvukControl.Name = "_ultrazvukControl";
            this._ultrazvukControl.Size = new System.Drawing.Size(1053, 654);
            this._ultrazvukControl.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "ARW03RT.ICO");
            this.imageList1.Images.SetKeyName(15, "ARW01LT.ICO");
            this.imageList1.Images.SetKeyName(16, "ARW01RT.ICO");
            this.imageList1.Images.SetKeyName(17, "ARW03LT.ICO");
            this.imageList1.Images.SetKeyName(18, "GRAPH12.ICO");
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.NewPregledBtn,
            this.NewPatientBtn,
            this.saveBtn,
            this.separ1Btn,
            this.FirstBtn,
            this.PrevBtn,
            this.NextBtn,
            this.LastBtn,
            this.allBtn,
            this.separ2Btn,
            this.separ3,
            this.delProtokolBtn,
            this.toolBarButton1,
            this.previewBtn,
            this.printBtn,
            this.separ4,
            this.filterBtn,
            this.kalendarBtn,
            this.separ5,
            this.aboutBtn});
            this.toolBar1.Divider = false;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(1061, 34);
            this.toolBar1.TabIndex = 3;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // NewPregledBtn
            // 
            this.NewPregledBtn.DropDownMenu = this.contextMenu1;
            this.NewPregledBtn.ImageIndex = 0;
            this.NewPregledBtn.Name = "NewPregledBtn";
            this.NewPregledBtn.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.NewPregledBtn.Text = "Novi Pregled";
            this.NewPregledBtn.ToolTipText = "Novi Protokol";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ImenuItem,
            this.IImenuItem,
            this.IIImenuItem});
            // 
            // ImenuItem
            // 
            this.ImenuItem.DefaultItem = true;
            this.ImenuItem.Index = 0;
            this.ImenuItem.Text = "Trimestar I";
            this.ImenuItem.Click += new System.EventHandler(this.ImenuItem_Click);
            // 
            // IImenuItem
            // 
            this.IImenuItem.Index = 1;
            this.IImenuItem.Text = "Trimestar II";
            this.IImenuItem.Click += new System.EventHandler(this.IImenuItem_Click);
            // 
            // IIImenuItem
            // 
            this.IIImenuItem.Index = 2;
            this.IIImenuItem.Text = "Trimestar III";
            this.IIImenuItem.Click += new System.EventHandler(this.IIImenuItem_Click);
            // 
            // NewPatientBtn
            // 
            this.NewPatientBtn.ImageIndex = 13;
            this.NewPatientBtn.Name = "NewPatientBtn";
            this.NewPatientBtn.Text = "Pacijenti";
            this.NewPatientBtn.ToolTipText = "Novi Pacijent";
            // 
            // saveBtn
            // 
            this.saveBtn.ImageIndex = 1;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Text = "Save";
            this.saveBtn.ToolTipText = "Snimi sve...";
            // 
            // separ1Btn
            // 
            this.separ1Btn.Name = "separ1Btn";
            this.separ1Btn.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // FirstBtn
            // 
            this.FirstBtn.ImageIndex = 15;
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Text = "Prvi";
            this.FirstBtn.ToolTipText = "Prvi Pregled";
            // 
            // PrevBtn
            // 
            this.PrevBtn.ImageIndex = 3;
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Text = "Prethodni";
            this.PrevBtn.ToolTipText = "Prethodni Pregled";
            // 
            // NextBtn
            // 
            this.NextBtn.ImageIndex = 4;
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Text = "Sledeci";
            this.NextBtn.ToolTipText = "Sledeci Pregled";
            // 
            // LastBtn
            // 
            this.LastBtn.ImageIndex = 16;
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Text = "Poslednji";
            this.LastBtn.ToolTipText = "Poslednji Pregled";
            // 
            // allBtn
            // 
            this.allBtn.ImageIndex = 8;
            this.allBtn.Name = "allBtn";
            this.allBtn.Pushed = true;
            this.allBtn.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.allBtn.ToolTipText = "Prikaži sve protokole";
            this.allBtn.Visible = false;
            // 
            // separ2Btn
            // 
            this.separ2Btn.Name = "separ2Btn";
            this.separ2Btn.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // separ3
            // 
            this.separ3.Name = "separ3";
            this.separ3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // delProtokolBtn
            // 
            this.delProtokolBtn.ImageIndex = 6;
            this.delProtokolBtn.Name = "delProtokolBtn";
            this.delProtokolBtn.Text = "Obrisi";
            this.delProtokolBtn.ToolTipText = "Obriši protokol";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // previewBtn
            // 
            this.previewBtn.ImageIndex = 18;
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Text = "Statistika";
            this.previewBtn.ToolTipText = "Prikazi Preview";
            // 
            // printBtn
            // 
            this.printBtn.ImageIndex = 2;
            this.printBtn.Name = "printBtn";
            this.printBtn.Text = "Stampa";
            this.printBtn.ToolTipText = "Štampaj izveštaj";
            // 
            // separ4
            // 
            this.separ4.Name = "separ4";
            this.separ4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // filterBtn
            // 
            this.filterBtn.ImageIndex = 8;
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Pushed = true;
            this.filterBtn.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.filterBtn.Text = "Filter";
            this.filterBtn.ToolTipText = "Po tekucem pacijentu";
            // 
            // kalendarBtn
            // 
            this.kalendarBtn.ImageIndex = 12;
            this.kalendarBtn.Name = "kalendarBtn";
            this.kalendarBtn.Text = "Kalendar";
            this.kalendarBtn.ToolTipText = "Kalendar zakazanih pregleda";
            // 
            // separ5
            // 
            this.separ5.Name = "separ5";
            this.separ5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // aboutBtn
            // 
            this.aboutBtn.ImageIndex = 11;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.ToolTipText = "Pohvali se";
            // 
            // menuItemTrim1
            // 
            this.menuItemTrim1.Index = -1;
            this.menuItemTrim1.Text = "";
            // 
            // menuItemTrim2
            // 
            this.menuItemTrim2.Index = -1;
            this.menuItemTrim2.Text = "";
            // 
            // menuItemTrim3
            // 
            this.menuItemTrim3.Index = -1;
            this.menuItemTrim3.Text = "";
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar1.Location = new System.Drawing.Point(0, 718);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanelID,
            this.statusBarPanelIme,
            this.statusBarPanelPrezime,
            this.lGS,
            this.statusBarPanelGS,
            this.lTP,
            this.statusBarPanelTermin,
            this.lUZTP,
            this.statusBarPanelUZTP,
            this.statusBarPanelPoli});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1061, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 24;
            // 
            // statusBarPanelID
            // 
            this.statusBarPanelID.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanelID.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelID.Name = "statusBarPanelID";
            this.statusBarPanelID.Text = "ID";
            this.statusBarPanelID.ToolTipText = "Broj pregleda";
            this.statusBarPanelID.Width = 29;
            // 
            // statusBarPanelIme
            // 
            this.statusBarPanelIme.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelIme.Name = "statusBarPanelIme";
            this.statusBarPanelIme.Text = "Ime";
            this.statusBarPanelIme.ToolTipText = "Ime pacijentkinje";
            this.statusBarPanelIme.Width = 39;
            // 
            // statusBarPanelPrezime
            // 
            this.statusBarPanelPrezime.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelPrezime.Name = "statusBarPanelPrezime";
            this.statusBarPanelPrezime.Text = "Prezime";
            this.statusBarPanelPrezime.ToolTipText = "Prezime pacijentkinje";
            this.statusBarPanelPrezime.Width = 67;
            // 
            // lGS
            // 
            this.lGS.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.lGS.Name = "lGS";
            this.lGS.Text = "GS:";
            this.lGS.Width = 39;
            // 
            // statusBarPanelGS
            // 
            this.statusBarPanelGS.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanelGS.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelGS.Name = "statusBarPanelGS";
            this.statusBarPanelGS.Text = "GS";
            this.statusBarPanelGS.ToolTipText = "Gestacijska starost";
            this.statusBarPanelGS.Width = 35;
            // 
            // lTP
            // 
            this.lTP.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.lTP.Name = "lTP";
            this.lTP.Text = "   Termin: ";
            this.lTP.Width = 75;
            // 
            // statusBarPanelTermin
            // 
            this.statusBarPanelTermin.Name = "statusBarPanelTermin";
            this.statusBarPanelTermin.Text = "ponedeljak,07 novembar, 2005";
            this.statusBarPanelTermin.ToolTipText = "Termin porodjaja";
            this.statusBarPanelTermin.Width = 230;
            // 
            // lUZTP
            // 
            this.lUZTP.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.lUZTP.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.lUZTP.Name = "lUZTP";
            this.lUZTP.Text = "UZTP: ";
            this.lUZTP.Width = 56;
            // 
            // statusBarPanelUZTP
            // 
            this.statusBarPanelUZTP.Name = "statusBarPanelUZTP";
            this.statusBarPanelUZTP.Text = "UZTP";
            this.statusBarPanelUZTP.ToolTipText = "UZTP";
            this.statusBarPanelUZTP.Width = 230;
            // 
            // statusBarPanelPoli
            // 
            this.statusBarPanelPoli.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanelPoli.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanelPoli.Name = "statusBarPanelPoli";
            this.statusBarPanelPoli.Text = "Pluripare";
            this.statusBarPanelPoli.Width = 72;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCmdLastPatID
            // 
            this.sqlCmdLastPatID.CommandText = "SELECT     PacijentID\r\nFROM         Protokol\r\nWHERE     (Grupa = 1) AND (UserID =" +
                " @userID) OR\r\n                      (Grupa = 1) AND (@IsAdmin = 1)\r\nORDER BY Pro" +
                "tokolID DESC";
            this.sqlCmdLastPatID.Connection = this.sqlConnection1;
            this.sqlCmdLastPatID.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userID", System.Data.SqlDbType.Int, 4, "UserID"),
            new System.Data.SqlClient.SqlParameter("@IsAdmin", System.Data.SqlDbType.Int)});
            // 
            // parovicDS1
            // 
            this.parovicDS1.DataSetName = "ParovicDS";
            this.parovicDS1.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.parovicDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1061, 740);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.mainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akuserska Ordinacija Parovic";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTab.ResumeLayout(false);
            this.generalijeTabPage.ResumeLayout(false);
            this.anamnezaTabPage.ResumeLayout(false);
            this.tokTabPage.ResumeLayout(false);
            this.tabPageKolpo.ResumeLayout(false);
            this.tabPageUZ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelTermin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUZTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelUZTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanelPoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}