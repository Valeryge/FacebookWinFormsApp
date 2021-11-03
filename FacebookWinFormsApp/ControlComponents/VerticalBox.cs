using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class VerticalBox : TableLayoutPanel
    {
        public VerticalBox(int i_RowsCount)
        {
            
            this.Padding = new Padding(10);
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            this.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            this.ColumnCount = 1;
            this.AutoScroll = true;
            this.RowCount = i_RowsCount;
            this.AutoSize = true;
        }
    }
}
