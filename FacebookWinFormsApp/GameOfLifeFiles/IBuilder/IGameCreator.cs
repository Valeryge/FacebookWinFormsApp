using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    internal interface IGameCreator : IPrivateCtor
    {
        int Rows { get; set; }
        int Columns { get; set; }
        System.Drawing.Image BackGroundImage { get; set; }
        bool InformMissing();


    }
    public enum InformationMissing { eMissingRows, eMissingCols, eMissingDrawing}
}
