using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
	    public LoginForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "162373509365377", 
                    /// requested permissions:
					"email",
                    "public_profile"
                    /// add any relevant permissions
                    );
            if (loginResult != null)
            {
	            LoggedUserForm UsingFBForm = new LoggedUserForm(loginResult);
                this.Hide(); //there's got to be a better way for doing this
	            UsingFBForm.ShowDialog();
            }

            // buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.Logout();
			buttonLogin.Text = "Login";
		}
	}

    
}
