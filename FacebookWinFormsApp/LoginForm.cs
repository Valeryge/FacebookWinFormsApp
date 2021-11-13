using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        private int k_CollectionLimit = 50;
        private UserForm m_MainForm;
        private readonly MyFacebookService k_MyFBServices;
        public LoginForm()
        {
           // initTablePanel(3);
            InitializeComponent();
            myInitComponent();
            k_MyFBServices = new MyFacebookService();
            FacebookService.s_CollectionLimit = k_CollectionLimit;
        }
        
        private void myInitComponent()
        {
            this.Size = new Size(1200, 700);
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_E)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            k_MyFBServices.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.eActionType.LoginClicked));
            //TODO: change back to login
            FacebookWrapper.LoginResult loginResult = FacebookService.Connect("EAACTrYdYvoEBAEGE204BTL51O4sP0guav6s1Y0h7KZCptt5lAd5o31G226SKhvsKwOvFbdek3I4vVqc7jZCzM2e75m9BwmX7ZABS8eGimqpKZB2ZBXRRwvmZAQZBEQOpeEYexqSQLARf9YVMb6eIB4gkpJZBFlD6feDQn6tYP8mLlwZDZD");
      /*      FacebookWrapper.LoginResult loginResult = FacebookService.Login(
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

                    "pages_manage_posts", 
                    "pages_read_engagement", 
                    "pages_manage_posts",

                    "publish_to_groups" 
                  //  "user_messenger_contact"
                    // "publish_pages"- doesn't work
                    //  "can_post" taken from developers.facebook.com - should work but doesn't.
                    ); */

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                k_MyFBServices.Init(loginResult);
                m_MainForm = new UserForm(k_MyFBServices);
                this.Hide();
                m_MainForm.Closed += mainForm_Closed;
                m_MainForm.Show();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
            } 
        }

        private void mainForm_Closed(object i_Sender, EventArgs i_E)
        {
            this.Show();
        }
    }
}