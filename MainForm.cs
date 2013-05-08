using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Parovic.Akuserstvo
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        private bool _isLoggedIn;
        private int _currentPacijentID;
        private User _user;

        public MainForm()
        {
            try
            {
                //
                // Required for Windows Form Designer support
                //
                InitializeComponent();

                Logger.Source = "Akuserstvo";

                tokPorodjaja1.labelPocetnaTezina.DataBindings.Add("Text", anamneza1.tTezina, "Text");
                tokPorodjaja1.labelVisina.DataBindings.Add("Text", anamneza1.tVisina, "Text");

                _isLoggedIn = PerformLogin();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, e);
            }
        }
                
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                Logger.WriteEntry("Main", e);
            }
        }

        private void ImenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
            tokPorodjaja1.NewPregled(_currentPacijentID, 1);
            LoadAllTabs();
            mainTab.SelectedIndex = 2;
        }

        private void IImenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
            tokPorodjaja1.NewPregled(_currentPacijentID, 2);
            LoadAllTabs();
            mainTab.SelectedIndex = 2;
        }

        private void IIImenuItem_Click(object sender, System.EventArgs e)
        {
            Save();
            tokPorodjaja1.NewPregled(_currentPacijentID, 3);
            LoadAllTabs();
            mainTab.SelectedIndex = 2;
        }

        private void LoadAllTabs()
        {
            generalije1.User = _user;
            anamneza1.User = _user;
            tokPorodjaja1.User = _user;
            trimestarI1.User = _user;
            trimestarII1.User = _user;
            trimestarIII1.User = _user;
            dijagnoza1.User = _user;
            kolpo1.User = _user;
            _ultrazvukControl.User = _user;

            generalije1.LoadControl();
            anamneza1.LoadControl();
            tokPorodjaja1.LoadControl();
            dijagnoza1.LoadControl();
            trimestarI1.LoadControl();
            trimestarII1.LoadControl();
            trimestarIII1.LoadControl();
            kolpo1.LoadControl();
            _ultrazvukControl.LoadControl();

            string filter = "PacijentID = " + _currentPacijentID.ToString();
            SetFilter(filter);

            SetStatusBarAndToolBar();
        }

        private void SetStatusBarAndToolBar()
        {
            try
            {
                statusBarPanelIme.Text = generalije1.Ime;
                statusBarPanelPrezime.Text = generalije1.Prezime;
                statusBarPanelID.Text = tokPorodjaja1.ProtokolID;
                statusBarPanelTermin.Text = anamneza1.TerminPorodjaja;
                statusBarPanelGS.Text = anamneza1.GS;
                statusBarPanelUZTP.Text = anamneza1.UZTP;
                statusBarPanelPoli.Text = anamneza1.Radjala;
                info1.Rotka = anamneza1.Radjala;
                info1.Trimestar = tokPorodjaja1.StrTrimestar;
                info1.KG = anamneza1.KG;
                info1.Tlak = tokPorodjaja1.Tlak;

                LastBtn.Enabled = NextBtn.Enabled = (tokPorodjaja1.CurrentPosition > 0);
                FirstBtn.Enabled = PrevBtn.Enabled = (tokPorodjaja1.CurrentPosition < tokPorodjaja1.Count - 1);
                delProtokolBtn.Enabled = !LastBtn.Enabled && filterBtn.Pushed;
                NewPregledBtn.Enabled = filterBtn.Pushed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.WriteEntry(this.Name, ex);
            }
        }
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (!_isLoggedIn)
            {
                Close();
                return;
            }

            LoadAllTabs();

            mainTab.SelectTab(1);
            mainTab.SelectTab(2);
            mainTab.SelectTab(3);
            mainTab.SelectTab(4);
            mainTab.SelectTab(0);
        }

        private void Save()
        {
            int pos = generalije1.CurrentPosition;
            generalije1.SaveChanges();
            anamneza1.SaveChanges();
            tokPorodjaja1.SaveChanges();
            dijagnoza1.SaveChanges();
            trimestarI1.SaveChanges();
            trimestarII1.SaveChanges();
            trimestarIII1.SaveChanges();
            kolpo1.SaveChanges();
            _ultrazvukControl.SaveChanges();

            SetPos(pos);
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            switch (e.Button.Text)
            {
                case "Pacijenti":
                    Save();
                    ManagePatients();
                    break;
                case "Novi Pregled":
                    if (MessageBox.Show(this, "Da li zaista zelite da otvorite novi pregled za ovog pacijenta?",
                                    "Otvaranje novog pregleda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Save();
                        tokPorodjaja1.NewPregled(_currentPacijentID, 1);
                        LoadAllTabs();
                        mainTab.SelectedIndex = 2;
                    }
                    break;
                case "Prvi":
                    SetPos(100000);
                    break;
                case "Prethodni":
                    Previous();
                    break;
                case "Sledeci":
                    Next();
                    break;
                case "Poslednji":
                    SetPos(0);
                    break;
                case "Obrisi":
                    if (MessageBox.Show(this, "Da li zaista zelite da obrisete pregled za ovog pacijenta?",
                        "Brisanje tekuceg pregleda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Save();
                        tokPorodjaja1.DelPregled();
                        LoadAllTabs();
                    }
                    break;
                case "Filter":
                    Save();
                    if (e.Button.Pushed)
                    {
                        _currentPacijentID = generalije1.PacijentID;
                        LoadAllTabs();
                    }
                    else
                    {
                        SetFilter("");
                    }

                    break;
                case "Kalendar":
                    Kalendar kalendar = new Kalendar();
                    kalendar.UserName = _user.UserName;
                    kalendar.ShowDialog(this);
                    break;
                case "Stampa":
                    ManagePrint();
                    break;
                case "Statistika":
                    Save();
                    ManageStat();
                    break;
                case "Save":
                    Save();
                    break;
            }

            switch (toolBar1.Buttons.IndexOf(e.Button))
            {
                case 19:
                    AboutDlg about = new AboutDlg();
                    about.ShowDialog();
                    break;
            }

            SetStatusBarAndToolBar();
        }

        private void ManagePrint()
        {
            try
            {
                parovicDS1.Stampa.Clear();
                ParovicDS.StampaRow stampa = parovicDS1.Stampa.NewStampaRow();
                generalije1.PrepareForReport(stampa);
                anamneza1.PrepareForReport(stampa);
                tokPorodjaja1.PrepareForReport(stampa);
                dijagnoza1.PrepareForReport(stampa);
                kolpo1.PrepareForReport(stampa);

                parovicDS1.Stampa.AddStampaRow(stampa);

                parovicDS1.UZStampa.Clear();
                ParovicDS.UZStampaRow uzstampa = parovicDS1.UZStampa.NewUZStampaRow();
                _ultrazvukControl.PrepareForReport(uzstampa);
                parovicDS1.UZStampa.AddUZStampaRow(uzstampa);

                PrintPreview prevDialog = new PrintPreview();
                if (mainTab.SelectedTab == tabPageKolpo)
                    prevDialog.PaReport.SetDataSource(parovicDS1);
                else
                    prevDialog.Izvestaj.SetDataSource(parovicDS1);

                prevDialog.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Greska prilikom stampanja izvestaja", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.WriteEntry(this.Name, ex);
            }
        }
        private void ManageStat()
        {
            try
            {
                DatumIntervalDlg intDlg = new DatumIntervalDlg();
                if (intDlg.ShowDialog(this) == DialogResult.OK)
                {
                    PrintPreview prevDialog = new PrintPreview();
                    if (intDlg.Dijagnoze)
                    {
                        prevDialog.DiagStatReport(intDlg.Start, intDlg.End);
                    }
                    else
                    {
                        parovicDS1.Statistika.Clear();
                        ParovicDS.StatistikaRow statRow = parovicDS1.Statistika.NewStatistikaRow();
                        parovicDS1.Statistika.AddStatistikaRow(statRow);

                        prevDialog.PrepareForReport(statRow, intDlg.Start, intDlg.End);
                        prevDialog.Stat.SetDataSource(parovicDS1);
                    }

                    prevDialog.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Greska prilikom stampanja izvestaja", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.WriteEntry(this.Name, ex);
            }
        }

        private void ManagePatients()
        {            
            PatientSearchDlg searchDlg = new PatientSearchDlg(_user);
            var res = searchDlg.ShowDialog(this);
            switch (res)
            {
                case DialogResult.OK:
                    // Samo prikazi selectovanog pacijenta
                    _currentPacijentID = searchDlg.PatientID;
                    break;

                case DialogResult.Yes:
                    // Novi Pacijent
                    var newPatientID = generalije1.NewPacijent();
                    tokPorodjaja1.NewPregled(newPatientID, searchDlg.Trimestar);
                    LoadAllTabs();
                    _currentPacijentID = newPatientID;
                    break;
                default:
                    return;
            }

            SetPos(0);
            SetFilter("PacijentID = " + _currentPacijentID.ToString());
            mainTab.SelectedIndex = 0;
            filterBtn.Pushed = true;
        }

        private void SetFilter(string filter)
        {
            generalije1.Filter = filter;
            anamneza1.Filter = filter;
            dijagnoza1.Filter = filter;
            tokPorodjaja1.Filter = filter;
            trimestarI1.Filter = filter;
            trimestarII1.Filter = filter;
            trimestarIII1.Filter = filter;
            kolpo1.Filter = filter;
        }

        void SetPos(int pos)
        {
            generalije1.CurrentPosition = pos;
            anamneza1.CurrentPosition = pos;
            tokPorodjaja1.CurrentPosition = pos;
            dijagnoza1.CurrentPosition = pos;
            trimestarI1.CurrentPosition = pos;
            trimestarII1.CurrentPosition = pos;
            trimestarIII1.CurrentPosition = pos;
            kolpo1.CurrentPosition = pos;
            _ultrazvukControl.CurrentPosition = pos;
        }

        void Previous()
        {
            generalije1.CurrentPosition++;
            anamneza1.CurrentPosition++;
            tokPorodjaja1.CurrentPosition++;
            dijagnoza1.CurrentPosition++;
            trimestarI1.CurrentPosition++;
            trimestarII1.CurrentPosition++;
            trimestarIII1.CurrentPosition++;
            kolpo1.CurrentPosition++;
            _ultrazvukControl.CurrentPosition++;
        }

        void Next()
        {
            generalije1.CurrentPosition--;
            anamneza1.CurrentPosition--;
            tokPorodjaja1.CurrentPosition--;
            dijagnoza1.CurrentPosition--;
            trimestarI1.CurrentPosition--;
            trimestarII1.CurrentPosition--;
            trimestarIII1.CurrentPosition--;
            kolpo1.CurrentPosition--;
            _ultrazvukControl.CurrentPosition--;
        }

        private void mainTab_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SetStatusBarAndToolBar();
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Save();
        }        

        private bool PerformLogin()
        {
            try
            {
                sqlConnection1.Open();

                LoginDlg login = new LoginDlg();
                for (int i = 0; i < 3; i++)
                {
                    if (login.ShowDialog(this) != DialogResult.OK)
                    {
                        return false;
                    }

                    if (login.User.Logged)
                    {
                        _user = login.User;
                        sqlCmdLastPatID.Parameters["@userID"].Value = _user.UserID;
                        sqlCmdLastPatID.Parameters["@IsAdmin"].Value = _user.Admin;

                        Object res = sqlCmdLastPatID.ExecuteScalar();
                        if (res != null)
                            _currentPacijentID = (int)res;

                        kalendarBtn.Enabled = _user.Admin;
                        break;
                    }
                    else
                    {
                        MessageBox.Show(this, "Pogresan user ili password",
                            "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!_user.Logged)// failed to login 3 times
                    return false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Ne mogu da se konektujem na SQL Server!\n" + ex.Message, "Problemi sa konekcijom",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Logger.WriteEntry(this.Name, ex);
                return false;
            }
            return true;
        }
    }
}
