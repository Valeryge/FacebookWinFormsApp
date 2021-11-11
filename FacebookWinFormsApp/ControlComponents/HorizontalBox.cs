using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Debugger;
using CefSharp.DevTools.SystemInfo;
using Size = System.Drawing.Size;

namespace BasicFacebookFeatures
{
    public class HorizontalBox : TableLayoutPanel
    {
        public HorizontalBox(int i_ColumnCount)
        {
            this.Padding = new Padding(10);
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            this.MaximumSize = new Size(600, 600);
            this.AutoSize = true;
            this.AutoScroll = true;
            this.RowCount = 1;
            this.ColumnCount = i_ColumnCount;
        }

    }
}
