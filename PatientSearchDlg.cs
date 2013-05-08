using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Parovic.Akuserstvo.Properties;

namespace Parovic.Akuserstvo
{
    public partial class PatientSearchDlg : Form
    {
        public int PatientID { get; private set; }
        public int Trimestar { get; private set; }
        public User User { get; private set; }

        Settings _settings = new Settings();

        public PatientSearchDlg(User ser)
        {
            InitializeComponent();
            User = User;
            textBoxKeywords.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var keywords = GetKeywards();
            var values = string.Join(",", keywords);
            try
            {
                using (SqlConnection connection = new SqlConnection(_settings.Connection))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    //cmd.CommandText = "SELECT * FROM Pacijent WHERE Ime LIKE '%" + textBoxKeywords.Text + "%'";

                    cmd.CommandText = string.Format("SELECT * FROM Pacijent WHERE Ime IN ({0}) OR Prezime in ({0})", values);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    dataSet1.Pacijent.Clear();
                    int count = adapter.Fill(dataSet1, "Pacijent");

                    if (count == 0)
                    {
                        cmd.CommandText = string.Format("SELECT * FROM Pacijent WHERE Ime like '%{0}%' OR Prezime like '%{0}%'",
                        textBoxKeywords.Text);
                        count = adapter.Fill(dataSet1, "Pacijent");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, ex);
            }
        }

        string[] GetKeywards()
        {
            List<string> ret = new List<string>();
            foreach (var k in textBoxKeywords.Text.Split(' '))
                ret.Add(string.Format("'{0}'", k));

            return ret.ToArray();
        }

        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {
                buttonOK.Enabled = false;
                return;
            }

            buttonOK.Enabled = true;
            var rowView = dataGridViewPatients.SelectedRows[0].DataBoundItem as DataRowView;
            PatientID = (int)rowView.Row["PacijentID"];
        }

        private void buttonNoviPacijent_Click(object sender, EventArgs e)
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

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPatients_DoubleClick(object sender, EventArgs e)
        {
            buttonOK.PerformClick();
        }

        private void textBoxKeywords_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                buttonSearch.PerformClick();
        }

        private void dataGridViewPatients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridViewPatients.SelectedRows.Count == 0)
            {             
                return;
            }

            if (e.KeyChar == '\b')
            {
                var msg = string.Format("Zaista zelite da obrisete pacijenta sa ID:{0} i sve njene preglede?", PatientID);
                if (MessageBox.Show(msg, "Brisanje pacijenta!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(_settings.Connection))
                        {
                            connection.Open();

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;

                            cmd.CommandText = string.Format("DELETE FROM Pacijent WHERE PacijentID={0}", PatientID);
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();

                            buttonSearch.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Logger.WriteEntry(this.Name, ex);
                    }
                }
            }
        }
    }
}
