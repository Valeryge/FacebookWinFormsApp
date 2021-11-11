using System;

namespace BasicFacebookFeatures
{
    public class FaceBookAction
    {
        private readonly eActionType k_Type;
        public eActionType Type => k_Type;
        public DateTime Time => k_Time;
        public bool ErrorStatus => k_ErrorStatus;
        private readonly DateTime k_Time;
        private readonly bool k_ErrorStatus;
        public enum eActionType
        {
            LogoutClicked,
            LoginClicked,
            PostClicked,
            SettingClicked,
            LoadedDifferentProfile,
            AlbumViewed,
            RefreshClicked,
            PlayingGameOfLife
        }

        public FaceBookAction(eActionType i_Type, bool i_ErrorStatus = false)
        {
            k_Type = i_Type;
            k_Time = DateTime.Now;
            k_ErrorStatus = i_ErrorStatus;
        }

        private readonly string k_ErrorsDontExistsText = "No error detected.";
        private readonly string k_ErrorsExistsText = "There was an error! Go speak to Guy.";
        public override string ToString()
        {
            string errorStatusText = k_ErrorStatus == false ? k_ErrorsDontExistsText : k_ErrorsExistsText;
            return "Type: " + k_Type + " Time: " + k_Time.ToString() + " Error-Status: " + errorStatusText;
        }
    }
}

