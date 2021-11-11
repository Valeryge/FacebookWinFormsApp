using System.Windows.Forms;
using Size = System.Drawing.Size;

namespace BasicFacebookFeatures.ControlComponents
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
