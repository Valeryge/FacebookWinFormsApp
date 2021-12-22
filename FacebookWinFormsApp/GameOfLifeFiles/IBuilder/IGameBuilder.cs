using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    internal interface IGameBuilder : IGameCreator
    {
        GameBoard BuildBoard(); //this should get a photo
        GameEngine BuildEngine(GameBoard i_Board);
        GameOfLifeForm BuildForm(GameEngine i_Engine);
        GameOfLifeForm BuildComplexObject();
    }
}
