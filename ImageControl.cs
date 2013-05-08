using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Parovic.Akuserstvo
{
    public partial class ImageControl : UserControl
    {
        public enum Type
        {
            Unknown = 0,
            UZ = 1,
            Kolpo
        }

        class ImageBindingSource : BindingSource
        {
            public ImageBindingSource(IContainer container)
                : base(container)
            { }

            public override object AddNew()
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ParovicDS ds = base.DataSource as ParovicDS;
                    var row = ds.Images.AddImagesRow(ProtokolID, dlg.FileName, (int)ImageType);
                    base.MoveLast();
                    return row;
                }

                return null;
            }

            public int ProtokolID { get; set; }
            public Type ImageType { get; set; }
        }

        public ImageControl()
        {
            InitializeComponent();
        }

        private Type ImageType { get; set; }

        public void LoadControl(Type type)
        {
            bindingSourceImages.ImageType = ImageType = type;

            sqlDataAdapterImages.SelectCommand.Parameters["@Type"].Value = type;
            sqlDataAdapterImages.InsertCommand.Parameters["@Type"].Value = type;

            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                    sqlConnection1.Open();

                parovicDS.Images.Clear();

                sqlDataAdapterImages.SelectCommand.Parameters["@Type"].Value = type;
                var ret = sqlDataAdapterImages.Fill(parovicDS.Images);

            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        public void SaveChanges()
        {
            try
            {
                bindingSourceImages.EndEdit();
                if (parovicDS.HasChanges())
                {
                    var ch = parovicDS.Images.GetChanges();
                    sqlDataAdapterImages.Update(ch);
                    LoadControl(ImageType);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        private void labelProtokolID_TextChanged(object sender, EventArgs e)
        {
            int protokolID;
            if (Int32.TryParse(labelProtokolID.Text, out protokolID))
            {
                bindingSourceImages.Filter = "ProtokolID=" + labelProtokolID.Text;
                bindingSourceImages.ProtokolID = protokolID;
            }
        }

        public string ImagePath
        {
            get
            {
                return pictureBox.ImageLocation;
            }
        }

        public bool RenderInitialImage { get; set; }

        public Image InitialImage
        {
            get
            {
                return pictureBox.InitialImage;
            }
            set
            {
                pictureBox.InitialImage = value;
            }
        }

        public Image Image
        {
            get
            {
                return pictureBox.Image;
            }
            set
            {
                pictureBox.Image = value;
            }
        }

        private void bindingSourceImages_CurrentItemChanged(object sender, EventArgs e)
        {
            if (pictureBox.Image == null && RenderInitialImage)
            {
                this.pictureBox.Image = pictureBox.InitialImage;
            }
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox.ImageLocation != null)
            {
                Process proc = new Process();

                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = pictureBox.ImageLocation;

                proc.Start();
            }
        }

        
    }
}
