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
        public Image GetImage(User i_LoggedUser)
        {
            Random rnd = new Random();
            int albumIndex = rnd.Next(i_LoggedUser.Albums.Count);
            int photoIndex = rnd.Next(i_LoggedUser.Albums[albumIndex].Photos.Count);

            return i_LoggedUser.Albums[albumIndex].Photos[photoIndex].ImageNormal;
        }
    }
}
