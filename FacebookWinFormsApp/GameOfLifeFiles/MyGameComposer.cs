using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApp.GameOfLifeFiles.IBuilder;

namespace FacebookApp.GameOfLifeFiles
{
    class MyGameComposer : IGameComposer
    {
        public IGameBuilder Builder { get; set; }

    public int Rows
    {
        get => Builder.Rows;
        set => Builder.Rows = value;
    }

    public int Columns { get => Builder.Columns;
        set => Builder.Columns = value; }

    public Image BackGroundImage
    {
        get => Builder.BackGroundImage;
        set=>Builder.BackGroundImage = value;
    }

    public bool InformMissing()
    {
        return Builder.InformMissing();
    }

    public GameOfLifeForm Compose()
    {
        injectDataToBuilder();
        Builder.BuildBoard();
        return Builder.BuildComplexObject();
       
    }

    private void injectDataToBuilder()
    {
        Builder.Rows = this.Rows;
        Builder.Columns = this.Columns;
        Builder.BackGroundImage = this.BackGroundImage;
    }

    public static IGameComposer Create()
    {
        return new MyGameComposer();
    }

    private MyGameComposer()
    {
        Builder = new MyGameBuilder();
        
    }
   
    }
}
