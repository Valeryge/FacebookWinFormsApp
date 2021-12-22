using System.Runtime.CompilerServices;

namespace FacebookApp.GameOfLifeFiles
{
    public class GameComposer
    {
        private GameBuilder Gb{
        }
        public int GameSize { get; set; }

        private GameComposer(){}
        static GameComposer Create()
        {
            return new GameComposer();
        }

        public void Compose(){}
    }

 
}