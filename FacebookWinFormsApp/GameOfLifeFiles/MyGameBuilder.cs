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
        private GameEngineFacade EngineControl { get; set; }
        private GameBoard GameBoard { get; set; }
      //  private GameEngine GameEngine { get; set; }
        private GameOfLifeForm GameForm { get; set; }
        public Image BackGroundImage { get; set; }
        public int Rows { get; set; }

        public int Columns { get; set; }
        
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
                Console.WriteLine("Final result: Information Missing!");
            }
            return !finalResult;
        }


        public void BuildBoard()
        {
            if (!(Rows <= 0 || Columns <= 0))
            {
                GameBoard = new GameBoard(Rows, Columns);
                Console.WriteLine("GameBoard: OK");
            }
            else
            {
                throw new Exception("Missing arguments");
            }
        }

        public void BuildEngine()
        {
            if (GameBoard != null)
            {
             //   GameEngine = new GameEngine(Rows, Columns);
             EngineControl = new GameEngineFacade(new GameEngine(GameBoard));
             Console.WriteLine("GameEngine: OK");
            }
            else
            {
                throw new Exception("Error! Bad GameBoard input");
            }
            
        }

        public void BuildForm()
        {
            if (EngineControl != null)
            {
            
                GameForm = new GameOfLifeForm(BackGroundImage, EngineControl);
                Console.WriteLine("GameForm: OK");
                //    GameForm =  new GameOfLifeForm(BackGroundImage, GameEngine);
            }
            else
            {
                throw new Exception("Error! Bad GameBoard input");
            }
        }

        public GameOfLifeForm GetComplexObject()
        {
            if (InformMissing() == false)
            {
                return GameForm;
            }
            throw new Exception("GetComplexObject - Dysfunctional.");
        }
    }
}
