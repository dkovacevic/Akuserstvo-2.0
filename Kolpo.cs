using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
    /// <summary>
    /// Summary description for Kolpo.
    /// </summary>
    public partial class Kolpo : UserControl
    {
        public Kolpo()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            clKolpo.ValBind.Add("Value", dataView1, "Kolpo");
            clHPV.ValBind.Add("Value", dataView1, "HPV");
            clBiopsija.ValBind.Add("Value", dataView1, "Biopsija");

            cbDestr.DataBindings.Add("SelectedIndex", dataView1, "Destruktivne");
            cbEkscizione.DataBindings.Add("SelectedIndex", dataView1, "Ekscizione");
            cbHisterektomija.DataBindings.Add("SelectedIndex", dataView1, "Histerektomija");
            
            clHPV.DataBindings.Add("Enabled", rHPVt, "Checked");
            clBiopsija.DataBindings.Add("Enabled", rBiopsijaT, "Checked");
            cbDestr.DataBindings.Add("Enabled", bDestr, "Checked");
            cbEkscizione.DataBindings.Add("Enabled", bEkscizione, "Checked");
            cbHisterektomija.DataBindings.Add("Enabled", bHisterektomija, "Checked");
            
            imageControl1.labelProtokolID.DataBindings.Add("text", labelProtokolID, "Text");
        }                

        public void SaveChanges()
        {
            try
            {
                this.BindingContext[dataView1].EndCurrentEdit();
                if (dataSet11.HasChanges())
                {
                    sqlDataAdapter1.Update(dataSet11.GetChanges(), "Kolpo");
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

        public void LoadControl()
        {
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                    sqlConnection1.Open();

                dataSet11.Kolpo.Clear();
                var ret = sqlDataAdapter1.Fill(dataSet11.Kolpo);

                imageControl1.LoadControl(ImageControl.Type.Kolpo);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        public void PrepareForReport(ParovicDS.StampaRow stampa)
        {
            this.BindingContext[dataView1].EndCurrentEdit();

            if (string.IsNullOrWhiteSpace(clKolpo.Report))
                stampa.PA_Nalaz = "Uredan";
            else
                stampa.PA_Nalaz = clKolpo.Report;

            stampa.PA_Grupa = (rPAII.Checked ? "II grupa" : (rPAIII.Checked ? "III grupa" : "IV grupa"));

            if (rHPVf.Checked)
                stampa.PA_HPV_tipizacija = "Nije radjena";
            else
                stampa.PA_HPV_tipizacija = clHPV.Report;

            if (rBiopsijaF.Checked)
                stampa.PA_Biopsija = "Nije radjena";
            else
                stampa.PA_Biopsija = clBiopsija.Report;

            stampa.PA_Terapija = "";
            stampa.PA_Terapija += bDestr.Checked ? bDestr.Text + " - " + cbDestr.Text + ", " : "";
            stampa.PA_Terapija += bEkscizione.Checked ? bEkscizione.Text + " - " + cbEkscizione.Text + ", " : "";
            stampa.PA_Terapija += bHisterektomija.Checked ? bHisterektomija.Text + " - " + cbHisterektomija.Text + ", " : "";
            
            if (stampa.PA_Terapija.Length != 0)
                stampa.PA_Terapija = stampa.PA_Terapija.Remove(stampa.PA_Terapija.Length - 2, 2);

            stampa.PA_Komentar = tKomentar.Text;
            stampa.Doctor = this.BindingContext[dataView1, "Doctor"].Current.ToString();
        }

        public int CurrentPosition
        {
            get
            {
                return this.BindingContext[dataView1].Position;
            }
            set
            {
                if (value != -1)
                    this.BindingContext[dataView1].Position = value;
            }
        }

        public String Filter
        {
            get { return dataView1.RowFilter; }
            set { dataView1.RowFilter = value; }
        }

        public User User
        {
            set
            {
                sqlDataAdapter1.SelectCommand.Parameters["@userID"].Value = value.UserID;
                sqlDataAdapter1.SelectCommand.Parameters["@IsAdmin"].Value = value.Admin;
            }
        }

        private void rPAII_CheckedChanged(object sender, System.EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                nPA.Value = 2M;
        }

        private void rPAIII_CheckedChanged(object sender, System.EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                nPA.Value = 3M;
        }

        private void rPAIV_CheckedChanged(object sender, System.EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                nPA.Value = 4M;
        }

        private void nPA_ValueChanged(object sender, System.EventArgs e)
        {
            switch ((Int32)(sender as NumericUpDown).Value)
            {
                case 2:
                    rPAII.Checked = true;
                    break;
                case 3:
                    rPAIII.Checked = true;
                    break;
                case 4:
                    rPAIV.Checked = true;
                    break;
                default:
                    rPAIV.Checked = rPAII.Checked = rPAIII.Checked = false;
                    break;
            }
        }

        private void rHPVt_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                rHPVf.Checked = true;
        }

        private void rBiopsijaT_CheckedChanged(object sender, System.EventArgs e)
        {
            if (!(sender as RadioButton).Checked)
                rBiopsijaF.Checked = true;
        }
        
        private void bDestr_CheckedChanged(object sender, EventArgs e)
        {
            if (!bDestr.Checked)
            {
                cbDestr.SelectedIndex = 0;
                cbDestr.Enabled = false;
            }
        }

        private void bEkscizione_CheckedChanged(object sender, EventArgs e)
        {
            if (!bEkscizione.Checked)
            {
                cbEkscizione.SelectedIndex = 0;
                cbEkscizione.Enabled = false;
            }
        }

        private void bHisterektomija_CheckedChanged(object sender, EventArgs e)
        {
            if (!bHisterektomija.Checked)
            {
                cbHisterektomija.SelectedIndex = 0;
                cbHisterektomija.Enabled = false;
            }
        }

    }
}
