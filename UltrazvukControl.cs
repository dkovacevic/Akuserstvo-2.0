using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
    public partial class UltrazvukControl : UserControl
    {
        public UltrazvukControl()
        {
            InitializeComponent();

            imageControl1.labelProtokolID.DataBindings.Add("Text", labelProtokolID, "Text");
        }

        public void LoadControl()
        {
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                    sqlConnection1.Open();

                parovicDS.UZ.Clear();
                var ret = sqlDataAdapterUZ.Fill(parovicDS.UZ);
                                
                imageControl1.LoadControl(ImageControl.Type.UZ);
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
                bindingSourceUZ.EndEdit();
                if (parovicDS.HasChanges())
                {
                    sqlDataAdapterUZ.Update(parovicDS.UZ.GetChanges());
                    LoadControl();
                }

                imageControl1.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        public String Filter
        {
            get { return bindingSourceUZ.Filter; }
            set { bindingSourceUZ.Filter = value; }
        }

        public User User
        {
            set
            {
                sqlDataAdapterUZ.SelectCommand.Parameters["@userID"].Value = value.UserID;
                sqlDataAdapterUZ.SelectCommand.Parameters["@IsAdmin"].Value = value.Admin;                
            }
        }

        public int CurrentPosition
        {
            get
            {
                return this.BindingContext[bindingSourceUZ].Position;
            }
            set
            {
                if (value != -1)
                    this.BindingContext[bindingSourceUZ].Position = value;
            }
        }

        internal int Count
        {
            get { return this.BindingContext[bindingSourceUZ].Count; }
        }

        public void PrepareForReport(ParovicDS.UZStampaRow stampa)
        {
            this.BindingContext[bindingSourceUZ].EndCurrentEdit();

            stampa.Komentar = _komentar.Text;
            stampa.Image = imageControl1.ImagePath;
        }
    }
}
