using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class GameEngine
    {
        private GridTemplate m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed;

        public GridTemplate TemplateCurrentlyBeingUsed
        {
            get => m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed;
            set => m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed = value;
        }

        public int GameRows => k_GameRows;

        public int GameColumns => k_GameColumns;

        private readonly int k_GameRows;
        private readonly int k_GameColumns;

        public GameEngine(int i_GameRows, int i_GameColumns, int[,] i_GameMatrixModel)
        {
            k_GameRows = i_GameRows;
            k_GameColumns = i_GameColumns;
            m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed = new GridTemplate(i_GameMatrixModel);
        }

        public int GetNeighbors(int i_RowIndex, int i_ColumnIndex, int[,] tmp)
        {
            int numOfAliveNeighbors = 0;
            for (int rowIndex = i_RowIndex - 1; rowIndex < i_RowIndex + 2; rowIndex++)
            {
                for (int columnIndex = i_ColumnIndex - 1; columnIndex < i_ColumnIndex + 2; columnIndex++)
                {
                    if (!(i_RowIndex == rowIndex && i_ColumnIndex == columnIndex))//if not the caller
                    {
                        if (!((rowIndex < 0 || columnIndex < 0) || (rowIndex >= k_GameRows || columnIndex >= k_GameColumns)))
                        {
                            if (tmp[rowIndex, columnIndex] == 1)
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

            int[,] tmp = new int[k_GameRows, k_GameColumns];
            for (int i = 0; i < k_GameRows; ++i)
            {
                for (int j = 0; j < k_GameColumns; ++j)
                {
                    tmp[i, j] = m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed.GameMatrix[i, j];
                }
            }


            for (int rowIndex = 0; rowIndex < k_GameRows; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < k_GameColumns; columnIndex++)
                {
                    int numOfAliveNeighbors = GetNeighbors(rowIndex, columnIndex, tmp);

                    if (m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed.GameMatrix[rowIndex, columnIndex] == 1)
                    {
                        if (numOfAliveNeighbors < 2)
                        {
                            m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed.GameMatrix[rowIndex, columnIndex] = 0;
                        }

                        if (numOfAliveNeighbors > 3)
                        {
                            m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed.GameMatrix[rowIndex, columnIndex] = 0;
                        }
                    }
                    else
                    {
                        if (numOfAliveNeighbors == 3)
                        {
                            m_TemplateCurrentlyBeingUsedCurrentlyBeingUsed.GameMatrix[rowIndex, columnIndex] = 1;
                        }
                    }
                }
            }
        }

    }
}
