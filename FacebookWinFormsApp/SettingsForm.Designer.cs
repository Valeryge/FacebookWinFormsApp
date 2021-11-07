
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statisticsTab = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRecentActions = new System.Windows.Forms.TabPage();
            this.tableLayoutRecentActions = new System.Windows.Forms.TableLayoutPanel();
            this.tabLogStatistics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.statisticsTabPage = new System.Windows.Forms.TabPage();
            this.actionTypeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statisticsTab.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRecentActions.SuspendLayout();
            this.tabLogStatistics.SuspendLayout();
            this.statisticsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.tabPageLog);
            this.statisticsTab.Controls.Add(this.tabPersonalData);
            this.statisticsTab.Controls.Add(this.statisticsTabPage);
            this.statisticsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsTab.Location = new System.Drawing.Point(0, 0);
            this.statisticsTab.Margin = new System.Windows.Forms.Padding(4);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.SelectedIndex = 0;
            this.statisticsTab.Size = new System.Drawing.Size(1067, 554);
            this.statisticsTab.TabIndex = 0;
            this.statisticsTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.statisticsTab_Selected);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.tabControl1);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Size = new System.Drawing.Size(1059, 525);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Activity Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRecentActions);
            this.tabControl1.Controls.Add(this.tabLogStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRecentActions
            // 
            this.tabRecentActions.Controls.Add(this.tableLayoutRecentActions);
            this.tabRecentActions.Location = new System.Drawing.Point(4, 25);
            this.tabRecentActions.Margin = new System.Windows.Forms.Padding(4);
            this.tabRecentActions.Name = "tabRecentActions";
            this.tabRecentActions.Padding = new System.Windows.Forms.Padding(4);
            this.tabRecentActions.Size = new System.Drawing.Size(1043, 488);
            this.tabRecentActions.TabIndex = 0;
            this.tabRecentActions.Text = "Recent Actions";
            this.tabRecentActions.UseVisualStyleBackColor = true;
            // 
            // tableLayoutRecentActions
            // 
            this.tableLayoutRecentActions.ColumnCount = 3;
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayoutRecentActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutRecentActions.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutRecentActions.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutRecentActions.Name = "tableLayoutRecentActions";
            this.tableLayoutRecentActions.RowCount = 2;
            this.tableLayoutRecentActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.Size = new System.Drawing.Size(1035, 123);
            this.tableLayoutRecentActions.TabIndex = 0;
            // 
            // tabLogStatistics
            // 
            this.tabLogStatistics.Controls.Add(this.tableLayoutPanel1);
            this.tabLogStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabLogStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.tabLogStatistics.Name = "tabLogStatistics";
            this.tabLogStatistics.Padding = new System.Windows.Forms.Padding(4);
            this.tabLogStatistics.Size = new System.Drawing.Size(1043, 488);
            this.tabLogStatistics.TabIndex = 1;
            this.tabLogStatistics.Text = "Log Statistics";
            this.tabLogStatistics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Location = new System.Drawing.Point(4, 25);
            this.tabPersonalData.Margin = new System.Windows.Forms.Padding(4);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Padding = new System.Windows.Forms.Padding(4);
            this.tabPersonalData.Size = new System.Drawing.Size(1059, 525);
            this.tabPersonalData.TabIndex = 1;
            this.tabPersonalData.Text = "Personal Data";
            this.tabPersonalData.UseVisualStyleBackColor = true;
            // 
            // statisticsTabPage
            // 
            this.statisticsTabPage.Controls.Add(this.actionTypeChart);
            this.statisticsTabPage.Location = new System.Drawing.Point(4, 25);
            this.statisticsTabPage.Name = "statisticsTabPage";
            this.statisticsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTabPage.Size = new System.Drawing.Size(1059, 525);
            this.statisticsTabPage.TabIndex = 2;
            this.statisticsTabPage.Text = "Statistics";
            this.statisticsTabPage.UseVisualStyleBackColor = true;
            // 
            // actionTypeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.actionTypeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.actionTypeChart.Legends.Add(legend1);
            this.actionTypeChart.Location = new System.Drawing.Point(33, 23);
            this.actionTypeChart.Name = "actionTypeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Activity Type";
            this.actionTypeChart.Series.Add(series1);
            this.actionTypeChart.Size = new System.Drawing.Size(554, 319);
            this.actionTypeChart.TabIndex = 0;
            this.actionTypeChart.Text = "chart1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statisticsTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.statisticsTab.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabRecentActions.ResumeLayout(false);
            this.tabLogStatistics.ResumeLayout(false);
            this.statisticsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionTypeChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl statisticsTab;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRecentActions;
        private System.Windows.Forms.TabPage tabLogStatistics;
        private System.Windows.Forms.TabPage tabPersonalData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutRecentActions;
        private System.Windows.Forms.TabPage statisticsTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart actionTypeChart;
    }
}