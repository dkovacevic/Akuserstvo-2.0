using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Parovic.Akuserstvo
{
	/// <summary>
	/// Summary description for Login.
	/// </summary>
	public class LoginDlg : System.Windows.Forms.Form
    {
		private System.Windows.Forms.TextBox passwordTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button LoginBtn;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		private User user;
        private ComboBox cbUser;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LoginDlg()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			user = new User();
			user.UserID = -1;
            passwordTB.Text = "pare";
            cbUser.Text = "Vlada";
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDlg));
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(72, 48);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(112, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LoginBtn.Location = new System.Drawing.Point(91, 88);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::Parovic.Akuserstvo.Properties.Settings.Default.Connection;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT UserID, Name, Admin FROM [User] WHERE (Password = @Password) AND (Name = @" +
                "User)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.VarChar, 20, "Password"),
            new System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.VarChar, 10, "Name")});
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Items.AddRange(new object[] {
            "Vlada",
            "Zoran",
            "Milica"});
            this.cbUser.Location = new System.Drawing.Point(72, 16);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(112, 21);
            this.cbUser.TabIndex = 0;
            // 
            // Login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(256, 117);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void LoginBtn_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(sqlConnection1.State != ConnectionState.Open	)
					sqlConnection1.Open();

				sqlCommand1.Parameters["@User"].Value = cbUser.Text.Trim();
				sqlCommand1.Parameters["@Password"].Value = passwordTB.Text.Trim();


				SqlDataReader reader = sqlCommand1.ExecuteReader(CommandBehavior.SingleRow);

				if(reader.Read())
				{
				
					user.Logged = true;
					user.UserID = reader.GetInt32(0);
					user.UserName = reader.GetString(1);
					user.Admin = reader.GetBoolean(2);
				}
                reader.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, "Login: " + ex.Message, "Greska kod logina", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                Logger.WriteEntry(this.Name, ex);
			}
		}

		public User User
		{
			get
			{
				return user;
			}
		}
	}
}
