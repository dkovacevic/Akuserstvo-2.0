using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for CheckList.
	/// </summary>
	public class CheckList : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.NumericUpDown numVal;
		private IntBits indexer;
        public event EventHandler SelectedIndexChanged;
        private bool mSingleSelected;
        private int mSelectedIndex;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CheckList()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			indexer = new IntBits(0);

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.numVal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 184);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // numVal
            // 
            this.numVal.Hexadecimal = true;
            this.numVal.Location = new System.Drawing.Point(136, 0);
            this.numVal.Maximum = new decimal(new int[] {
            -803115008,
            232597,
            0,
            0});
            this.numVal.Name = "numVal";
            this.numVal.ReadOnly = true;
            this.numVal.Size = new System.Drawing.Size(48, 20);
            this.numVal.TabIndex = 1;
            this.numVal.TabStop = false;
            this.numVal.ValueChanged += new System.EventHandler(this.numVal_ValueChanged);
            // 
            // CheckList
            // 
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.numVal);
            this.Name = "CheckList";
            this.Size = new System.Drawing.Size(184, 184);
            ((System.ComponentModel.ISupportInitialize)(this.numVal)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void checkedListBox1_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
            if (SingleSelected && e.NewValue == CheckState.Checked)
                indexer.Val = 0;

			indexer[e.Index] = (e.NewValue == CheckState.Checked ? true : false);
			numVal.Value = (decimal) indexer.Val;
		}

		private void numVal_ValueChanged(object sender, System.EventArgs e)
		{
            bool bNothing = true;
            indexer.Val = (Int64)(sender as NumericUpDown).Value;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState chechState = (indexer[i] ? CheckState.Checked : CheckState.Unchecked);
                checkedListBox1.SetItemCheckState(i, chechState);

                if (chechState == CheckState.Checked)
                {
                    SelectedIndex = i;
                    bNothing = false;
                }
            }
            if (bNothing)
                SelectedIndex = -1;	
		}

		public String Report
		{
			get
			{
				String ret = "";
				for(int i = 0; i < checkedListBox1.Items.Count; i++)
				{
					if(indexer[i])
					{
						ret += checkedListBox1.Items[i].ToString() + ", ";
					}
				}

				if(ret.Length != 0)
				{
					ret = ret.Trim();
					ret = ret.Remove(ret.Length-1,1);
				}

				return ret;
			}
		}
		public ControlBindingsCollection ValBind
		{
			get
			{
				return numVal.DataBindings;
			}
			set
			{
				numVal.DataBindings.Add(value["Value"]);
			}
		}		

		public String[] StringItems
		{
			set{
				checkedListBox1.Items.Clear();
				checkedListBox1.Items.AddRange(value);
			}
			get
			{
				String[] ret = new String[checkedListBox1.Items.Count];
				checkedListBox1.Items.CopyTo(ret, 0);
				return ret;
			}
		}

		public object[] ListCollection
		{
			set
			{
				checkedListBox1.Items.Clear();
				checkedListBox1.Items.AddRange(value);				
			}
		}

		public bool ListMultiColumn
		{
			get
			{
				return checkedListBox1.MultiColumn;
			}
			set
			{
				checkedListBox1.MultiColumn = value;
			}
		}
		public Int32 ColumnWidth
		{
			get
			{
				return checkedListBox1.ColumnWidth;
			}
			set
			{
				checkedListBox1.ColumnWidth = value;
			}
		}
        public bool SingleSelected
        {
            get
            {
                return mSingleSelected;
            }
            set
            {
                mSingleSelected = value;
            }
        }
        public int SelectedIndex
        {
            get
            {
                return mSelectedIndex;
            }
            set
            {
                mSelectedIndex = value;
                // Notify bound control of changes
                if (SelectedIndexChanged != null)
                    SelectedIndexChanged(this, EventArgs.Empty);

            }
        }
        public IntBits Indexer
        {
            get
            {
                return indexer;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.SelectedItems.Clear();
        }
	}
}
