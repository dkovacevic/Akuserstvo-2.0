using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
namespace Parovic.Akuserstvo
{
    partial class UltrazvukControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UltrazvukControl));
            this.parovicDS = new Parovic.Akuserstvo.ParovicDS();
            this.bindingSourceUZ = new System.Windows.Forms.BindingSource(this.components);
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapterUZ = new System.Data.SqlClient.SqlDataAdapter();
            this._komentar = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageControl1 = new Parovic.Akuserstvo.ImageControl();
            this.labelProtokolID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUZ)).BeginInit();
            this.SuspendLayout();
            // 
            // parovicDS
            // 
            this.parovicDS.DataSetName = "ParovicDS";
            this.parovicDS.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.parovicDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceUZ
            // 
            this.bindingSourceUZ.DataMember = "UZ";
            this.bindingSourceUZ.DataSource = this.parovicDS;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@userID", System.Data.SqlDbType.Int, 4, "UserID"),
            new System.Data.SqlClient.SqlParameter("@IsAdmin", System.Data.SqlDbType.Bit, 1024)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO UZ\r\n                         (ProtokolID, Komentar)\r\nVALUES        (@" +
    "ProtokolID,@Komentar); \r\nSELECT UZID, ProtokolID, Komentar FROM UZ WHERE (UZID =" +
    " SCOPE_IDENTITY())";
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProtokolID", System.Data.SqlDbType.Int, 4, "ProtokolID"),
            new System.Data.SqlClient.SqlParameter("@Komentar", System.Data.SqlDbType.VarChar, 2147483647, "Komentar")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [UZ] WHERE (([UZID] = @Original_UZID) AND ([ProtokolID] = @Original_P" +
    "rotokolID) AND ((@IsNull_Komentar = 1 AND [Komentar] IS NULL) OR ([Komentar] = @" +
    "Original_Komentar)))";
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_UZID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UZID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProtokolID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProtokolID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Komentar", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Komentar", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Komentar", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Komentar", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapterUZ
            // 
            this.sqlDataAdapterUZ.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataAdapterUZ.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataAdapterUZ.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapterUZ.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "UZ", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("UZID", "UZID"),
                        new System.Data.Common.DataColumnMapping("ProtokolID", "ProtokolID"),
                        new System.Data.Common.DataColumnMapping("Komentar", "Komentar")})});
            // 
            // _komentar
            // 
            this._komentar.AcceptsTab = true;
            this._komentar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUZ, "Komentar", true));
            this._komentar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._komentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._komentar.Location = new System.Drawing.Point(0, 394);
            this._komentar.Name = "_komentar";
            this._komentar.Size = new System.Drawing.Size(808, 237);
            this._komentar.TabIndex = 5;
            this._komentar.Text = "";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(555, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 48);
            this.panel1.TabIndex = 6;
            // 
            // imageControl1
            // 
            this.imageControl1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.imageControl1.Image = null;
            this.imageControl1.InitialImage = null;
            this.imageControl1.Location = new System.Drawing.Point(0, 3);
            this.imageControl1.Name = "imageControl1";
            this.imageControl1.RenderInitialImage = false;
            this.imageControl1.Size = new System.Drawing.Size(490, 385);
            this.imageControl1.TabIndex = 4;
            // 
            // labelProtokolID
            // 
            this.labelProtokolID.AutoSize = true;
            this.labelProtokolID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUZ, "ProtokolID", true));
            this.labelProtokolID.Location = new System.Drawing.Point(565, 115);
            this.labelProtokolID.Name = "labelProtokolID";
            this.labelProtokolID.Size = new System.Drawing.Size(35, 13);
            this.labelProtokolID.TabIndex = 7;
            this.labelProtokolID.Text = "label1";
            // 
            // UltrazvukControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelProtokolID);
            this.Controls.Add(this._komentar);
            this.Controls.Add(this.imageControl1);
            this.Name = "UltrazvukControl";
            this.Size = new System.Drawing.Size(808, 631);
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ParovicDS parovicDS;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterUZ;
        private System.Windows.Forms.BindingSource bindingSourceUZ;
        private ImageControl imageControl1;
        private RichTextBox _komentar;
        private Panel panel1;
        private Label labelProtokolID;
    }
}
