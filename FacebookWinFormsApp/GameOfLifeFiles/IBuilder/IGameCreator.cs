using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    interface IGameCreator : IPrivateCtor
    {
        int Rows { get; set; }
        int Columns { get; set; }
        System.Drawing.Image BackGroundImage { get; set; }
        string InformMissing();
    }
}
