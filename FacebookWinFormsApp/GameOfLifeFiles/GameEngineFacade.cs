using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    public class GameEngineFacade
    {
        private GameEngine m_Engine;
        public GameBoard GameBoard { get { return m_Engine.GameBoard; } }
        public int Rounds { get { return m_Engine.Rounds; } }

        //assuming engine is good
        internal GameEngineFacade(GameEngine i_Engine) {
            m_Engine = i_Engine;
        }

        public void Update()
        {
            m_Engine.UpdateToNextGeneration();
        }

        public void Restart()
        {
            m_Engine.ClearBoard();
        }

        public bool IsCellFull(int i_RowIndex, int i_ColIndex)
        {
            return m_Engine.GameBoard.GameMatrix[i_RowIndex, i_ColIndex] == true;
        }
    }
}
