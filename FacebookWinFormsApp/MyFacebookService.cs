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

        public LoginResult LoginResult
        {
            get => k_LoginResult;
            set => k_LoginResult = value;
        }

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

        public FacebookObjectCollection<User> GetFriendsOfFriends()
        {
            FacebookObjectCollection<User> potential = new FacebookObjectCollection<User>();

            foreach (User friend in k_LoggedUser.Friends)
            {
                foreach (User friendOfFriend in friend.Friends)
                {
                    if (k_LoggedUser.Friends.Where(user => user.Id == friendOfFriend.Id).Count() == 0) {
                        potential.Add(friendOfFriend);
                    }
                }
            }

            return potential;
        }

        public FacebookObjectCollection<User> GetFriendSuggestions()
        {
            FacebookObjectCollection<User> bestPotential = GetFriendsOfFriends();

            foreach (User friend in bestPotential)
            {
                if (!isStudiedInSameSchool(friend))
                {
                    bestPotential.Remove(friend);
                } else
                {
                    if (!isFromSameTown(friend)) {
                        bestPotential.Remove(friend);
                    } else
                    {
                        if (k_LoggedUser.Id == friend.Id)
                        {
                            bestPotential.Remove(friend);
                        }
                    }
                }
            }

            return bestPotential;
        }

        public bool isStudiedInSameSchool(User i_OtherUser)
        {
            bool result = false;

            if (i_OtherUser.Educations != null && k_LoggedUser.Educations != null)
            {
                result = i_OtherUser.Educations.Intersect(k_LoggedUser.Educations).Any();
            }

            return result;
        }


        //TODO: Check also current city?
        public bool isFromSameTown(User i_User)
        {
            return i_User.Hometown == k_LoggedUser.Hometown;
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
