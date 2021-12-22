using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApp.GameOfLifeFiles.IBuilder;

namespace FacebookApp.GameOfLifeFiles
{
    internal class MyGameBuilder : IGameBuilder
    {
        GameBoard gameBoard;
        GameEngine gameEngine;
        GameOfLifeForm gameForm;
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Image BackGroundImage { get; set; }
        public bool InformMissing()
        {
            bool finalResult = true;

            bool currentResult = Rows > 0;
            finalResult &= currentResult;
            Console.WriteLine("Rows: " + currentResult);

            currentResult = Columns > 0;
            finalResult &= currentResult;
            Console.WriteLine("Columns: " + currentResult);

            currentResult = BackGroundImage != null;
            finalResult &= currentResult;
            Console.WriteLine("Image: " + currentResult);

            if (finalResult == false)
            {
                Console.WriteLine("There has been an error with the creation");
            }
            return !finalResult;
        }

        public GameBoard BuildBoard()
        {
            return new GameBoard(Rows, Columns); //GameBoard OK!
        }

        public GameEngine BuildEngine(GameBoard i_Board)
        {
            if (gameBoard != null)
            {
                return new GameEngine(gameBoard);
            }
            else
            {
                throw new Exception("Error! Bad gameBoard input");
            }
            
        }

        public GameOfLifeForm BuildForm(GameEngine i_Engine)
        {
            if (gameEngine != null)
            {
                return new GameOfLifeForm(BackGroundImage, i_Engine);
            }
            else
            {
                throw new Exception("Error! Bad gameBoard input");
            }
        }

        public GameOfLifeForm BuildComplexObject()
        {
            if (InformMissing() == false)
            {
                gameBoard = BuildBoard();
                Console.WriteLine("GameBoard: OK");
                gameEngine = BuildEngine(gameBoard);
                Console.WriteLine("GameEngine: OK");
                gameForm = BuildForm(gameEngine);
                Console.WriteLine("GameForm: OK");
                return gameForm;
            }
            else
            {
                throw new Exception("BuildComplexObject - Dysfunctional.");
            }
        }
    }
}
