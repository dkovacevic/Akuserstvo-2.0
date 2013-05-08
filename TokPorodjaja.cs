using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
    /// <summary>
    /// Summary description for TokPorodjaja.
    /// </summary>
    public partial class TokPorodjaja : UserControl
    {
        private float TrenutnaTezina
        {
            get
            {
                float val = 0;
                float.TryParse(tTrenutnaTezina.Text, out val);
                return val;
            }
        }

        private float PocetnaTezina
        {
            get
            {
                float val = 0;
                float.TryParse(labelPocetnaTezina.Text, out val);
                return val;
            }
        }

        private Int32 Visina
        {
            get
            {
                int val = 0;
                Int32.TryParse(labelVisina.Text, out val);
                return val;
            }
        }

        public TokPorodjaja()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
        }

        public void LoadControl()
        {
            try
            {
                if (sqlConnection1.State != ConnectionState.Open)
                    sqlConnection1.Open();

                parovicDS1.Pregled.Clear();
                var count = sqlDataAdapter1.Fill(parovicDS1);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        public void NewPregled(int pacijentID, int trimestar)
        {
            try
            {
                sqlDataAdapter1.InsertCommand.Parameters["@PacijentID"].Value = pacijentID;
                sqlDataAdapter1.InsertCommand.Parameters["@Trimestar"].Value = trimestar;
                sqlDataAdapter1.InsertCommand.Parameters["@Grupa"].Value = 1;

                sqlDataAdapter1.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        public void DelPregled()
        {
            try
            {
                sqlDataAdapter1.DeleteCommand.Parameters[0].Value = (Int32)protokolID.Value;
                sqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        public void SaveChanges()
        {
            try
            {
                this.BindingContext[dataView1].EndCurrentEdit();
                if (parovicDS1.HasChanges())
                {
                    sqlDataAdapter1.Update(parovicDS1.GetChanges(), "Pregled");
                    LoadControl();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }

        private void CalculateBMI()
        {
            var prirastaj = TrenutnaTezina > 0 ? TrenutnaTezina - PocetnaTezina : 0;
            labelPrirastaj.Text = string.Format("(+{0}) kg", prirastaj.ToString("0.0"));

            if (Visina != 0)
            {
                float fVisina = Visina / 100.0f;
                fVisina *= fVisina;
                float BMI = TrenutnaTezina / fVisina;
                labelBMI.Text = "BMI: " + BMI.ToString("0.00");
            }
        }

        private void labelVisina_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void tTrenutnaTezina_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        private void labelPocetnaTezina_TextChanged(object sender, EventArgs e)
        {
            CalculateBMI();
        }

        public void PrepareForReport(ParovicDS.StampaRow stampa)
        {
            this.BindingContext[dataView1].EndCurrentEdit();

            stampa.BMI = labelBMI.Text;
            stampa.TA = tTAsis.Text + " / " + tTAdias.Text;
            if (labelPrirastaj.Text.Length != 0)
            {
                stampa.Tezina = TrenutnaTezina;
                stampa.Prirastaj = TrenutnaTezina - PocetnaTezina;
            }

            stampa.Razlog = tRazlog.Text;
            stampa.Vagina = tVagina.Text;
            stampa.SMU = tSMU.Text;
            stampa.Uterus = tUterus.Text;
            stampa.Grlic = tGrlic.Text;
            stampa.Adneksa = tAdnesa.Text;
            stampa.Ekarteri = tOstalo.Text;
            stampa.Doctor = this.BindingContext[dataView1, "Doctor"].Current.ToString();
        }

        private void bPrikazi_Click(object sender, System.EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlCommand sqlCmd = new System.Data.SqlClient.SqlCommand();
                sqlCmd.Connection = sqlConnection1;
                int val = (sender as CheckBox).Checked ? 1 : 0;
                sqlCmd.Parameters.AddWithValue("@Valid", val);
                sqlCmd.Parameters.AddWithValue("@ProtokolID", (Int32)protokolID.Value);
                sqlCmd.CommandText = "UPDATE protokol SET Valid = @Valid WHERE protokolID = @ProtokolID";
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (value != -1)
                    this.BindingContext[dataView1].Position = value;
            }
        }

        internal int Count
        {
            get { return this.BindingContext[dataView1].Count; }
        }

        internal string ProtokolID
        {
            get { return protokolID.Value.ToString(); }
        }

        internal string StrTrimestar
        {
            get
            {
                switch ((int)trim.Value)
                {
                    case 0:
                        return "";
                    case 1:
                        return "I";
                    case 2:
                        return "II";
                    case 3:
                        return "III";
                    default:
                        return "Error";
                }
            }
        }

        internal Int32 Trimestar
        {
            get
            {
                return (Int32)trim.Value;
            }
        }

        internal String Tlak
        {
            get
            {
                return tTAsis.Text + "/" + tTAdias.Text;
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
                sqlDataAdapter1.InsertCommand.Parameters["@userID"].Value = value.UserID;
            }
        }
    }
}
