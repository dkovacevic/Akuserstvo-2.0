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
	public class TrimestarIII : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.NumericUpDown numericUpDown12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown numericUpDown13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown numericUpDown14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown numericUpDown15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox checkBox16;
		private System.Windows.Forms.CheckBox checkBox18;
		private System.Windows.Forms.CheckBox checkBox20;
		private System.Windows.Forms.CheckBox checkBox21;
		private System.Windows.Forms.CheckBox checkBox22;
		private System.Windows.Forms.NumericUpDown numericUpDown24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.NumericUpDown numericUpDown25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.NumericUpDown numericUpDown18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.NumericUpDown numericUpDown19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.NumericUpDown numericUpDown20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.NumericUpDown numericUpDown21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.NumericUpDown numericUpDown22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.NumericUpDown numericUpDown23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.NumericUpDown numericUpDown26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.NumericUpDown numericUpDown27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.NumericUpDown numericUpDown32;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.CheckBox checkBox19;
		private System.Windows.Forms.NumericUpDown numericUpDown33;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.NumericUpDown numericUpDown34;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.NumericUpDown numericUpDown35;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.NumericUpDown numericUpDown37;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.NumericUpDown numericUpDown38;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.TextBox textBox17;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.TextBox textBox18;
		private System.Windows.Forms.TextBox textBox19;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.TextBox textBox20;
		private System.Windows.Forms.TextBox textBox21;
		private System.Windows.Forms.TextBox textBox22;
		private System.Windows.Forms.TextBox textBox23;
		private System.Windows.Forms.TextBox textBox24;
		private System.Windows.Forms.TextBox textBox25;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private ParovicDS parovicDS1;
		private System.Data.DataView dataView1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.CheckBox bUrinokultura;
		private System.Windows.Forms.CheckBox bCerviklanibris;
		private System.Windows.Forms.Panel pCerviklanibris;
		private System.Windows.Forms.RadioButton rCerviklanibrisF;
		private System.Windows.Forms.RadioButton rCerviklanibrisT;
		private System.Windows.Forms.Panel pUrinokultura;
		private System.Windows.Forms.RadioButton rUrinokulturaF;
		private System.Windows.Forms.RadioButton rUrinokulturaT;
		private System.Windows.Forms.Panel pHbSAg;
		private System.Windows.Forms.RadioButton rHbSAgF;
		private System.Windows.Forms.RadioButton rHbSAgT;
		private System.Windows.Forms.CheckBox bHbSAg;
		private System.Windows.Forms.Panel pHIV;
		private System.Windows.Forms.RadioButton rHIVF;
		private System.Windows.Forms.RadioButton rHIVT;
        private System.Windows.Forms.CheckBox bHIV;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown numTrimestar;
        private GroupBox groupBox5;
        private TextBox textBoxBrisovi;
        private GroupBox groupBox4;
        private TextBox textBoxAntitela;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox28;
        private TextBox textBox29;
        private Label label17;
        private TextBox textBox30;
        private TextBox textBox31;
        private Label label18;
        private TextBox textBox32;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label6;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label label7;
        private TextBox textBox14;
        private DateTimePicker dtSkrining;
        private Panel panel1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TrimestarIII()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrimestarIII));
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.numericUpDown24 = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.numericUpDown25 = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown22 = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDown23 = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.numericUpDown26 = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.numericUpDown27 = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.numericUpDown32 = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.numericUpDown33 = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.numericUpDown34 = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.numericUpDown35 = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.numericUpDown37 = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.numericUpDown38 = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.dataView1 = new System.Data.DataView();
            this.parovicDS1 = new Parovic.Akuserstvo.ParovicDS();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bUrinokultura = new System.Windows.Forms.CheckBox();
            this.rUrinokulturaT = new System.Windows.Forms.RadioButton();
            this.rCerviklanibrisT = new System.Windows.Forms.RadioButton();
            this.bCerviklanibris = new System.Windows.Forms.CheckBox();
            this.pCerviklanibris = new System.Windows.Forms.Panel();
            this.rCerviklanibrisF = new System.Windows.Forms.RadioButton();
            this.pUrinokultura = new System.Windows.Forms.Panel();
            this.rUrinokulturaF = new System.Windows.Forms.RadioButton();
            this.pHIV = new System.Windows.Forms.Panel();
            this.rHIVF = new System.Windows.Forms.RadioButton();
            this.rHIVT = new System.Windows.Forms.RadioButton();
            this.pHbSAg = new System.Windows.Forms.Panel();
            this.rHbSAgF = new System.Windows.Forms.RadioButton();
            this.rHbSAgT = new System.Windows.Forms.RadioButton();
            this.bHbSAg = new System.Windows.Forms.CheckBox();
            this.bHIV = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.dtSkrining = new System.Windows.Forms.DateTimePicker();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numTrimestar = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxBrisovi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxAntitela = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pCerviklanibris.SuspendLayout();
            this.pUrinokultura.SuspendLayout();
            this.pHIV.SuspendLayout();
            this.pHbSAg.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimestar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown14.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown15.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown12.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown13.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // checkBox16
            // 
            this.checkBox16.Location = new System.Drawing.Point(0, 0);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(104, 24);
            this.checkBox16.TabIndex = 0;
            // 
            // checkBox18
            // 
            this.checkBox18.Location = new System.Drawing.Point(0, 0);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(104, 24);
            this.checkBox18.TabIndex = 0;
            // 
            // checkBox20
            // 
            this.checkBox20.Location = new System.Drawing.Point(0, 0);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(104, 24);
            this.checkBox20.TabIndex = 0;
            // 
            // checkBox21
            // 
            this.checkBox21.Location = new System.Drawing.Point(0, 0);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(104, 24);
            this.checkBox21.TabIndex = 0;
            // 
            // checkBox22
            // 
            this.checkBox22.Location = new System.Drawing.Point(0, 0);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(104, 24);
            this.checkBox22.TabIndex = 0;
            // 
            // numericUpDown24
            // 
            this.numericUpDown24.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown24.Name = "numericUpDown24";
            this.numericUpDown24.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown24.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 23);
            this.label25.TabIndex = 0;
            // 
            // numericUpDown25
            // 
            this.numericUpDown25.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown25.Name = "numericUpDown25";
            this.numericUpDown25.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown25.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(0, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 23);
            this.label26.TabIndex = 0;
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown18.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 0;
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown19.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 0;
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown20.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 0;
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown21.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 0;
            // 
            // numericUpDown22
            // 
            this.numericUpDown22.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown22.Name = "numericUpDown22";
            this.numericUpDown22.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown22.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 23);
            this.label23.TabIndex = 0;
            // 
            // numericUpDown23
            // 
            this.numericUpDown23.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown23.Name = "numericUpDown23";
            this.numericUpDown23.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown23.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 23);
            this.label24.TabIndex = 0;
            // 
            // numericUpDown26
            // 
            this.numericUpDown26.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown26.Name = "numericUpDown26";
            this.numericUpDown26.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown26.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 23);
            this.label27.TabIndex = 0;
            // 
            // numericUpDown27
            // 
            this.numericUpDown27.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown27.Name = "numericUpDown27";
            this.numericUpDown27.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown27.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 23);
            this.label28.TabIndex = 0;
            // 
            // numericUpDown32
            // 
            this.numericUpDown32.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown32.Name = "numericUpDown32";
            this.numericUpDown32.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown32.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 23);
            this.label35.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 23);
            this.label36.TabIndex = 0;
            // 
            // checkBox19
            // 
            this.checkBox19.Location = new System.Drawing.Point(0, 0);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(104, 24);
            this.checkBox19.TabIndex = 0;
            // 
            // numericUpDown33
            // 
            this.numericUpDown33.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown33.Name = "numericUpDown33";
            this.numericUpDown33.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown33.TabIndex = 0;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(100, 23);
            this.label37.TabIndex = 0;
            // 
            // numericUpDown34
            // 
            this.numericUpDown34.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown34.Name = "numericUpDown34";
            this.numericUpDown34.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown34.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(0, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(100, 23);
            this.label38.TabIndex = 0;
            // 
            // numericUpDown35
            // 
            this.numericUpDown35.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown35.Name = "numericUpDown35";
            this.numericUpDown35.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown35.TabIndex = 0;
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(0, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(100, 23);
            this.label39.TabIndex = 0;
            // 
            // numericUpDown37
            // 
            this.numericUpDown37.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown37.Name = "numericUpDown37";
            this.numericUpDown37.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown37.TabIndex = 0;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(0, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(100, 23);
            this.label41.TabIndex = 0;
            // 
            // numericUpDown38
            // 
            this.numericUpDown38.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown38.Name = "numericUpDown38";
            this.numericUpDown38.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown38.TabIndex = 0;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(0, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(100, 23);
            this.label42.TabIndex = 0;
            // 
            // checkBox23
            // 
            this.checkBox23.Location = new System.Drawing.Point(0, 0);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(104, 24);
            this.checkBox23.TabIndex = 0;
            // 
            // checkBox24
            // 
            this.checkBox24.Location = new System.Drawing.Point(192, 128);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(48, 24);
            this.checkBox24.TabIndex = 39;
            this.checkBox24.Text = "noch";
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
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Koprokultura", true));
            this.textBox1.Location = new System.Drawing.Point(88, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 59;
            this.label9.Text = "Koprokultura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bUrinokultura);
            this.groupBox1.Controls.Add(this.rUrinokulturaT);
            this.groupBox1.Controls.Add(this.rCerviklanibrisT);
            this.groupBox1.Controls.Add(this.bCerviklanibris);
            this.groupBox1.Controls.Add(this.pCerviklanibris);
            this.groupBox1.Controls.Add(this.pUrinokultura);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skrining na ß hemoliticki streptokok grupe “B” ( 35-37 g.n. )";
            // 
            // bUrinokultura
            // 
            this.bUrinokultura.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HemolUrino", true));
            this.bUrinokultura.Location = new System.Drawing.Point(8, 58);
            this.bUrinokultura.Name = "bUrinokultura";
            this.bUrinokultura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bUrinokultura.Size = new System.Drawing.Size(96, 24);
            this.bUrinokultura.TabIndex = 1;
            this.bUrinokultura.Text = "Urinokultura";
            this.bUrinokultura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bUrinokultura.CheckedChanged += new System.EventHandler(this.bUrinokultura_CheckedChanged);
            // 
            // rUrinokulturaT
            // 
            this.rUrinokulturaT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HemolUrino Res", true));
            this.rUrinokulturaT.Location = new System.Drawing.Point(127, 58);
            this.rUrinokulturaT.Name = "rUrinokulturaT";
            this.rUrinokulturaT.Size = new System.Drawing.Size(32, 24);
            this.rUrinokulturaT.TabIndex = 0;
            this.rUrinokulturaT.Text = "+";
            this.rUrinokulturaT.CheckedChanged += new System.EventHandler(this.rUrinokulturaT_CheckedChanged);
            // 
            // rCerviklanibrisT
            // 
            this.rCerviklanibrisT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HemolCervikalni Res", true));
            this.rCerviklanibrisT.Location = new System.Drawing.Point(127, 34);
            this.rCerviklanibrisT.Name = "rCerviklanibrisT";
            this.rCerviklanibrisT.Size = new System.Drawing.Size(32, 24);
            this.rCerviklanibrisT.TabIndex = 0;
            this.rCerviklanibrisT.Text = "+";
            this.rCerviklanibrisT.CheckedChanged += new System.EventHandler(this.rCerviklanibrisT_CheckedChanged);
            // 
            // bCerviklanibris
            // 
            this.bCerviklanibris.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HemolCervikalni", true));
            this.bCerviklanibris.Location = new System.Drawing.Point(8, 34);
            this.bCerviklanibris.Name = "bCerviklanibris";
            this.bCerviklanibris.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bCerviklanibris.Size = new System.Drawing.Size(96, 24);
            this.bCerviklanibris.TabIndex = 0;
            this.bCerviklanibris.Text = "Cerviklani bris";
            this.bCerviklanibris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCerviklanibris.CheckedChanged += new System.EventHandler(this.bCerviklanibris_CheckedChanged);
            // 
            // pCerviklanibris
            // 
            this.pCerviklanibris.Controls.Add(this.rCerviklanibrisF);
            this.pCerviklanibris.Enabled = false;
            this.pCerviklanibris.Location = new System.Drawing.Point(159, 34);
            this.pCerviklanibris.Name = "pCerviklanibris";
            this.pCerviklanibris.Size = new System.Drawing.Size(48, 24);
            this.pCerviklanibris.TabIndex = 62;
            // 
            // rCerviklanibrisF
            // 
            this.rCerviklanibrisF.Checked = true;
            this.rCerviklanibrisF.Location = new System.Drawing.Point(10, 0);
            this.rCerviklanibrisF.Name = "rCerviklanibrisF";
            this.rCerviklanibrisF.Size = new System.Drawing.Size(32, 24);
            this.rCerviklanibrisF.TabIndex = 0;
            this.rCerviklanibrisF.TabStop = true;
            this.rCerviklanibrisF.Text = "-";
            // 
            // pUrinokultura
            // 
            this.pUrinokultura.Controls.Add(this.rUrinokulturaF);
            this.pUrinokultura.Enabled = false;
            this.pUrinokultura.Location = new System.Drawing.Point(159, 58);
            this.pUrinokultura.Name = "pUrinokultura";
            this.pUrinokultura.Size = new System.Drawing.Size(48, 24);
            this.pUrinokultura.TabIndex = 63;
            // 
            // rUrinokulturaF
            // 
            this.rUrinokulturaF.Checked = true;
            this.rUrinokulturaF.Location = new System.Drawing.Point(10, 0);
            this.rUrinokulturaF.Name = "rUrinokulturaF";
            this.rUrinokulturaF.Size = new System.Drawing.Size(32, 24);
            this.rUrinokulturaF.TabIndex = 0;
            this.rUrinokulturaF.TabStop = true;
            this.rUrinokulturaF.Text = "-";
            // 
            // pHIV
            // 
            this.pHIV.Controls.Add(this.rHIVF);
            this.pHIV.Controls.Add(this.rHIVT);
            this.pHIV.Enabled = false;
            this.pHIV.Location = new System.Drawing.Point(120, 40);
            this.pHIV.Name = "pHIV";
            this.pHIV.Size = new System.Drawing.Size(72, 24);
            this.pHIV.TabIndex = 65;
            // 
            // rHIVF
            // 
            this.rHIVF.Checked = true;
            this.rHIVF.Location = new System.Drawing.Point(48, 0);
            this.rHIVF.Name = "rHIVF";
            this.rHIVF.Size = new System.Drawing.Size(32, 24);
            this.rHIVF.TabIndex = 1;
            this.rHIVF.TabStop = true;
            this.rHIVF.Text = "-";
            // 
            // rHIVT
            // 
            this.rHIVT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HIV Res", true));
            this.rHIVT.Location = new System.Drawing.Point(0, 0);
            this.rHIVT.Name = "rHIVT";
            this.rHIVT.Size = new System.Drawing.Size(32, 24);
            this.rHIVT.TabIndex = 0;
            this.rHIVT.Text = "+";
            this.rHIVT.CheckedChanged += new System.EventHandler(this.rHIVT_CheckedChanged);
            // 
            // pHbSAg
            // 
            this.pHbSAg.Controls.Add(this.rHbSAgF);
            this.pHbSAg.Controls.Add(this.rHbSAgT);
            this.pHbSAg.Enabled = false;
            this.pHbSAg.Location = new System.Drawing.Point(120, 16);
            this.pHbSAg.Name = "pHbSAg";
            this.pHbSAg.Size = new System.Drawing.Size(72, 24);
            this.pHbSAg.TabIndex = 64;
            // 
            // rHbSAgF
            // 
            this.rHbSAgF.Checked = true;
            this.rHbSAgF.Location = new System.Drawing.Point(48, 0);
            this.rHbSAgF.Name = "rHbSAgF";
            this.rHbSAgF.Size = new System.Drawing.Size(32, 24);
            this.rHbSAgF.TabIndex = 1;
            this.rHbSAgF.TabStop = true;
            this.rHbSAgF.Text = "-";
            // 
            // rHbSAgT
            // 
            this.rHbSAgT.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HbS Ag Res", true));
            this.rHbSAgT.Location = new System.Drawing.Point(0, 0);
            this.rHbSAgT.Name = "rHbSAgT";
            this.rHbSAgT.Size = new System.Drawing.Size(32, 24);
            this.rHbSAgT.TabIndex = 0;
            this.rHbSAgT.Text = "+";
            this.rHbSAgT.CheckedChanged += new System.EventHandler(this.rHbSAgT_CheckedChanged);
            // 
            // bHbSAg
            // 
            this.bHbSAg.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HbS Ag", true));
            this.bHbSAg.Location = new System.Drawing.Point(8, 16);
            this.bHbSAg.Name = "bHbSAg";
            this.bHbSAg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bHbSAg.Size = new System.Drawing.Size(96, 24);
            this.bHbSAg.TabIndex = 0;
            this.bHbSAg.Text = "HbS Ag";
            this.bHbSAg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bHbSAg.CheckedChanged += new System.EventHandler(this.bHbSAg_CheckedChanged);
            // 
            // bHIV
            // 
            this.bHIV.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataView1, "HIV", true));
            this.bHIV.Location = new System.Drawing.Point(8, 40);
            this.bHIV.Name = "bHIV";
            this.bHIV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bHIV.Size = new System.Drawing.Size(96, 24);
            this.bHIV.TabIndex = 1;
            this.bHIV.Text = "HIV";
            this.bHIV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bHIV.CheckedChanged += new System.EventHandler(this.bHIV_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.label46);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(445, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OGTT ( 100 gr glukoze )";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(6, 119);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(51, 23);
            this.label33.TabIndex = 62;
            this.label33.Text = "180 min:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(105, 116);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(40, 16);
            this.label40.TabIndex = 64;
            this.label40.Text = "mmol/l";
            this.label40.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(6, 87);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(51, 23);
            this.label43.TabIndex = 59;
            this.label43.Text = "120 min:";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(105, 84);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(40, 16);
            this.label44.TabIndex = 61;
            this.label44.Text = "mmol/l";
            this.label44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(6, 55);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(51, 23);
            this.label45.TabIndex = 56;
            this.label45.Text = "60 min:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(105, 52);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(40, 16);
            this.label46.TabIndex = 58;
            this.label46.Text = "mmol/l";
            this.label46.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(6, 23);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(51, 23);
            this.label47.TabIndex = 50;
            this.label47.Text = "0 min:";
            this.label47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(105, 20);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(40, 16);
            this.label48.TabIndex = 55;
            this.label48.Text = "mmol/l";
            this.label48.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "OGTT120", true));
            this.textBox5.Location = new System.Drawing.Point(63, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(42, 20);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "textBox5";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "OGTT60", true));
            this.textBox4.Location = new System.Drawing.Point(63, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "textBox4";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "OGTT180", true));
            this.textBox3.Location = new System.Drawing.Point(63, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "textBox3";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "OGTT0", true));
            this.textBox2.Location = new System.Drawing.Point(63, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "textBox2";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(328, 48);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(64, 20);
            this.textBox17.TabIndex = 117;
            this.textBox17.Text = "mmol/l";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label49.Location = new System.Drawing.Point(328, 24);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(64, 23);
            this.label49.TabIndex = 116;
            this.label49.Text = "Vreme";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil7", true));
            this.textBox18.Location = new System.Drawing.Point(288, 48);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(40, 20);
            this.textBox18.TabIndex = 7;
            this.textBox18.Text = "0";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil6", true));
            this.textBox19.Location = new System.Drawing.Point(248, 48);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(40, 20);
            this.textBox19.TabIndex = 6;
            this.textBox19.Text = "0";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label50
            // 
            this.label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label50.Location = new System.Drawing.Point(288, 24);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(40, 23);
            this.label50.TabIndex = 113;
            this.label50.Text = "24h";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil5", true));
            this.textBox20.Location = new System.Drawing.Point(208, 48);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(40, 20);
            this.textBox20.TabIndex = 5;
            this.textBox20.Text = "0";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil4", true));
            this.textBox21.Location = new System.Drawing.Point(168, 48);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(40, 20);
            this.textBox21.TabIndex = 4;
            this.textBox21.Text = "0";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil3", true));
            this.textBox22.Location = new System.Drawing.Point(128, 48);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(40, 20);
            this.textBox22.TabIndex = 3;
            this.textBox22.Text = "0";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil2", true));
            this.textBox23.Location = new System.Drawing.Point(88, 48);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(40, 20);
            this.textBox23.TabIndex = 2;
            this.textBox23.Text = "0";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil1", true));
            this.textBox24.Location = new System.Drawing.Point(48, 48);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(40, 20);
            this.textBox24.TabIndex = 1;
            this.textBox24.Text = "0";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil0", true));
            this.textBox25.Location = new System.Drawing.Point(8, 48);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(40, 20);
            this.textBox25.TabIndex = 0;
            this.textBox25.Text = "0";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label52
            // 
            this.label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label52.Location = new System.Drawing.Point(208, 24);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(80, 23);
            this.label52.TabIndex = 105;
            this.label52.Text = "Vecera";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label54.Location = new System.Drawing.Point(128, 24);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(80, 23);
            this.label54.TabIndex = 103;
            this.label54.Text = "Rucak";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label56.Location = new System.Drawing.Point(48, 24);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(80, 23);
            this.label56.TabIndex = 101;
            this.label56.Text = "Dorucak";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label57.Location = new System.Drawing.Point(8, 24);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(40, 23);
            this.label57.TabIndex = 100;
            this.label57.Text = "4h";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Controls.Add(this.numTrimestar);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.textBox15);
            this.groupBox6.Controls.Add(this.textBox16);
            this.groupBox6.Controls.Add(this.textBox26);
            this.groupBox6.Controls.Add(this.textBox27);
            this.groupBox6.Controls.Add(this.textBox28);
            this.groupBox6.Controls.Add(this.textBox29);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.textBox30);
            this.groupBox6.Controls.Add(this.textBox31);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.textBox32);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.textBox9);
            this.groupBox6.Controls.Add(this.textBox10);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.textBox12);
            this.groupBox6.Controls.Add(this.textBox13);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox14);
            this.groupBox6.Controls.Add(this.dtSkrining);
            this.groupBox6.Controls.Add(this.label57);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Controls.Add(this.label54);
            this.groupBox6.Controls.Add(this.label52);
            this.groupBox6.Controls.Add(this.textBox25);
            this.groupBox6.Controls.Add(this.textBox24);
            this.groupBox6.Controls.Add(this.textBox23);
            this.groupBox6.Controls.Add(this.textBox22);
            this.groupBox6.Controls.Add(this.textBox21);
            this.groupBox6.Controls.Add(this.textBox20);
            this.groupBox6.Controls.Add(this.label50);
            this.groupBox6.Controls.Add(this.textBox19);
            this.groupBox6.Controls.Add(this.textBox18);
            this.groupBox6.Controls.Add(this.label49);
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Location = new System.Drawing.Point(8, 202);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(633, 203);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dnevno-nocni profil";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil3Datum", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(411, 170);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(8, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 143;
            this.label8.Text = "4h";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(48, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 144;
            this.label10.Text = "Dorucak";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(128, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 145;
            this.label11.Text = "Rucak";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(208, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 146;
            this.label12.Text = "Vecera";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil02", true));
            this.textBox15.Location = new System.Drawing.Point(8, 173);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(40, 20);
            this.textBox15.TabIndex = 135;
            this.textBox15.Text = "0";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil12", true));
            this.textBox16.Location = new System.Drawing.Point(48, 173);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(40, 20);
            this.textBox16.TabIndex = 136;
            this.textBox16.Text = "0";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil22", true));
            this.textBox26.Location = new System.Drawing.Point(88, 173);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(40, 20);
            this.textBox26.TabIndex = 137;
            this.textBox26.Text = "0";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil32", true));
            this.textBox27.Location = new System.Drawing.Point(128, 173);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(40, 20);
            this.textBox27.TabIndex = 138;
            this.textBox27.Text = "0";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil42", true));
            this.textBox28.Location = new System.Drawing.Point(168, 173);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(40, 20);
            this.textBox28.TabIndex = 139;
            this.textBox28.Text = "0";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox29
            // 
            this.textBox29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil52", true));
            this.textBox29.Location = new System.Drawing.Point(208, 173);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(40, 20);
            this.textBox29.TabIndex = 140;
            this.textBox29.Text = "0";
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(288, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 23);
            this.label17.TabIndex = 147;
            this.label17.Text = "24h";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox30
            // 
            this.textBox30.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil62", true));
            this.textBox30.Location = new System.Drawing.Point(248, 173);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(40, 20);
            this.textBox30.TabIndex = 141;
            this.textBox30.Text = "0";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox31
            // 
            this.textBox31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil72", true));
            this.textBox31.Location = new System.Drawing.Point(288, 173);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(40, 20);
            this.textBox31.TabIndex = 142;
            this.textBox31.Text = "0";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(328, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 23);
            this.label18.TabIndex = 148;
            this.label18.Text = "Vreme";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(328, 173);
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(64, 20);
            this.textBox32.TabIndex = 149;
            this.textBox32.Text = "mmol/l";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil2Datum", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(411, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 127;
            this.label1.Text = "4h";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 128;
            this.label2.Text = "Dorucak";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(128, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 129;
            this.label4.Text = "Rucak";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(208, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 130;
            this.label5.Text = "Vecera";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil01", true));
            this.textBox6.Location = new System.Drawing.Point(8, 110);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 119;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil11", true));
            this.textBox7.Location = new System.Drawing.Point(48, 110);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(40, 20);
            this.textBox7.TabIndex = 120;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil21", true));
            this.textBox8.Location = new System.Drawing.Point(88, 110);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(40, 20);
            this.textBox8.TabIndex = 121;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil31", true));
            this.textBox9.Location = new System.Drawing.Point(128, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(40, 20);
            this.textBox9.TabIndex = 122;
            this.textBox9.Text = "0";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil41", true));
            this.textBox10.Location = new System.Drawing.Point(168, 110);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(40, 20);
            this.textBox10.TabIndex = 123;
            this.textBox10.Text = "0";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil51", true));
            this.textBox11.Location = new System.Drawing.Point(208, 110);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(40, 20);
            this.textBox11.TabIndex = 124;
            this.textBox11.Text = "0";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(288, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 131;
            this.label6.Text = "24h";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil61", true));
            this.textBox12.Location = new System.Drawing.Point(248, 110);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(40, 20);
            this.textBox12.TabIndex = 125;
            this.textBox12.Text = "0";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil71", true));
            this.textBox13.Location = new System.Drawing.Point(288, 110);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(40, 20);
            this.textBox13.TabIndex = 126;
            this.textBox13.Text = "0";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(328, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 132;
            this.label7.Text = "Vreme";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(328, 110);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(64, 20);
            this.textBox14.TabIndex = 133;
            this.textBox14.Text = "mmol/l";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtSkrining
            // 
            this.dtSkrining.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "Profil1Datum", true));
            this.dtSkrining.Location = new System.Drawing.Point(411, 48);
            this.dtSkrining.Name = "dtSkrining";
            this.dtSkrining.Size = new System.Drawing.Size(200, 20);
            this.dtSkrining.TabIndex = 118;
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
                        new System.Data.Common.DataColumnMapping("trimestar", "trimestar")})});
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
            new System.Data.SqlClient.SqlParameter("@OGTT0", System.Data.SqlDbType.Float, 8, "OGTT0"),
            new System.Data.SqlClient.SqlParameter("@OGTT60", System.Data.SqlDbType.Float, 8, "OGTT60"),
            new System.Data.SqlClient.SqlParameter("@OGTT120", System.Data.SqlDbType.Float, 8, "OGTT120"),
            new System.Data.SqlClient.SqlParameter("@OGTT180", System.Data.SqlDbType.Float, 8, "OGTT180"),
            new System.Data.SqlClient.SqlParameter("@Param93", System.Data.SqlDbType.Bit, 1, "HemolCervikalni Res"),
            new System.Data.SqlClient.SqlParameter("@Param77", System.Data.SqlDbType.Bit, 1, "HemolCervikalni"),
            new System.Data.SqlClient.SqlParameter("@Param78", System.Data.SqlDbType.Bit, 1, "HemolUrino Res"),
            new System.Data.SqlClient.SqlParameter("@Param79", System.Data.SqlDbType.Bit, 1, "HemolUrino"),
            new System.Data.SqlClient.SqlParameter("@Param80", System.Data.SqlDbType.Bit, 1, "HbS Ag Res"),
            new System.Data.SqlClient.SqlParameter("@Param81", System.Data.SqlDbType.Bit, 1, "HbS Ag"),
            new System.Data.SqlClient.SqlParameter("@Param82", System.Data.SqlDbType.Bit, 1, "HIV Res"),
            new System.Data.SqlClient.SqlParameter("@Param83", System.Data.SqlDbType.Bit, 1, "HIV"),
            new System.Data.SqlClient.SqlParameter("@Param84", System.Data.SqlDbType.Float, 8, "Profil7"),
            new System.Data.SqlClient.SqlParameter("@Param85", System.Data.SqlDbType.Float, 8, "Profil6"),
            new System.Data.SqlClient.SqlParameter("@Param86", System.Data.SqlDbType.Float, 8, "Profil5"),
            new System.Data.SqlClient.SqlParameter("@Param88", System.Data.SqlDbType.Float, 8, "Profil4"),
            new System.Data.SqlClient.SqlParameter("@Param89", System.Data.SqlDbType.Float, 8, "Profil3"),
            new System.Data.SqlClient.SqlParameter("@Param90", System.Data.SqlDbType.Float, 8, "Profil2"),
            new System.Data.SqlClient.SqlParameter("@Param91", System.Data.SqlDbType.Float, 8, "Profil1"),
            new System.Data.SqlClient.SqlParameter("@Param92", System.Data.SqlDbType.Float, 8, "Profil0"),
            new System.Data.SqlClient.SqlParameter("@p1", System.Data.SqlDbType.NVarChar, 2147483647, "BrisText"),
            new System.Data.SqlClient.SqlParameter("@p2", System.Data.SqlDbType.VarChar, 2147483647, "AntitelaText"),
            new System.Data.SqlClient.SqlParameter("@p3", System.Data.SqlDbType.NVarChar, 150, "Koprokultura"),
            new System.Data.SqlClient.SqlParameter("@p4", System.Data.SqlDbType.SmallDateTime, 4, "Profil3Datum"),
            new System.Data.SqlClient.SqlParameter("@p5", System.Data.SqlDbType.SmallDateTime, 4, "Profil2Datum"),
            new System.Data.SqlClient.SqlParameter("@p6", System.Data.SqlDbType.SmallDateTime, 4, "Profil1Datum"),
            new System.Data.SqlClient.SqlParameter("@p7", System.Data.SqlDbType.Float, 8, "Profil02"),
            new System.Data.SqlClient.SqlParameter("@p8", System.Data.SqlDbType.Float, 8, "Profil12"),
            new System.Data.SqlClient.SqlParameter("@p9", System.Data.SqlDbType.Float, 8, "Profil22"),
            new System.Data.SqlClient.SqlParameter("@p10", System.Data.SqlDbType.Float, 8, "Profil32"),
            new System.Data.SqlClient.SqlParameter("@p11", System.Data.SqlDbType.Float, 8, "Profil42"),
            new System.Data.SqlClient.SqlParameter("@p12", System.Data.SqlDbType.Float, 8, "Profil52"),
            new System.Data.SqlClient.SqlParameter("@p13", System.Data.SqlDbType.Float, 8, "Profil62"),
            new System.Data.SqlClient.SqlParameter("@p14", System.Data.SqlDbType.Float, 8, "Profil72"),
            new System.Data.SqlClient.SqlParameter("@p15", System.Data.SqlDbType.Float, 8, "Profil01"),
            new System.Data.SqlClient.SqlParameter("@p16", System.Data.SqlDbType.Float, 8, "Profil11"),
            new System.Data.SqlClient.SqlParameter("@p17", System.Data.SqlDbType.Float, 8, "Profil21"),
            new System.Data.SqlClient.SqlParameter("@p18", System.Data.SqlDbType.Float, 8, "Profil31"),
            new System.Data.SqlClient.SqlParameter("@p19", System.Data.SqlDbType.Float, 8, "Profil41"),
            new System.Data.SqlClient.SqlParameter("@p20", System.Data.SqlDbType.Float, 8, "Profil51"),
            new System.Data.SqlClient.SqlParameter("@p21", System.Data.SqlDbType.Float, 8, "Profil61"),
            new System.Data.SqlClient.SqlParameter("@p22", System.Data.SqlDbType.Float, 8, "Profil71"),
            new System.Data.SqlClient.SqlParameter("@Original_PregledID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PregledID", System.Data.DataRowVersion.Original, null)});
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.pHbSAg);
            this.groupBox7.Controls.Add(this.bHIV);
            this.groupBox7.Controls.Add(this.pHIV);
            this.groupBox7.Controls.Add(this.bHbSAg);
            this.groupBox7.Location = new System.Drawing.Point(236, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(203, 112);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            // 
            // numTrimestar
            // 
            this.numTrimestar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataView1, "Trimestar", true));
            this.numTrimestar.Location = new System.Drawing.Point(486, 19);
            this.numTrimestar.Name = "numTrimestar";
            this.numTrimestar.ReadOnly = true;
            this.numTrimestar.Size = new System.Drawing.Size(56, 20);
            this.numTrimestar.TabIndex = 24;
            this.numTrimestar.ValueChanged += new System.EventHandler(this.numTrimestar_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxBrisovi);
            this.groupBox5.Location = new System.Drawing.Point(236, 121);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 75);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bris";
            // 
            // textBoxBrisovi
            // 
            this.textBoxBrisovi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "BrisText", true));
            this.textBoxBrisovi.Location = new System.Drawing.Point(10, 20);
            this.textBoxBrisovi.Multiline = true;
            this.textBoxBrisovi.Name = "textBoxBrisovi";
            this.textBoxBrisovi.Size = new System.Drawing.Size(186, 42);
            this.textBoxBrisovi.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxAntitela);
            this.groupBox4.Location = new System.Drawing.Point(9, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 75);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Antitela";
            // 
            // textBoxAntitela
            // 
            this.textBoxAntitela.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataView1, "AntitelaText", true));
            this.textBoxAntitela.Location = new System.Drawing.Point(7, 20);
            this.textBoxAntitela.Multiline = true;
            this.textBoxAntitela.Name = "textBoxAntitela";
            this.textBoxAntitela.Size = new System.Drawing.Size(200, 39);
            this.textBoxAntitela.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(486, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 27);
            this.panel1.TabIndex = 28;
            // 
            // TrimestarIII
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TrimestarIII";
            this.Size = new System.Drawing.Size(651, 419);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pCerviklanibris.ResumeLayout(false);
            this.pUrinokultura.ResumeLayout(false);
            this.pHIV.ResumeLayout(false);
            this.pHbSAg.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrimestar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		
		private void bCerviklanibris_CheckedChanged(object sender, System.EventArgs e)
		{
			if((sender as CheckBox).Checked)
			{
				pCerviklanibris.Enabled = true;
			}
			else
			{
				pCerviklanibris.Enabled = false;
				rCerviklanibrisF.Checked = true;
			}
		}

		private void rCerviklanibrisT_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!(sender as RadioButton).Checked)
				rCerviklanibrisF.Checked = true;
		}

		private void bUrinokultura_CheckedChanged(object sender, System.EventArgs e)
		{
			if((sender as CheckBox).Checked)
			{
				pUrinokultura.Enabled = true;
			}
			else
			{
				pUrinokultura.Enabled = false;
				rUrinokulturaF.Checked = true;
			}
		}

		private void rUrinokulturaT_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!(sender as RadioButton).Checked)
				rUrinokulturaF.Checked = true;
		}

		private void bHbSAg_CheckedChanged(object sender, System.EventArgs e)
		{
			if((sender as CheckBox).Checked)
			{
				pHbSAg.Enabled = true;
			}
			else
			{
				pHbSAg.Enabled = false;
				rHbSAgF.Checked = true;
			}
		}

		private void rHbSAgT_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!(sender as RadioButton).Checked)
				rHbSAgF.Checked = true;
		}

		private void bHIV_CheckedChanged(object sender, System.EventArgs e)
		{
			if((sender as CheckBox).Checked)
			{
				pHIV.Enabled = true;
			}
			else
			{
				pHIV.Enabled = false;
				rHIVF.Checked = true;
			}
		}

		private void rHIVT_CheckedChanged(object sender, System.EventArgs e)
		{
			if(!(sender as RadioButton).Checked)
				rHIVF.Checked = true;
		}		

		private void numTrimestar_ValueChanged(object sender, System.EventArgs e)
		{
			if((sender as NumericUpDown).Value == 3M)
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
