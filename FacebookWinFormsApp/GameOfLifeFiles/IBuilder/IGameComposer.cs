using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    interface IGameComposer : IGameCreator
    {
        IGameBuilder builder { get; set; }
        GameOfLifeForm Compose();
    }
}
