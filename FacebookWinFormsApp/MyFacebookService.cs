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

        public MyFacebookService() { }

        public void Init(LoginResult i_Result)
        {
            k_LoginResult = i_Result;
            k_LoggedUser = i_Result.LoggedInUser;
        }

        public User GetUser()
        {
            return k_LoggedUser;
        }

        public FacebookObjectCollection<Album> GetUserAlbums()
        {
            return k_LoggedUser.Albums;
        }

        public FacebookObjectCollection<Post> GetUserPosts()
        {
            return k_LoggedUser.Posts;
        }

        public String GetUserName()
        {
            return k_LoggedUser.Name;
        }

        public Image GetUserProfilePicture()
        {
            return k_LoggedUser.ImageNormal;
        }
    
    }
}
