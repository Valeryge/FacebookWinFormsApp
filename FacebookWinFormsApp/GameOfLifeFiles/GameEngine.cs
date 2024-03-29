﻿
using System;

namespace FacebookApp.GameOfLifeFiles
{
    public class GameEngine
    {
        private int m_Rounds;
        public int Rounds
        {
            get => m_Rounds;
            private set => m_Rounds = value;
        }

        private GameBoard m_GameBoard;
        public GameBoard GameBoard => m_GameBoard;

       public GameEngine(GameBoard i_GameBoard)
        {
            Rounds = 0;
            m_GameBoard = i_GameBoard;
        }

        /*public GameEngine(int i_GameRows, int i_GameColumns) : this(new GameBoard(i_GameRows, i_GameColumns)) { }

        private void AttemptAwakeRandomControls()
        {
            for (int i = 0; i < m_GameBoard.Rows; ++i)
            {
                for (int j = 0; j < m_GameBoard.Cols; ++j)
                {
                    Random rand = new Random();
                    int num = rand.Next(1, 8);
                    if (num == 1)
                    {
                        m_GameBoard.GameMatrix[i, j] = true;
                    }
                }
            }
        }*/

        private int getNeighbors(int i_RowIndex, int i_ColumnIndex, bool[,] i_Tmp)
        {
            int numOfAliveNeighbors = 0;

            for (int rowIndex = i_RowIndex - 1; rowIndex < i_RowIndex + 2; rowIndex++)
            {
                for (int columnIndex = i_ColumnIndex - 1; columnIndex < i_ColumnIndex + 2; columnIndex++)
                {
                    if (!(i_RowIndex == rowIndex && i_ColumnIndex == columnIndex))//if not the caller
                    {
                        if (!((rowIndex < 0 || columnIndex < 0) || (rowIndex >= m_GameBoard.Rows || columnIndex >= m_GameBoard.Cols)))
                        {
                            if (i_Tmp[rowIndex, columnIndex] == true)
                            {
                                numOfAliveNeighbors++;
                            }
                        }
                    }
                }
            }

            return numOfAliveNeighbors; //always counts itself
        }

        public void UpdateToNextGeneration()
        {
            bool[,] tmp = new bool[m_GameBoard.Rows, m_GameBoard.Cols];
            for (int i = 0; i < m_GameBoard.Rows; ++i)
            {
                for (int j = 0; j < m_GameBoard.Cols; ++j)
                {
                    tmp[i, j] = m_GameBoard.GameMatrix[i, j];
                }
            }

            for (int rowIndex = 0; rowIndex < m_GameBoard.Rows; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < m_GameBoard.Cols; columnIndex++)
                {
                    int numOfAliveNeighbors = getNeighbors(rowIndex, columnIndex, tmp);

                    if (m_GameBoard.GameMatrix[rowIndex, columnIndex] == true)
                    {
                        if (numOfAliveNeighbors < 2)
                        {
                            m_GameBoard.GameMatrix[rowIndex, columnIndex] = false;
                        }

                        if (numOfAliveNeighbors > 3)
                        {
                            m_GameBoard.GameMatrix[rowIndex, columnIndex] = false;
                        }
                    }
                    else
                    {
                        if (numOfAliveNeighbors == 3)
                        {
                            m_GameBoard.GameMatrix[rowIndex, columnIndex] = true;
                        }
                    }
                }
            }

            m_Rounds++;
        }

        public void ClearBoard()
        {
            m_GameBoard.CleanBoard();
            Rounds = 0;
        }
    }
}
