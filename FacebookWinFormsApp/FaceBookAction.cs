
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FaceBookAction
    {
       
        private DateTime time;
        private bool errorStatus;
        private string moreData;

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

        public FaceBookAction(DateTime i_Time, bool i_ErrorStatus)
        {
            time = i_Time;
            errorStatus = i_ErrorStatus;
    
        }
        private string k_ErrorsDontExistsText = "No error detected.";

        private string k_ErrorsExistsText = "There was an error! Go speak to Guy.";
        public override string ToString()
        {
            string errorStatusText = errorStatus == false ? k_ErrorsDontExistsText : k_ErrorsExistsText;
            return "Time: " + time.ToString() + " Error-Status: " + errorStatusText;
        }
    }
}

