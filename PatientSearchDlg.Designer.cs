namespace Parovic.Akuserstvo
{
    partial class PatientSearchDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.pacijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Parovic.Akuserstvo.ParovicDS();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxKeywords = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonNoviPacijent = new System.Windows.Forms.Button();
            this.PacijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeSrednjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jMBGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodjenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanimanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AllowUserToResizeRows = false;
            this.dataGridViewPatients.AutoGenerateColumns = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacijentID,
            this.imeDataGridViewTextBoxColumn,
            this.imeSrednjeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.jMBGDataGridViewTextBoxColumn,
            this.rodjenDataGridViewTextBoxColumn,
            this.mestoDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.zanimanjeDataGridViewTextBoxColumn});
            this.dataGridViewPatients.DataSource = this.pacijentBindingSource;
            this.dataGridViewPatients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(543, 223);
            this.dataGridViewPatients.TabIndex = 2;
            this.dataGridViewPatients.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_SelectionChanged);
            this.dataGridViewPatients.DoubleClick += new System.EventHandler(this.dataGridViewPatients_DoubleClick);
            this.dataGridViewPatients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewPatients_KeyPress);
            // 
            // pacijentBindingSource
            // 
            this.pacijentBindingSource.DataMember = "Pacijent";
            this.pacijentBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en");
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(210, 344);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Select";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(307, 344);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxKeywords
            // 
            this.textBoxKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeywords.Location = new System.Drawing.Point(12, 262);
            this.textBoxKeywords.Name = "textBoxKeywords";
            this.textBoxKeywords.Size = new System.Drawing.Size(197, 26);
            this.textBoxKeywords.TabIndex = 1;
            this.textBoxKeywords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeywords_KeyPress);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(233, 265);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonNoviPacijent
            // 
            this.buttonNoviPacijent.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonNoviPacijent.Location = new System.Drawing.Point(32, 344);
            this.buttonNoviPacijent.Name = "buttonNoviPacijent";
            this.buttonNoviPacijent.Size = new System.Drawing.Size(96, 23);
            this.buttonNoviPacijent.TabIndex = 5;
            this.buttonNoviPacijent.Text = "Novi Pacijent";
            this.buttonNoviPacijent.UseVisualStyleBackColor = true;
            this.buttonNoviPacijent.Click += new System.EventHandler(this.buttonNoviPacijent_Click);
            // 
            // PacijentID
            // 
            this.PacijentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PacijentID.DataPropertyName = "PacijentID";
            this.PacijentID.HeaderText = "PacijentID";
            this.PacijentID.Name = "PacijentID";
            this.PacijentID.ReadOnly = true;
            this.PacijentID.Width = 81;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.Width = 49;
            // 
            // imeSrednjeDataGridViewTextBoxColumn
            // 
            this.imeSrednjeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imeSrednjeDataGridViewTextBoxColumn.DataPropertyName = "Ime Srednje";
            this.imeSrednjeDataGridViewTextBoxColumn.HeaderText = "Ime Srednje";
            this.imeSrednjeDataGridViewTextBoxColumn.Name = "imeSrednjeDataGridViewTextBoxColumn";
            this.imeSrednjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeSrednjeDataGridViewTextBoxColumn.Width = 88;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.Width = 69;
            // 
            // jMBGDataGridViewTextBoxColumn
            // 
            this.jMBGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jMBGDataGridViewTextBoxColumn.DataPropertyName = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.HeaderText = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.Name = "jMBGDataGridViewTextBoxColumn";
            this.jMBGDataGridViewTextBoxColumn.ReadOnly = true;
            this.jMBGDataGridViewTextBoxColumn.Width = 61;
            // 
            // rodjenDataGridViewTextBoxColumn
            // 
            this.rodjenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rodjenDataGridViewTextBoxColumn.DataPropertyName = "Rodjen";
            this.rodjenDataGridViewTextBoxColumn.HeaderText = "Rodjen";
            this.rodjenDataGridViewTextBoxColumn.Name = "rodjenDataGridViewTextBoxColumn";
            this.rodjenDataGridViewTextBoxColumn.ReadOnly = true;
            this.rodjenDataGridViewTextBoxColumn.Width = 66;
            // 
            // mestoDataGridViewTextBoxColumn
            // 
            this.mestoDataGridViewTextBoxColumn.DataPropertyName = "Mesto";
            this.mestoDataGridViewTextBoxColumn.HeaderText = "Mesto";
            this.mestoDataGridViewTextBoxColumn.Name = "mestoDataGridViewTextBoxColumn";
            this.mestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zanimanjeDataGridViewTextBoxColumn
            // 
            this.zanimanjeDataGridViewTextBoxColumn.DataPropertyName = "Zanimanje";
            this.zanimanjeDataGridViewTextBoxColumn.HeaderText = "Zanimanje";
            this.zanimanjeDataGridViewTextBoxColumn.Name = "zanimanjeDataGridViewTextBoxColumn";
            this.zanimanjeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PatientSearchDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(567, 379);
            this.Controls.Add(this.buttonNoviPacijent);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxKeywords);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewPatients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientSearchDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga Pacijenata";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.BindingSource pacijentBindingSource;
        private ParovicDS dataSet1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxKeywords;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonNoviPacijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeSrednjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jMBGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodjenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanimanjeDataGridViewTextBoxColumn;
    }
}