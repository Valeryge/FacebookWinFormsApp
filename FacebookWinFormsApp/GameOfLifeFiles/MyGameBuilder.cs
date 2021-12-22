using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    class MyGameBuilder : IGameBuilder
    {
        GameBoard gameBoard;
        GameEngine gameEngine;
        GameOfLifeForm gameForm;

        public int Rows { get; set; }
        public int Columns { get; set; }

        public GameOfLifeForm Build()
        {
            throw new NotImplementedException();
        }

        public void BuildBoard()
        {
            throw new NotImplementedException();
        }

        public void BuildEngine()
        {
            throw new NotImplementedException();
        }

        public void BuildForm()
        {
            throw new NotImplementedException();
        }
    }
}
