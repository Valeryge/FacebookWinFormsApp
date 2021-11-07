using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class SettingsForm : Form
    {
        private LogManager k_LogManager;
        public SettingsForm(LogManager i_LogManager)
        {
            this.k_LogManager = i_LogManager;
            //k_LogManager.ActionsList.Add(new FaceBookAction(DateTime.Now, false, FaceBookAction.ActionType.SETTINGS_CLICKED));
          
            InitializeComponent();
            myInitComponents();
        }
         
        //TODO: condition to if was today show time and write today, otherwise write date.
        private void myInitComponents()
        {
            tableLayoutRecentActions.RowCount = k_LogManager.ActionsList.Count;
            foreach (FaceBookAction fbAction in k_LogManager.ActionsList)
            {
                Label labelTime = new Label();
                labelTime.Text = fbAction.Time.TimeOfDay.ToString();

                Label labelType = new Label();
                labelType.Text = fbAction.Type.ToString();

                Label labelErrorStatus = new Label();
                labelErrorStatus.Text = fbAction.ErrorStatus.ToString();

                tableLayoutRecentActions.Controls.Add(labelTime);
                tableLayoutRecentActions.Controls.Add(labelType);
                tableLayoutRecentActions.Controls.Add(labelErrorStatus);

            }

        }
    }
}
