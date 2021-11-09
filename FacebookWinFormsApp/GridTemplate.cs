using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class GridTemplate
    {
        private int[,] k_GameMatrix;

        public int[,] GameMatrix
        {
            get => k_GameMatrix;
            set => k_GameMatrix = value;
        }

        public GridTemplate(int[,] i_GameMatrix)
        {
            k_GameMatrix = i_GameMatrix;
        }
    }
}
