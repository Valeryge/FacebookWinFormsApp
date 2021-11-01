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
        LoggedUserForm m_MainForm;

        public LoginForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            
            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    "162373509365377",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                  
                   // "manage_pages" - doesn't work
                   "pages_manage_posts",
                   "public_profile",
                    "publish_to_groups"
                  //  "user_messenger_contact"
                    // "publish_pages"- doesn't work
                    //  "can_post" taken from developers.facebook.com - should work but doesn't.
                    );

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                m_MainForm = new LoggedUserForm(loginResult);
                this.Hide();
                m_MainForm.Closed += mainForm_Closed;
                m_MainForm.Show();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
            }
        }

        private void mainForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}