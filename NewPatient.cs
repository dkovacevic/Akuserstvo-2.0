using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
    /// <summary>
    /// Summary description for NewPAcijent.
    /// </summary>
    public class NewPatientDlg : System.Windows.Forms.Form
    {
        #region "Attributes"
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private ParovicDS dataSet11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbPatientID;
        private System.Data.SqlClient.SqlCommand sqlCommand1;        
        #endregion
        private Button btnDel;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox4;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public NewPatientDlg()
        {
            //
            // Required for Windows Form Designer support
            //
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Data.SqlClient.SqlCommand sqlCommand2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatientDlg));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.dataSet11 = new Parovic.Akuserstvo.ParovicDS();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.cbPatientID = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.btnDel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandText = "DELETE FROM Pacijent\r\nWHERE     (PacijentID = @PatID)";
            sqlCommand2.Connection = this.sqlConnection1;
            sqlCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PatID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PacijentID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = sqlCommand2;
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
                        new System.Data.Common.DataColumnMapping("Rodjen", "Rodjen"),
                        new System.Data.Common.DataColumnMapping("Opstina", "Opstina")})});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     PacijentID, Ime, [Ime Srednje], Prezime, JMBG, Mesto, Telefon, Adresa," +
                " Zanimanje, Rodjen, Opstina\r\nFROM         Pacijent\r\nORDER BY Prezime";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(40, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Srednje ime:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(40, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "PacijentID:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(40, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Telefon:";
            // 
            // label97
            // 
            this.label97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.Color.DarkGreen;
            this.label97.Location = new System.Drawing.Point(40, 232);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(120, 23);
            this.label97.TabIndex = 28;
            this.label97.Text = "Mesto rodjenja:";
            // 
            // label96
            // 
            this.label96.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.Color.DarkGreen;
            this.label96.Location = new System.Drawing.Point(40, 192);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(120, 23);
            this.label96.TabIndex = 27;
            this.label96.Text = "Datum rodenja:";
            // 
            // label95
            // 
            this.label95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ForeColor = System.Drawing.Color.DarkGreen;
            this.label95.Location = new System.Drawing.Point(40, 152);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(96, 23);
            this.label95.TabIndex = 26;
            this.label95.Text = "JMBG:";
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.DarkGreen;
            this.label56.Location = new System.Drawing.Point(40, 32);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(112, 23);
            this.label56.TabIndex = 25;
            this.label56.Text = "Ime:";
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.DarkGreen;
            this.label52.Location = new System.Drawing.Point(40, 112);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(96, 23);
            this.label52.TabIndex = 24;
            this.label52.Text = "Prezime:";
            // 
            // label100
            // 
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.DarkGreen;
            this.label100.Location = new System.Drawing.Point(40, 272);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(136, 23);
            this.label100.TabIndex = 30;
            this.label100.Text = "Adresa, Mesto:";
            // 
            // label103
            // 
            this.label103.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.DarkGreen;
            this.label103.Location = new System.Drawing.Point(40, 312);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(112, 23);
            this.label103.TabIndex = 31;
            this.label103.Text = "Zanimanje:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataSet11;
            this.comboBox1.DisplayMember = "Pacijent.Ime";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox1.Location = new System.Drawing.Point(168, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.dataSet11;
            this.comboBox2.DisplayMember = "Pacijent.Ime Srednje";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox2.Location = new System.Drawing.Point(168, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(256, 28);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.DataSource = this.dataSet11;
            this.comboBox3.DisplayMember = "Pacijent.Prezime";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox3.Location = new System.Drawing.Point(168, 112);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(256, 28);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.dataSet11;
            this.comboBox6.DisplayMember = "Pacijent.Mesto";
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox6.Location = new System.Drawing.Point(168, 232);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(192, 28);
            this.comboBox6.TabIndex = 5;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.dataSet11;
            this.comboBox7.DisplayMember = "Pacijent.Adresa";
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox7.Location = new System.Drawing.Point(168, 272);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(312, 28);
            this.comboBox7.TabIndex = 6;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.dataSet11;
            this.comboBox8.DisplayMember = "Pacijent.Zanimanje";
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox8.Location = new System.Drawing.Point(168, 312);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(312, 28);
            this.comboBox8.TabIndex = 7;
            // 
            // comboBox10
            // 
            this.comboBox10.DataSource = this.dataSet11;
            this.comboBox10.DisplayMember = "Pacijent.Telefon";
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox10.Location = new System.Drawing.Point(168, 352);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(256, 28);
            this.comboBox10.TabIndex = 8;
            // 
            // cbPatientID
            // 
            this.cbPatientID.DataSource = this.dataSet11;
            this.cbPatientID.DisplayMember = "Pacijent.PacijentID";
            this.cbPatientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPatientID.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbPatientID.Location = new System.Drawing.Point(168, 392);
            this.cbPatientID.Name = "cbPatientID";
            this.cbPatientID.Size = new System.Drawing.Size(104, 28);
            this.cbPatientID.TabIndex = 44;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Beige;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnOK.Location = new System.Drawing.Point(371, 444);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Beige;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCancel.Location = new System.Drawing.Point(461, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Beige;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnNew.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNew.Image = global::Parovic.Akuserstvo.Properties.Resources.POINT07;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(37, 444);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Novi";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT COUNT(*) AS Expr1 FROM Protokol GROUP BY PacijentID, Grupa, UserID HAVING " +
                "(PacijentID = @PatientID) AND (Grupa = 1) AND (UserID = @userID OR Grupa = 1 AND" +
                " @IsAdmin = 1)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PatientID", System.Data.SqlDbType.Int, 4, "PacijentID"),
            new System.Data.SqlClient.SqlParameter("@userID", System.Data.SqlDbType.Int, 4, "UserID"),
            new System.Data.SqlClient.SqlParameter("@IsAdmin", System.Data.SqlDbType.Int)});
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Beige;
            this.btnDel.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDel.Image = global::Parovic.Akuserstvo.Properties.Resources.DELETE;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(132, 444);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 45;
            this.btnDel.Text = "Obrisi";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MMM yyyy.";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "Pacijent.Rodjen", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 26);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox4.DataSource = this.dataSet11;
            this.comboBox4.DisplayMember = "Pacijent.JMBG";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.DarkGreen;
            this.comboBox4.Location = new System.Drawing.Point(168, 152);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(160, 28);
            this.comboBox4.TabIndex = 47;
            // 
            // NewPatientDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(554, 487);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbPatientID);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label97);
            this.Controls.Add(this.label96);
            this.Controls.Add(this.label95);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.label103);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPatientDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pretraga pacijenata";
            this.Load += new System.EventHandler(this.NewPAcijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void NewPAcijent_Load(object sender, System.EventArgs e)
        {
            try
            {
                sqlCommand1.Connection.Open();
                sqlDataAdapter1.Fill(dataSet11);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {

            sqlCommand1.Parameters["@PatientID"].Value = PatientID;

            object obj = sqlCommand1.ExecuteScalar();
            if (obj == null)
            {
                TrimestarSelect trimSel = new TrimestarSelect();
                DialogResult diagRes = trimSel.ShowDialog(this);
                if (diagRes != DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.Retry;
                    Trimestar = trimSel.Trimestar;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            TrimestarSelect trimSel = new TrimestarSelect();
            DialogResult diagRes = trimSel.ShowDialog(this);
            if (diagRes != DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.Yes;
                Trimestar = trimSel.Trimestar;
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }

        public int PatientID
        {
            get
            {
                int ret;
                Int32.TryParse(cbPatientID.Text, out ret);
                return ret;
            }
        }

        public int Trimestar { get; private set; }


        public User User
        {
            set
            {
                sqlCommand1.Parameters["@userID"].Value = value.UserID;
                sqlCommand1.Parameters["@IsAdmin"].Value = value.Admin;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Da li zaista zelite da obrisete ovog pacijenta? Svi njegovi kartoni bice obrisani!",
                       "Brisanje Pacijenta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sqlDataAdapter1.DeleteCommand.Parameters["@PatID"].Value = PatientID;
                sqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
                dataSet11.Pacijent.Clear();
                sqlDataAdapter1.Fill(dataSet11);
            }
        }
    }
}
