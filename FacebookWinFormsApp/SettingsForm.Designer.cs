
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
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRecentActions = new System.Windows.Forms.TabPage();
            this.tabLogStatistics = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPersonalData = new System.Windows.Forms.TabPage();
            this.tableLayoutRecentActions = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlSettings.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRecentActions.SuspendLayout();
            this.tabLogStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageLog);
            this.tabControlSettings.Controls.Add(this.tabPersonalData);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(800, 450);
            this.tabControlSettings.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.tabControl1);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(792, 424);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "Activity Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRecentActions);
            this.tabControl1.Controls.Add(this.tabLogStatistics);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRecentActions
            // 
            this.tabRecentActions.Controls.Add(this.tableLayoutRecentActions);
            this.tabRecentActions.Location = new System.Drawing.Point(4, 22);
            this.tabRecentActions.Name = "tabRecentActions";
            this.tabRecentActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecentActions.Size = new System.Drawing.Size(778, 392);
            this.tabRecentActions.TabIndex = 0;
            this.tabRecentActions.Text = "Recent Actions";
            this.tabRecentActions.UseVisualStyleBackColor = true;
            // 
            // tabLogStatistics
            // 
            this.tabLogStatistics.Controls.Add(this.tableLayoutPanel1);
            this.tabLogStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabLogStatistics.Name = "tabLogStatistics";
            this.tabLogStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogStatistics.Size = new System.Drawing.Size(778, 392);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 386);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPersonalData
            // 
            this.tabPersonalData.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalData.Name = "tabPersonalData";
            this.tabPersonalData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalData.Size = new System.Drawing.Size(792, 424);
            this.tabPersonalData.TabIndex = 1;
            this.tabPersonalData.Text = "Personal Data";
            this.tabPersonalData.UseVisualStyleBackColor = true;
            // 
            // tableLayoutRecentActions
            // 
            this.tableLayoutRecentActions.ColumnCount = 3;
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutRecentActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutRecentActions.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutRecentActions.Name = "tableLayoutRecentActions";
            this.tableLayoutRecentActions.RowCount = 2;
            this.tableLayoutRecentActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutRecentActions.Size = new System.Drawing.Size(772, 100);
            this.tableLayoutRecentActions.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSettings);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabRecentActions.ResumeLayout(false);
            this.tabLogStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRecentActions;
        private System.Windows.Forms.TabPage tabLogStatistics;
        private System.Windows.Forms.TabPage tabPersonalData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutRecentActions;
    }
}