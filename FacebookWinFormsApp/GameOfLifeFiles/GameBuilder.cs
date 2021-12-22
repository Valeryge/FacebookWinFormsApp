using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    internal class GameBuilder
    {
        internal bool GameBuilderDataValid = false;

        private GameEngine gameEngine { get; }

        public int Rows { get; set; }
        public int Columns { get; set; }
        // public bool EngineReady { get; set; }
        // public bool UiReady { get; set; }

        GameBuilder()
        {
           

        }

        GameOfLifeForm Build()
        {
            if (!GameBuilderDataValid)
            {
                throw new Exception("Bad input to GameBuilder");
            }
            
            Image gameImage = Image.FromFile("");
            return new GameOfLifeForm(gameImage);
            }

        private bool isValid()
        {
            if (EngineReady && UiReady)
            {
                return true;
            }
            else
            {
                return false;
            }
            //UI complete
            //
            return true;
        }

       
    }
}
