using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using CefSharp.DevTools.Target;

namespace FacebookApp
{
    
    public class MyFacebookService
    {
      //  private Dictionary<User, List<IFaceBookPost>> k_UserPosts;
        public Dictionary<User, List<IFaceBookPost>> UserPosts { get; set; }

        private LogManager k_LogManager;
        private Dictionary<User, List<LocalPost>> k_LocalAddedPosts; //remove when generalized complete
        public Dictionary<User, List<LocalPost>> LocalAddedPosts => k_LocalAddedPosts; //remove when generalized complete
        public LogManager LogManager
        {
            get => k_LogManager;
            set => k_LogManager = value;
        }

        private User k_LoggedUser;
        private User m_CurrentProfileUser;
        
        
        public MyFacebookService()
        {
            k_LogManager = LogManager.Instance;
            k_LocalAddedPosts = new Dictionary<User, List<LocalPost>>(); //remove when generalized complete
            UserPosts = new Dictionary<User, List<IFaceBookPost>>();
        }

       

        // public class PostsProxy 
        // {
        //     private Collection<Post> userPosts;
        //     private Collection<LocalPost> localUserPosts;
        //
        //     void addPosts(){}
        // }

        public interface IFaceBookPost
        {
            void Create(IFaceBookPost post);
        }
        public class LocalPost  : IFaceBookPost
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

            public void Create(IFaceBookPost post)
            {
                throw new NotImplementedException();
            }

            public class OriginalPostAdapter : IFaceBookPost
            {
                private Post m_OriginalPost;

                public void Create(IFaceBookPost post)
                {
                    throw new NotImplementedException();
                }
            }
        }

        public User LoggedUser => k_LoggedUser;

        public User CurrentProfileUser
        {
            get => m_CurrentProfileUser;
            set => m_CurrentProfileUser = value;
        }

        public class UserWrapper
        {
            public User OriginalUser{ get; set; }
            public UserExtendedData ExtendedData { get; set; }

            public List<IFaceBookPost> getPosts()
            {
                List<IFaceBookPost> list = new List<IFaceBookPost>();
                foreach (IFaceBookPost originalUserPost in OriginalUser.Posts)
                {
                    list.Add(originalUserPost);
                }

                foreach (LocalPost lp  in ExtendedData.extended)
                {
                    list.Add(ExtendedData);
                }

                return list;
            }
        }


        public class UserExtendedData : IFaceBookPost
        {
          public  List<LocalPost> extended = new List<LocalPost>();


          public void Create(IFaceBookPost post)
          {
              throw new NotImplementedException();
          }
        }
        public class ourFbPost
        {
            private Post originalPost; 
            private LocalPost localPost;


            void changeName(string i_NewName)
            {
                base.Name = i_NewName;
            }
        }
        public void Init(LoginResult i_Result)
        {
            k_LoggedUser = i_Result.LoggedInUser;
            m_CurrentProfileUser = k_LoggedUser;


            Post post = new Post();
            k_LoggedUser.Posts.Add(post);

            ourFbPost fp = new ourFbPost();
            fp.Name = "5";
            
            try
            {
                //post.Name = "hello";
                //post.ReFetch(DynamicWrapper.eLoadOptions.Basic);
                //post.ReFetch(DynamicWrapper.eLoadOptions.Full);
                //   post.ReFetch(DynamicWrapper.eLoadOptions.FullWithConnections);
            }
            catch (Exception e)
            {
            //    Console.Write(e.Message);
            }
            

            //Console.WriteLine(post.CreatedTime.ToString());
            LoggedUser.Posts.Add(post);
        }

        public void InitCurrentProfile(User i_NewUser)
        {
            m_CurrentProfileUser = i_NewUser;
        }

        public void AddNewLocalPost(string i_Text)
        {
            LocalPost lp = new LocalPost(i_Text);
            UserPosts [CurrentProfileUser].Add(lp);
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
