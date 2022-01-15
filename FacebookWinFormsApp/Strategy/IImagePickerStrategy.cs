using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    interface IImagePickerStrategy
    {
        Image GetImage(User i_LoggedUser);
    }
}
