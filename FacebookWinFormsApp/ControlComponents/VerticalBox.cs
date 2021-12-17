using System.Windows.Forms;

namespace FacebookApp
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
            this.Anchor = AnchorStyles.Top;
        }

        public void Clear()
        {
            base.Controls.Clear();
        }
    }
}
