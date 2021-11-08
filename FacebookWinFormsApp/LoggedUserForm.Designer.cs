using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class LoggedUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedUserForm));
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.facebookLogo = new System.Windows.Forms.ToolStripLabel();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.signoutButton = new System.Windows.Forms.ToolStripButton();
            this.minimizedProfilePicture = new System.Windows.Forms.ToolStripLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBoxLatestActions = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlMainApp = new System.Windows.Forms.TabControl();
            this.tabInitPage = new System.Windows.Forms.TabPage();
            this.tableLayountPanelLibrary = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.centralPanelArea = new System.Windows.Forms.Panel();
            this.pictureBoxLoggedUserPicture = new System.Windows.Forms.PictureBox();
            this.textBoxPost = new System.Windows.Forms.RichTextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolstrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControlMainApp.SuspendLayout();
            this.tabInitPage.SuspendLayout();
            this.tableLayountPanelLibrary.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.centralPanelArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolstrip
            // 
            this.toolstrip.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolstrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolstrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facebookLogo,
            this.settingsButton,
            this.refreshButton,
            this.signoutButton,
            this.minimizedProfilePicture});
            this.toolstrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Padding = new System.Windows.Forms.Padding(2);
            this.toolstrip.Size = new System.Drawing.Size(1185, 30);
            this.toolstrip.TabIndex = 14;
            this.toolstrip.Text = "toolStrip1";
            // 
            // facebookLogo
            // 
            this.facebookLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.logo;
            this.facebookLogo.Margin = new System.Windows.Forms.Padding(0);
            this.facebookLogo.Name = "facebookLogo";
            this.facebookLogo.Size = new System.Drawing.Size(20, 26);
            this.facebookLogo.Text = "toolStripLabel1";
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(66, 23);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(60, 23);
            this.refreshButton.Text = "refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.signoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signoutButton.Image = ((System.Drawing.Image)(resources.GetObject("signoutButton.Image")));
            this.signoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(64, 23);
            this.signoutButton.Text = "Signout";
            this.signoutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // minimizedProfilePicture
            // 
            this.minimizedProfilePicture.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizedProfilePicture.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minimizedProfilePicture.Margin = new System.Windows.Forms.Padding(0);
            this.minimizedProfilePicture.Name = "minimizedProfilePicture";
            this.minimizedProfilePicture.Size = new System.Drawing.Size(171, 26);
            this.minimizedProfilePicture.Text = "minimizedProfilePicture";
            this.minimizedProfilePicture.Click += new System.EventHandler(this.minimizedProfilePicture_Click);
            this.minimizedProfilePicture.MouseLeave += new System.EventHandler(this.minimizedProfilePicture_MouseLeave);
            this.minimizedProfilePicture.MouseHover += new System.EventHandler(this.minimizedProfilePicture_MouseHover);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.listBoxLatestActions);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(53, 569);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 160);
            this.panel4.TabIndex = 19;
            // 
            // listBoxLatestActions
            // 
            this.listBoxLatestActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxLatestActions.FormattingEnabled = true;
            this.listBoxLatestActions.Location = new System.Drawing.Point(0, 63);
            this.listBoxLatestActions.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLatestActions.Name = "listBoxLatestActions";
            this.listBoxLatestActions.Size = new System.Drawing.Size(734, 95);
            this.listBoxLatestActions.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "My Latest On-App Actions";
            // 
            // tabControlMainApp
            // 
            this.tabControlMainApp.Controls.Add(this.tabInitPage);
            this.tabControlMainApp.Controls.Add(this.tabPage2);
            this.tabControlMainApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainApp.Location = new System.Drawing.Point(0, 30);
            this.tabControlMainApp.Name = "tabControlMainApp";
            this.tabControlMainApp.SelectedIndex = 0;
            this.tabControlMainApp.Size = new System.Drawing.Size(1185, 632);
            this.tabControlMainApp.TabIndex = 20;
            // 
            // tabInitPage
            // 
            this.tabInitPage.Controls.Add(this.tableLayountPanelLibrary);
            this.tabInitPage.Controls.Add(this.labelLoggedUserName);
            this.tabInitPage.Controls.Add(this.centralPanelArea);
            this.tabInitPage.Location = new System.Drawing.Point(4, 22);
            this.tabInitPage.Name = "tabInitPage";
            this.tabInitPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabInitPage.Size = new System.Drawing.Size(1177, 606);
            this.tabInitPage.TabIndex = 0;
            this.tabInitPage.Text = "tabPage1";
            this.tabInitPage.UseVisualStyleBackColor = true;
            // 
            // tableLayountPanelLibrary
            // 
            this.tableLayountPanelLibrary.AutoScroll = true;
            this.tableLayountPanelLibrary.ColumnCount = 2;
            this.tableLayountPanelLibrary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayountPanelLibrary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayountPanelLibrary.Controls.Add(this.panel2, 0, 0);
            this.tableLayountPanelLibrary.Controls.Add(this.panel1, 1, 0);
            this.tableLayountPanelLibrary.Controls.Add(this.panel3, 1, 1);
            this.tableLayountPanelLibrary.Location = new System.Drawing.Point(8, 6);
            this.tableLayountPanelLibrary.Name = "tableLayountPanelLibrary";
            this.tableLayountPanelLibrary.RowCount = 2;
            this.tableLayountPanelLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.56772F));
            this.tableLayountPanelLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.43228F));
            this.tableLayountPanelLibrary.Size = new System.Drawing.Size(326, 347);
            this.tableLayountPanelLibrary.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBoxAlbums);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 160);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Albums:";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(0, 50);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(157, 108);
            this.listBoxAlbums.TabIndex = 3;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxFriends);
            this.panel1.Location = new System.Drawing.Point(165, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 160);
            this.panel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "My Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(0, 50);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(157, 108);
            this.listBoxFriends.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.listBoxLikedPages);
            this.panel3.Location = new System.Drawing.Point(165, 173);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 159);
            this.panel3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "My Liked Pages";
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(0, 49);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(157, 108);
            this.listBoxLikedPages.TabIndex = 3;
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(496, 143);
            this.labelLoggedUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(97, 13);
            this.labelLoggedUserName.TabIndex = 19;
            this.labelLoggedUserName.Text = "-Logged user label-";
            // 
            // centralPanelArea
            // 
            this.centralPanelArea.Controls.Add(this.pictureBoxLoggedUserPicture);
            this.centralPanelArea.Controls.Add(this.textBoxPost);
            this.centralPanelArea.Controls.Add(this.buttonPost);
            this.centralPanelArea.Location = new System.Drawing.Point(340, 9);
            this.centralPanelArea.Name = "centralPanelArea";
            this.centralPanelArea.Size = new System.Drawing.Size(406, 344);
            this.centralPanelArea.TabIndex = 21;
            // 
            // pictureBoxLoggedUserPicture
            // 
            this.pictureBoxLoggedUserPicture.Location = new System.Drawing.Point(161, 40);
            this.pictureBoxLoggedUserPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLoggedUserPicture.Name = "pictureBoxLoggedUserPicture";
            this.pictureBoxLoggedUserPicture.Size = new System.Drawing.Size(88, 91);
            this.pictureBoxLoggedUserPicture.TabIndex = 2;
            this.pictureBoxLoggedUserPicture.TabStop = false;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(45, 189);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(331, 71);
            this.textBoxPost.TabIndex = 11;
            this.textBoxPost.Text = "Enter  post here:";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(45, 266);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(331, 23);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "post Button";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.OnPostButtonClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LoggedUserForm
            // 
            this.ClientSize = new System.Drawing.Size(1185, 662);
            this.Controls.Add(this.tabControlMainApp);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoggedUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControlMainApp.ResumeLayout(false);
            this.tabInitPage.ResumeLayout(false);
            this.tabInitPage.PerformLayout();
            this.tableLayountPanelLibrary.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.centralPanelArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolstrip;
        private ToolStripLabel facebookLogo;
        private ToolStripButton settingsButton;
        private ToolStripButton refreshButton;
        private ToolStripButton signoutButton;
        private ToolStripLabel minimizedProfilePicture;
        private Panel panel4;
        private ListBox listBoxLatestActions;
        private Label label5;
        private TabControl tabControlMainApp;
        private TabPage tabInitPage;
        private TableLayoutPanel tableLayountPanelLibrary;
        private Panel panel2;
        private Label label1;
        private ListBox listBoxAlbums;
        private Panel panel1;
        private Label label2;
        private ListBox listBoxFriends;
        private Panel panel3;
        private Label label3;
        private ListBox listBoxLikedPages;
        private Label labelLoggedUserName;
        private Panel centralPanelArea;
        private PictureBox pictureBoxLoggedUserPicture;
        private RichTextBox textBoxPost;
        private Button buttonPost;
        private TabPage tabPage2;
    }
}