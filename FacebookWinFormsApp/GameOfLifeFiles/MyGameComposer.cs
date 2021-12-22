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
    private TextWriter output = Console.Out;
    public IGameBuilder Builder { get; set; }
    public int Rows { get; set; }
    public int Columns { get; set; }
    public Image BackGroundImage { get; set; }

    public bool InformMissing()
    {
        return Builder.InformMissing();
    }

    public GameOfLifeForm Compose()
    {
        injectDataToBuilder();
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
