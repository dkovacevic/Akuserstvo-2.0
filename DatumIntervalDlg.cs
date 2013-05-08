using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
    public partial class DatumIntervalDlg : Form
    {
        public DatumIntervalDlg()
        {
            InitializeComponent();
            int year = DateTime.Now.Year;
            dtStart.Value = new DateTime(year, 1, 1, 0, 0, 1);
            dtEnd.Value = new DateTime(year, 12, 31, 23, 59, 59);
            
        }

        public DateTime Start
        {
            get
            {
                return dtStart.Value;
            }
        }
        public DateTime End
        {
            get
            {
                return dtEnd.Value;
            }
        }
        public bool Dijagnoze
        {
            get{
                return bDijag.Checked;
            }
        }

    }

 
}