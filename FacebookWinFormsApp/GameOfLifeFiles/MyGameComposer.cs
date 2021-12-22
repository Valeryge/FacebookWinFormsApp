using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp.GameOfLifeFiles
{
    class MyGameComposer : IGameComposer, IGameCreator
    {
        public IGameBuilder builder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Rows { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Columns { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Image BackGroundImage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public static MyGameComposer getNew() { return new MyGameComposer(); }
  
        public GameOfLifeForm Compose()
        {
            throw new NotImplementedException();
        }

        public static IGameCreator Create()
        {
            throw new NotImplementedException();
        }

        public string InformMissing()
        {
            return builder.InformMissing();
        }

    }
}
