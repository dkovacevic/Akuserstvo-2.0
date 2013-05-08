using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for Info.
	/// </summary>
	public class Info : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lTrimestar;
		private System.Windows.Forms.Label lKG;
		private System.Windows.Forms.Label lTlak;
		private System.Windows.Forms.Label lRatka;
        private Label label2;
        private Label label3;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Info()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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

		public String Trimestar
		{
			set 
			{
				lTrimestar.Text = value;
			}
		}

		public String KG
		{
			set 
			{
				lKG.Text = value;
			}
		}

		public String Tlak
		{
			set 
			{
				lTlak.Text = value;
			}
		}

		public String Rotka
		{
			set 
			{
				lRatka.Text = value;
			}
		}


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.lTrimestar = new System.Windows.Forms.Label();
            this.lKG = new System.Windows.Forms.Label();
            this.lTlak = new System.Windows.Forms.Label();
            this.lRatka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Trimestar:";
            // 
            // lTrimestar
            // 
            this.lTrimestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTrimestar.Location = new System.Drawing.Point(104, 8);
            this.lTrimestar.Name = "lTrimestar";
            this.lTrimestar.Size = new System.Drawing.Size(32, 23);
            this.lTrimestar.TabIndex = 24;
            this.lTrimestar.Text = "III";
            // 
            // lKG
            // 
            this.lKG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKG.ForeColor = System.Drawing.Color.Red;
            this.lKG.Location = new System.Drawing.Point(47, 40);
            this.lKG.Name = "lKG";
            this.lKG.Size = new System.Drawing.Size(63, 23);
            this.lKG.TabIndex = 25;
            this.lKG.Text = "K.G";
            this.lKG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTlak
            // 
            this.lTlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTlak.Location = new System.Drawing.Point(47, 73);
            this.lTlak.Name = "lTlak";
            this.lTlak.Size = new System.Drawing.Size(81, 23);
            this.lTlak.TabIndex = 26;
            this.lTlak.Text = "120/80";
            this.lTlak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lRatka
            // 
            this.lRatka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRatka.Location = new System.Drawing.Point(14, 106);
            this.lRatka.Name = "lRatka";
            this.lRatka.Size = new System.Drawing.Size(96, 23);
            this.lRatka.TabIndex = 27;
            this.lRatka.Text = "Nulipare";
            this.lRatka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "KG:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "TA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.lTlak);
            this.Controls.Add(this.lKG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lRatka);
            this.Controls.Add(this.lTrimestar);
            this.Controls.Add(this.label1);
            this.Name = "Info";
            this.Size = new System.Drawing.Size(128, 144);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
