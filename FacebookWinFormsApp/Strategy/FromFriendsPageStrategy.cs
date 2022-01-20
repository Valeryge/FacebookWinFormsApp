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
        public User RequestedUser { get; set; }
        public Image GetImage()
        {
            Random rnd = new Random();
            int albumIndex = rnd.Next(RequestedUser.Albums.Count);
            int photoIndex = rnd.Next(RequestedUser.Albums[albumIndex].Photos.Count);

            return RequestedUser.Albums[albumIndex].Photos[photoIndex].ImageNormal;
        }
    
    }
}
