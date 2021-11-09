
namespace BasicFacebookFeatures
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.statisticsTabControl = new System.Windows.Forms.TabControl();
            this.tabRecentActions = new System.Windows.Forms.TabPage();
            this.tableLayoutRecentActions = new System.Windows.Forms.TableLayoutPanel();
            this.tabLogStatistics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.actionTypeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.friendsTab = new System.Windows.Forms.TabControl();
            this.friendsTabPage = new System.Windows.Forms.TabPage();
            this.tabPageLog.SuspendLayout();
            this.statisticsTabControl.SuspendLayout();
            this.tabRecentActions.SuspendLayout();
            this.tabLogStatistics.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeChart)).BeginInit();
            this.friendsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Location = new System.Drawing.Point(4, 25);
            this.tabPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Padding = new System.Windows.Forms.Padding(4);
            this.tabPersonalData.Size = new System.Drawing.Size(1477, 633);
            this.tabPersonalData.TabIndex = 1;
            this.tabPersonalData.Text = "Personal Data";
            this.tabPersonalData.UseVisualStyleBackColor = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.statisticsTabControl);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Size = new System.Drawing.Size(1477, 633);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Activity Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // statisticsTabControl
            // 
            this.statisticsTabControl.Controls.Add(this.tabRecentActions);
            this.statisticsTabControl.Controls.Add(this.tabLogStatistics);
            this.statisticsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsTabControl.Location = new System.Drawing.Point(4, 4);
            this.statisticsTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.statisticsTabControl.Name = "statisticsTabControl";
            this.statisticsTabControl.SelectedIndex = 0;
            this.statisticsTabControl.Size = new System.Drawing.Size(1469, 625);
            this.statisticsTabControl.TabIndex = 0;
            this.statisticsTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.statisticsTab_Selected);
            // 
            // tabRecentActions
            // 
            this.tabRecentActions.Controls.Add(this.tableLayoutRecentActions);
            this.tabRecentActions.Location = new System.Drawing.Point(4, 25);
            this.tabRecentActions.Margin = new System.Windows.Forms.Padding(4);
            this.tabRecentActions.Name = "tabRecentActions";
            this.tabRecentActions.Padding = new System.Windows.Forms.Padding(4);
            this.tabRecentActions.Size = new System.Drawing.Size(1461, 596);
            this.tabRecentActions.TabIndex = 0;
            this.tabRecentActions.Text = "Recent Actions";
            this.tabRecentActions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutRecentActions
            // 
            this.tableLayoutRecentActions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutRecentActions.ColumnCount = 3;
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tableLayoutRecentActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutRecentActions.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutRecentActions.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutRecentActions.Name = "tableLayoutRecentActions";
            this.tableLayoutRecentActions.RowCount = 2;
            this.tableLayoutRecentActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.Size = new System.Drawing.Size(1453, 123);
            this.tableLayoutRecentActions.TabIndex = 0;
            // 
            // tabLogStatistics
            // 
            this.tabLogStatistics.Controls.Add(this.tableLayoutPanel1);
            this.tabLogStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabLogStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tabLogStatistics.Name = "tabLogStatistics";
            this.tabLogStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.tabLogStatistics.Size = new System.Drawing.Size(1461, 596);
            this.tabLogStatistics.TabIndex = 1;
            this.tabLogStatistics.Text = "Log Statistics";
            this.tabLogStatistics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel1.Controls.Add(this.actionTypeChart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1453, 588);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // actionTypeChart
            // 
            chartArea2.Name = "ChartArea1";
            this.actionTypeChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.actionTypeChart.Legends.Add(legend2);
            this.actionTypeChart.Location = new System.Drawing.Point(3, 3);
            this.actionTypeChart.Name = "actionTypeChart";
            series2.ChartArea = "ChartArea1";
            series2.EmptyPointStyle.IsValueShownAsLabel = true;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Activity Type";
            this.actionTypeChart.Series.Add(series2);
            this.actionTypeChart.Size = new System.Drawing.Size(576, 230);
            this.actionTypeChart.TabIndex = 1;
            this.actionTypeChart.Text = "chart1";
            // 
            // friendsTab
            // 
            this.friendsTab.Controls.Add(this.tabPageLog);
            this.friendsTab.Controls.Add(this.tabPersonalData);
            this.friendsTab.Controls.Add(this.friendsTabPage);
            this.friendsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsTab.Location = new System.Drawing.Point(0, 0);
            this.friendsTab.Margin = new System.Windows.Forms.Padding(4);
            this.friendsTab.Name = "friendsTab";
            this.friendsTab.SelectedIndex = 0;
            this.friendsTab.Size = new System.Drawing.Size(1485, 662);
            this.friendsTab.TabIndex = 0;
            this.friendsTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.friendsTab_Selected);
            // 
            // friendsTabPage
            // 
            this.friendsTabPage.Location = new System.Drawing.Point(4, 25);
            this.friendsTabPage.Name = "friendsTabPage";
            this.friendsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.friendsTabPage.Size = new System.Drawing.Size(1477, 633);
            this.friendsTabPage.TabIndex = 2;
            this.friendsTabPage.Text = "Friend Suggestions";
            this.friendsTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 662);
            this.Controls.Add(this.friendsTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.tabPageLog.ResumeLayout(false);
            this.statisticsTabControl.ResumeLayout(false);
            this.tabRecentActions.ResumeLayout(false);
            this.tabLogStatistics.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeChart)).EndInit();
            this.friendsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPersonalData;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabControl statisticsTabControl;
        private System.Windows.Forms.TabPage tabRecentActions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutRecentActions;
        private System.Windows.Forms.TabPage tabLogStatistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart actionTypeChart;
        private System.Windows.Forms.TabControl friendsTab;
        private System.Windows.Forms.TabPage friendsTabPage;
    }
}