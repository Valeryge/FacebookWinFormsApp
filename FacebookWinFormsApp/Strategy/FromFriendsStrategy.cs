using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApp { 
    public class FromFriendsStrategy : IImagePickerStrategy
    {
        public Image GetImage(User i_LoggedUser) { 
            Random rnd = new Random();
            int r = rnd.Next(i_LoggedUser.Friends.Count);

            return i_LoggedUser.Friends[r].ImageLarge;
        }
    }
}
