using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace BasicFacebookFeatures
{
    
    public class MyFacebookService
    {
        private LogManager k_LogManager;
        private Dictionary<User, List<LocalPost>> k_LocalAddedPosts;

        public LogManager LogManager
        {
            get => k_LogManager;
            set => k_LogManager = value;
        }

        private User k_LoggedUser;
        private User m_CurrentProfileUser;
        public Dictionary<User, List<LocalPost>> LocalAddedPosts => k_LocalAddedPosts;

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

        public User LoggedUser => k_LoggedUser;

        public User CurrentProfileUser
        {
            get => m_CurrentProfileUser;
            set => m_CurrentProfileUser = value;
        }

        public void Init(LoginResult i_Result)
        {
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

            if (!LocalAddedPosts.ContainsKey(CurrentProfileUser))
            {
                LocalAddedPosts.Add(CurrentProfileUser,new List<LocalPost>());
            }

            LocalAddedPosts[CurrentProfileUser].Add(lp);

            return lp;
        }

        public String GetNotification()
        {
            Random rnd = new Random();
            int r = rnd.Next(5);

            List<string> activities = new List<string> { "liked your photo", "commented on your photo", "liked your post", "liked your album",
            "commented on your photo" };

            return String.Format("{0} {1}!", getRandomFriendName(), activities[r]);
        }

        private String getRandomFriendName()
        {
            Random rnd = new Random();
            int r = rnd.Next(k_LoggedUser.Friends.Count);

            return k_LoggedUser.Friends[r].Name;
        }

        public Image GetRandomFriendImage()
        {
            Random rnd = new Random();
            int r = rnd.Next(k_LoggedUser.Friends.Count);

            return k_LoggedUser.Friends[r].ImageLarge;
        }
    }
}
