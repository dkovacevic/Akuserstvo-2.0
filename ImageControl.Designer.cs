namespace Parovic.Akuserstvo
{
    partial class ImageControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageControl));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bindingSourceImages = new Parovic.Akuserstvo.ImageControl.ImageBindingSource(this.components);
            this.parovicDS = new Parovic.Akuserstvo.ParovicDS();
            this.bindingNavigatorImages = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sqlDataAdapterImages = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.labelProtokolID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorImages)).BeginInit();
            this.bindingNavigatorImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.bindingSourceImages, "Path", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(0, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(453, 361);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // bindingSourceImages
            // 
            this.bindingSourceImages.DataMember = "Images";
            this.bindingSourceImages.DataSource = this.parovicDS;
            this.bindingSourceImages.ImageType = Parovic.Akuserstvo.ImageControl.Type.Unknown;
            this.bindingSourceImages.ProtokolID = 0;
            this.bindingSourceImages.CurrentItemChanged += new System.EventHandler(this.bindingSourceImages_CurrentItemChanged);
            // 
            // parovicDS
            // 
            this.parovicDS.DataSetName = "ParovicDS";
            this.parovicDS.Locale = new System.Globalization.CultureInfo("sr-Latn-CS");
            this.parovicDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorImages
            // 
            this.bindingNavigatorImages.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorImages.BindingSource = this.bindingSourceImages;
            this.bindingNavigatorImages.CanOverflow = false;
            this.bindingNavigatorImages.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorImages.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorImages.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorImages.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorImages.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorImages.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorImages.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorImages.Name = "bindingNavigatorImages";
            this.bindingNavigatorImages.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorImages.Size = new System.Drawing.Size(453, 25);
            this.bindingNavigatorImages.TabIndex = 2;
            this.bindingNavigatorImages.Text = "Images";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sqlDataAdapterImages
            // 
            this.sqlDataAdapterImages.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapterImages.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapterImages.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapterImages.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Images", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ImageID", "ImageID"),
                        new System.Data.Common.DataColumnMapping("ProtokolID", "ProtokolID"),
                        new System.Data.Common.DataColumnMapping("Path", "Path")})});
            this.sqlDataAdapterImages.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Images] WHERE (([ImageID] = @Original_ImageID) AND ([ProtokolID] = @" +
    "Original_ProtokolID) AND ([Path] = @Original_Path))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ImageID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ImageID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProtokolID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProtokolID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Path", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Path", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Images\r\n                         (ProtokolID, Path, Type)\r\nVALUES    " +
    "    (@ProtokolID,@Path,@Type); \r\nSELECT ImageID, ProtokolID, Path FROM Images WH" +
    "ERE (ImageID = SCOPE_IDENTITY())";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProtokolID", System.Data.SqlDbType.Int, 4, "ProtokolID"),
            new System.Data.SqlClient.SqlParameter("@Path", System.Data.SqlDbType.NChar, 256, "Path"),
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Int, 4, "Type")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        ImageID, ProtokolID, Path, Type\r\nFROM            Images\r\nWHERE     " +
    "   (Type = @Type)\r\nORDER BY ProtokolID";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.Int, 4, "Type")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ProtokolID", System.Data.SqlDbType.Int, 0, "ProtokolID"),
            new System.Data.SqlClient.SqlParameter("@Path", System.Data.SqlDbType.NChar, 0, "Path"),
            new System.Data.SqlClient.SqlParameter("@Original_ImageID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ImageID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProtokolID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProtokolID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Path", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Path", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ImageID", System.Data.SqlDbType.Int, 4, "ImageID")});
            // 
            // labelProtokolID
            // 
            this.labelProtokolID.AutoSize = true;
            this.labelProtokolID.Location = new System.Drawing.Point(300, 0);
            this.labelProtokolID.Name = "labelProtokolID";
            this.labelProtokolID.Size = new System.Drawing.Size(35, 13);
            this.labelProtokolID.TabIndex = 3;
            this.labelProtokolID.Text = "label1";
            this.labelProtokolID.TextChanged += new System.EventHandler(this.labelProtokolID_TextChanged);
            // 
            // ImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bindingNavigatorImages);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelProtokolID);
            this.Name = "ImageControl";
            this.Size = new System.Drawing.Size(453, 391);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parovicDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorImages)).EndInit();
            this.bindingNavigatorImages.ResumeLayout(false);
            this.bindingNavigatorImages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.BindingNavigator bindingNavigatorImages;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ImageBindingSource bindingSourceImages;
        private ParovicDS parovicDS;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterImages;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        public System.Windows.Forms.Label labelProtokolID;
    }
}
