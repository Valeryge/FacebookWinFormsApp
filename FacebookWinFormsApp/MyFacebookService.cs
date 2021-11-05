using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public class MyFacebookService
    {
        private LoginResult k_LoginResult;
        private User k_LoggedUser;
        private User m_CurrentProfileUser;

        public User LoggedUser
        {
            get { return k_LoggedUser; }
        }
        public User User
        {
            get { return m_CurrentProfileUser; }
            set { m_CurrentProfileUser = value; }
        }

        public MyFacebookService() { }

        public void Init(LoginResult i_Result)
        {
            k_LoginResult = i_Result;
            k_LoggedUser = i_Result.LoggedInUser;
            m_CurrentProfileUser = k_LoggedUser;
        }

        public void InitCurrentProfile(User i_NewUser)
        {
            m_CurrentProfileUser = i_NewUser;
        }
    }
}
