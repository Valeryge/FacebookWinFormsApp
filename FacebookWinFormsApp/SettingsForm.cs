using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class SettingsForm : Form
    {
        private readonly LogManager k_LogManager;
        private readonly MyFacebookService k_MyFacebookService;

        public SettingsForm(MyFacebookService i_MyFacebookService)
        {
            k_LogManager = i_MyFacebookService.LogManager;
            k_MyFacebookService = i_MyFacebookService;
            InitializeComponent();
            myInitComponents();
        }

        private void initializePersonalSettingsPage()
        {
            User user = k_MyFacebookService.User;
            validateData();
            textBoxName.Text = user.Name;
            textBoxBirthDay.Text = user.Birthday;
            textBoxEmail.Text = user.Email;
            textBoxEducation.Text = "Go ask Guy Ronen";
            textBoxWorkPlace.Text = "Worked here, Worked there.";
            textBoxSignificantOther.Text = "Love of my life";
            textBoxHomeTown.Text = "TLV baby";
            }

        //this is a demo, not really validating.
        private void validateData() { }
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
        private void loadStatistics()
        {
            foreach (FaceBookAction.eActionType type in Enum.GetValues(typeof(FaceBookAction.eActionType)))
            {
                this.actionTypeChart.Series["Activity Type"].Points.AddXY(type.ToString(), k_LogManager.GetActivityCountByType(type));
            }
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press O.K if you're sure the data you've entered is correct.", "Confirmation", MessageBoxButtons.OKCancel);
        }
    }
}
