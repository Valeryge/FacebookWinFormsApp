using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class GameGrid
    {
        private int[,] k_GameMatrix;
        private int k_GameRows;
        private int k_GameColumns;

        public int[,] GameMatrix
        {
            get => k_GameMatrix;
            set => k_GameMatrix = value;
        }

        public GameGrid(int i_GameRows, int i_GameColumns)
        {
            k_GameRows = i_GameRows;
            k_GameColumns = i_GameColumns;
            k_GameMatrix = new int[i_GameRows, i_GameColumns];
            createEmptyBoard();
        }

        private void createEmptyBoard()
        {
            for (int rowIndex = 0; rowIndex < k_GameRows; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < k_GameColumns; columnIndex++)
                {
                   GameMatrix[rowIndex, columnIndex] = 0;
                }
            }
        }

        public GameGrid(int[,] i_GameMatrix)
        {
            k_GameMatrix = i_GameMatrix;
        }


        // public enum gameBoardModels
        // {
        //     eModel1, eModel2, eModel3
        // }
        // private int[,] initModel2()
        // {
        //     int[,] matrix = new int[k_GameRows, k_GameColumns];
        //     for (int rowIndex = 0; rowIndex < k_GameRows; rowIndex++)
        //     {
        //         for (int columnIndex = 0; columnIndex < k_GameColumns; columnIndex++)
        //         {
        //             k_GameMatrixModel2.GameMatrix[rowIndex, columnIndex] = 0;
        //         }
        //     }
        //
        //     for (int rowIndex = 0; rowIndex < k_GameRows; ++rowIndex)
        //     {
        //         if (1 + rowIndex % 4 != 0)
        //         {
        //             for (int columnIndex = 1; columnIndex < k_GameColumns; columnIndex = columnIndex + 3)
        //             {
        //                 k_GameMatrixModel2.GameMatrix[rowIndex, columnIndex] = 1;
        //             }
        //         }
        //     }
        //
        //     return matrix;
        // }
        //
        // private void initModel1()
        // {
        //     k_GameMatrixModel1.GameMatrix =
        //         new int[,]
        //         {
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        //         };
        // }
    }
}
