using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

//
namespace Parovic.Akuserstvo
{
    /// <summary>
    /// Summary description for Anamneza.
    /// </summary>
    partial class Anamneza : UserControl
    {
        public Anamneza()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            labelIotp.DataBindings.Add("Text", dtOTP, "Text");

            cbKG.DataBindings.Add("SelectedIndex", dataView1, "KG");
            cbRhF.DataBindings.Add("SelectedIndex", dataView1, "RhFactor");

            cbKG_suprug.DataBindings.Add("SelectedIndex", dataView1, "KG Suprug");
            cbRhF_Suprug.DataBindings.Add("SelectedIndex", dataView1, "RhFactor Suprug");

            AlergijeCL.ValBind.Add("Value", dataView1, "Alergije");

        }

        public void SaveChanges()
        {
            try
            {
                this.BindingContext[dataView1].EndCurrentEdit();
                if (parovicDS1.HasChanges())
                {                
                    sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Anamneza");
                    LoadControl();
                }
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

                parovicDS1.Anamneza.Clear();
                var col = sqlDataAdapter1.Fill(parovicDS1);

            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        private void dtPM_ValueChanged(object sender, System.EventArgs e)
        {
            dtOTP.Value = (sender as DateTimePicker).Value + new TimeSpan(7 * 40, 0, 0, 0);
        }

        private void tPorPre_TextChanged(object sender, System.EventArgs e)
        {
            int val1, val2;
            Int32.TryParse(tPorPre.Text, out val1);
            Int32.TryParse(tPorVreme.Text, out val2);

            lPorodjaja.Text = (val1 + val2).ToString();
        }

        private void tPorVreme_TextChanged(object sender, System.EventArgs e)
        {
            tPorPre_TextChanged(sender, e);
        }

        public void PrepareForReport(ParovicDS.StampaRow stampa)
        {
            this.BindingContext[dataView1].EndCurrentEdit();

            //Alergije
            stampa.Alergije = AlergijeCL.Report;
            if (AlergijeCL.Report.Length != 0 && tAlergije.Text.Length != 0)
                stampa.Alergije += ", ";

            stampa.Alergije += tAlergije.Text;
            if ((AlergijeCL.Report + tAlergije.Text).Length == 0)
                stampa.Alergije = "Negira alergije";

            //Bolesti

            stampa.Bolesti = tOperacije.Text;
            if (stampa.Bolesti.Length == 0)
                stampa.Bolesti = "Negira ranije bolesti";

            if (tOperacije.Text.Length == 0)
                stampa.Operacije = "Negira ranije operacije";
            else
                stampa.Operacije = tOperacije.Text;

            stampa.KG = cbKG.Text;
            stampa.Rh = cbRhF.Text;

            stampa.Menstrucije = textBoxMenstruacije.Text;

            stampa.Porodjaja = lPorodjaja.Text;
            stampa.Pobacaja = lPobacaja.Text;
            stampa.Terminskih = tPorVreme.Text;
            stampa.Prevremenih = tPorPre.Text;
            stampa.PM = dtPM.Value;
            stampa.UZTP = dtUZTP.Value;
            stampa.OTP = dtOTP.Value;

            if (tVisina.Text.Length != 0)
                stampa.Visina = Int32.Parse(tVisina.Text);

        }

        private void tSpontanih_TextChanged(object sender, System.EventArgs e)
        {
            int val1, val2;
            Int32.TryParse(tSpontanih.Text, out val1);
            Int32.TryParse(tNamernih.Text, out val2);
            lPobacaja.Text = (val1 + val2).ToString();
        }

        private void tNamernih_TextChanged(object sender, System.EventArgs e)
        {
            tSpontanih_TextChanged(sender, e);
        }

        public String TerminPorodjaja
        {
            get
            {
                return dtOTP.Text;
            }
        }

        public String GS
        {
            get
            {
                TimeSpan TrudnocaTS = DateTime.Now - dtPM.Value;
                var week = TrudnocaTS.Days / 7;
                if (week > 42)
                    return "NA/NA";
                var day = TrudnocaTS.Days % 7;
                return string.Format("{0} / {1}", week, day);
            }
        }

        public String UZTP
        {
            get
            {
                return dtUZTP.Text;
            }
        }

        public String Radjala
        {
            get
            {
                Int32 por;
                Int32.TryParse(lPorodjaja.Text, out por);
                return por > 0 ? "Pluripare" : "Nulipare";
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
                if (value == -1)
                {
                    return;
                }
                this.BindingContext[dataView1].Position = value;
            }
        }

        private float Tezina
        {
            get
            {
                float val = 0;
                float.TryParse(tTezina.Text, out val);
                return val;
            }
        }

        private Int32 Visina
        {
            get
            {
                int val = 0;
                Int32.TryParse(tVisina.Text, out val);
                return val;
            }
        }

        internal String KG
        {
            get
            {
                return cbKG.Text + " " + cbRhF.Text;
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

        private void tTezina_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void tVisina_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void CalculateBMI()
        {
            float fVisina = Visina / 100.0f;
            fVisina *= fVisina;
            float BMI = Visina > 0 ? Tezina / fVisina : 0;
            labelBMI.Text = "BMI: " + BMI.ToString("0.00");
        }
    }
}
