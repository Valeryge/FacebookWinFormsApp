using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class SettingsForm : Form
    {
        private LogManager k_LogManager;
        private MyFacebookService k_MyFacebookService;

        public SettingsForm(MyFacebookService i_MyFacebookService)
        {
            k_LogManager = i_MyFacebookService.LogManager;
            k_MyFacebookService = i_MyFacebookService;
            initializePersonalSettingsPage();
            //k_LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.ActionType.SETTINGS_CLICKED));
          
            InitializeComponent();
            myInitComponents();
        }

        private void initializePersonalSettingsPage()
        {
            // User user = k_MyFacebookService.User;
            // validateData();
            // textBoxAge.Text = getAgeFromBirthDay();
            // textBoxEmail.Text = user.Email;
            // textBoxEducation.Text = user.Educations[0].ToString();
            //textBoxFamily.Text = user.
        }
        //this is a demo, not really validating.
        private void validateData()
        {
            throw new NotImplementedException();
        }

        //TODO: this
        private string getAgeFromBirthDay()
        {
            return "26";
        }


        //TODO: condition to if was today show time and write today, otherwise write date.
        private void myInitComponents()
        {
            List<string> titles = new List<string> { "Time", "Action Type", "Status" }; 

            foreach (string title in titles)
            {
                Label titleLabel = new Label();
                titleLabel.ForeColor = Color.White;
                titleLabel.BackColor = Color.CornflowerBlue;
                titleLabel.Text = title;
                tableLayoutRecentActions.Controls.Add(titleLabel);
            }

            tableLayoutRecentActions.RowCount = k_LogManager.ActionsList.Count;
            foreach (FaceBookAction fbAction in k_LogManager.ActionsList)
            {
                Label labelTime = new Label();
                labelTime.Text = fbAction.Time.TimeOfDay.ToString();

                Label labelType = new Label();
                labelType.Text = fbAction.Type.ToString();

                Label labelErrorStatus = new Label();
                labelErrorStatus.Text = fbAction.ErrorStatus ? "Failed" : "Completed Successfully";

                tableLayoutRecentActions.Controls.Add(labelTime);
                tableLayoutRecentActions.Controls.Add(labelType);
                tableLayoutRecentActions.Controls.Add(labelErrorStatus);

            }

        }

        private void friendsTab_Selected(object sender, TabControlEventArgs e)
        {
            loadPotentialFriends();
        }
        

        private void loadPotentialFriends()
        {
            int currentX = 40;
            int currentY = 50;

            this.Size = new Size(1200, 700);
            this.AutoScroll = true;
            foreach (User suggestion in k_MyFacebookService.GetFriendSuggestions().Take(10))
            {
                Button pictureBox = new Button();

                pictureBox.Image = suggestion.ImageNormal;
               // pictureBox.Image. = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(300, 300);
                pictureBox.Text = suggestion.Name;
                pictureBox.Location = new Point(currentX, currentY);

                if (currentX + 300 > this.Width)
                {
                    currentX = 40;
                    currentY += 300;
                }
                else
                {
                    currentX += 300;
                }
                this.Controls.Add(pictureBox);
            }
           
        }

        private void statisticsTab_Selected(object sender, TabControlEventArgs e)
        {
            loadStatistics();
        }

        private void loadStatistics()
        {
            foreach(FaceBookAction.ActionType type in Enum.GetValues(typeof(FaceBookAction.ActionType)))
            {
                this.actionTypeChart.Series["Activity Type"].Points.AddXY(type.ToString(), k_LogManager.GetActivityCountByType(type));
            }
        }

        private void personalDataTab_Selected(object sender, TabControlEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  changeSettings();
        }
    }
}
