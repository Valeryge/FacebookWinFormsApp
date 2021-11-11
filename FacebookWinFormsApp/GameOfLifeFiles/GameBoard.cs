namespace BasicFacebookFeatures.GameOfLifeFiles
{
    public class GameBoard
    {
        private bool[,] k_GameMatrix;
        private readonly int k_Rows;
        private readonly int k_Cols;

        public GameBoard(int i_Rows, int i_Cols)
        {
            k_Rows = i_Rows;
            k_Cols = i_Cols;
            k_GameMatrix = new bool[i_Rows, i_Cols];
            CleanBoard();
            k_GameMatrix[3, 3] = true;
            k_GameMatrix[3, 4] = true;
            k_GameMatrix[3, 5] = true;
        }

        public bool[,] GameMatrix => k_GameMatrix;

        public void CleanBoard()
        {
            for (int rowIndex = 0; rowIndex < k_Rows; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < k_Cols; columnIndex++)
                {
                    k_GameMatrix[rowIndex, columnIndex] = false;
                }
            }
        }
        public void ChangeValue(int i_PositionRow, int i_PositionColumn)
        {
            k_GameMatrix[i_PositionRow, i_PositionColumn] =
                k_GameMatrix[i_PositionRow, i_PositionColumn] != true;
        }
    }
}
