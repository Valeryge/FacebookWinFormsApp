using FacebookWrapper.ObjectModel;

namespace FacebookApp.GameOfLifeFiles.IBuilder
{
    internal interface IGameCreator
    {
        int Rows { get; set; }
        int Columns { get; set; }
        System.Drawing.Image BackGroundImage { get; set; }

        IImagePickerStrategy ImagePickerStrategy { get; set; }

        bool InformMissing();


    }
   
}
