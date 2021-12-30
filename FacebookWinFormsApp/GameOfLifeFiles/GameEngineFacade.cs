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
        public int Rounds { get { return m_Engine.Rounds; } }

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

        public void ChangeCell(int i_Row, int i_Col)
        {
            m_Engine.GameBoard.ChangeValue(i_Row, i_Col);
        }

        public int GetCols()
        {
            return m_Engine.GameBoard.Cols;
        }

        public int GetRows()
        {
            return m_Engine.GameBoard.Rows;
        }
    }
}
