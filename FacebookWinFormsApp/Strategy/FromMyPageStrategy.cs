using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    class FromMyPageStrategy : IImagePickerStrategy
    {
        public User RequestedUser { get; set; }

        public Image GetImage()
        {
            Random rnd = new Random();
            int r = rnd.Next(RequestedUser.Friends.Count);

            return RequestedUser.Friends[r].ImageLarge;

        }
    }
}
