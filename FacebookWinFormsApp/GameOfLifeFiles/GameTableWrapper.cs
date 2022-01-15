using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookApp.GameOfLifeFiles
{
    internal class GameTableWrapper : IGameTimerObserver
    {
        public TableLayoutPanel Table { get; }
        public GameBoard m_GameBoard;
        
        public GameTableWrapper(TableLayoutPanel i_TabelLayout, GameBoard i_Board)
        {
            Table = i_TabelLayout;
            m_GameBoard = i_Board;   
        }

        public void Update()
        {
                for (int rowIndex = 0; rowIndex < m_GameBoard.Rows; ++rowIndex)
                {
                    for (int colIndex = 0; colIndex < m_GameBoard.Cols; ++colIndex)
                    {
                        if (m_GameBoard.GameMatrix[rowIndex, colIndex])
                        {
                            Table.GetControlFromPosition(colIndex, rowIndex).Visible = false;
                        }
                        else
                        {
                            Table.GetControlFromPosition(colIndex, rowIndex).Visible = true;
                        }
                    }
                }
        }
    }
}
