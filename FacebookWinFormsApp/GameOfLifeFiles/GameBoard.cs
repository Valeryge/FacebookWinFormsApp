namespace BasicFacebookFeatures.GameOfLifeFiles
{
    public class GameBoard
    {
        private bool[,] k_GameMatrix;
        private readonly int k_Rows;
        private readonly int k_Cols;

        public int Rows
        {
            get { return k_Rows; }
        }

        public int Cols
        {
            get { return k_Rows; }
        }

        public GameBoard(int i_Rows, int i_Cols)
        {
            k_Rows = i_Rows;
            k_Cols = i_Cols;
            k_GameMatrix = new bool[i_Rows, i_Cols];
            CleanBoard();
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
