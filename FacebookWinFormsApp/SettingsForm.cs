using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public partial class SettingsForm : Form
    {
        private readonly MyFacebookService k_MyFacebookService;

        public SettingsForm(MyFacebookService i_MyFacebookService)
        {
            k_MyFacebookService = i_MyFacebookService;
            InitializeComponent();
            myInitComponents();
        }

        private void initializePersonalSettingsPage()
        {
            DemoFullUserData userData  = new DemoFullUserData(k_MyFacebookService.LoggedUser);
            
            textBoxName.Text = userData.Name;
            textBoxBirthDay.Text = userData.BirthDay;
            textBoxEmail.Text = userData.Email;
            textBoxEducation.Text = userData.Education;
            textBoxWorkPlace.Text = userData.WorkPlace;
            textBoxSignificantOther.Text = userData.SignificantOther;
            textBoxHomeTown.Text = userData.HomeTown;

        }

        private void myInitComponents()
        {
            loadStatistics();
            createTableOfUserActions();
            initializePersonalSettingsPage();
        }

        private void createTableOfUserActions()
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

            tableLayoutRecentActions.RowCount = k_MyFacebookService.LogManager.ActionsList.Count;
            foreach (FaceBookAction fbAction in k_MyFacebookService.LogManager.ActionsList)
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

        private void loadStatistics()
        {
            foreach (FaceBookAction.eActionType type in Enum.GetValues(typeof(FaceBookAction.eActionType)))
            {
                this.actionTypeChart.Series["Activity Type"].Points.AddXY(type.ToString(), k_MyFacebookService.LogManager.GetActivityCountByType(type));
            }
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Press O.K if you're sure the data you've entered is correct.", "Confirmation", MessageBoxButtons.OKCancel);
           
            if (result == DialogResult.OK)
            {
                if (validateData())
                {
                    EditUserData();
                }
            }
        }

        //this is a demo, not really validating.
        private bool validateData() {
            return true;
        }

        private void EditUserData()
        {
            // also a demo - here we would change the user personal information with the facebook api (but it is readonly)
            // for example:
            // this.k_MyFacebookService.LoggedUser.Name = textBoxName.Text;
        }
    }
}
