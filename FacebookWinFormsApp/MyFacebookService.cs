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


        private LogManager k_LogManager;

        public LogManager LogManager
        {
            get => k_LogManager;
            set => k_LogManager = value;
        }

        private Dictionary<User, List<LocalPost>> k_LocalAddedPosts;
        private LoginResult k_LoginResult;
        private User k_LoggedUser;
        private User m_CurrentProfileUser;
        

        public Dictionary<User, List<LocalPost>> LocalAddedPosts
        {
            get => k_LocalAddedPosts;
            set => k_LocalAddedPosts = value;
        }

        public MyFacebookService()
        {
            k_LogManager = new LogManager();
            k_LocalAddedPosts = new Dictionary<User, List<LocalPost>>();
        }
        public class LocalPost
        {
            private string k_Message;

            public string Message
            {
                get => k_Message;
                set => k_Message = value;
            }

            public LocalPost(string i_Message)
            {
                k_Message = i_Message;
            }
        }
        public User LoggedUser
        {
            get { return k_LoggedUser; }
        }
        public User User
        {
            get { return m_CurrentProfileUser; }
            set { m_CurrentProfileUser = value; }
        }

       

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


        public LocalPost AddNewLocalPost(string i_Text)
        {
            LocalPost lp = new LocalPost(i_Text);
            if (!this.LocalAddedPosts.ContainsKey(User))
            {
                this.LocalAddedPosts.Add(User,new List<LocalPost>());
            }
            this.LocalAddedPosts[User].Add(lp);
            return lp;
        }
    }
}
