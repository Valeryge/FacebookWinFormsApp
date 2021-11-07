
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FaceBookAction
    {
        readonly private ActionType k_Type;

        public ActionType Type => k_Type;

        public DateTime Time => k_Time;

        public bool ErrorStatus => k_ErrorStatus;

        public string MoreData
        {
            get => m_MoreData;
            set => m_MoreData = value;
        }

        readonly private DateTime k_Time;
        readonly private bool k_ErrorStatus;
        private string m_MoreData;

        //TODO: Change names by format
        public enum ActionType
        {
            LOGOUT_CLICKED,
            LOGIN_CLICKED,
            POST_CLICKED,
            SETTINGS_CLICKED,
            LOADED_DIFFERENT_PROFILE,
            ALBUM_VIEWED,
            REFRESH_CLICKED
        }

        public FaceBookAction(DateTime i_Time, bool i_ErrorStatus, ActionType i_Type)
        {
            k_Type = i_Type;
            k_Time = i_Time;
            k_ErrorStatus = i_ErrorStatus;
    
        }
        private string k_ErrorsDontExistsText = "No error detected.";

        private string k_ErrorsExistsText = "There was an error! Go speak to Guy.";
        public override string ToString()
        {
            string errorStatusText = k_ErrorStatus == false ? k_ErrorsDontExistsText : k_ErrorsExistsText;
            return "Type: " + k_Type + " Time: " + k_Time.ToString() + " Error-Status: " + errorStatusText;
        }
    }
}

