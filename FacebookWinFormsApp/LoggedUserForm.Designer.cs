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
            this.signoutButton = new System.Windows.Forms.ToolStripButton();
            this.minimizedProfilePicture = new System.Windows.Forms.ToolStripLabel();
            this.gameOfLifeButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.albumsLabel = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.notification = new System.Windows.Forms.Button();
            this.pictureBoxCommercial = new System.Windows.Forms.PictureBox();
            this.centralPanelArea = new System.Windows.Forms.Panel();
            this.pictureBoxLoggedUserPicture = new System.Windows.Forms.PictureBox();
            this.textBoxPost = new System.Windows.Forms.RichTextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.toolstrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommercial)).BeginInit();
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
            this.signoutButton,
            this.minimizedProfilePicture,
            this.gameOfLifeButton,
            this.refreshButton});
            this.toolstrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Padding = new System.Windows.Forms.Padding(2);
            this.toolstrip.Size = new System.Drawing.Size(1459, 31);
            this.toolstrip.TabIndex = 14;
            this.toolstrip.Text = "toolStrip1";
            // 
            // facebookLogo
            // 
            this.facebookLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.logo;
            this.facebookLogo.Margin = new System.Windows.Forms.Padding(0);
            this.facebookLogo.Name = "facebookLogo";
            this.facebookLogo.Size = new System.Drawing.Size(20, 27);
            this.facebookLogo.Text = "toolStripLabel1";
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(66, 24);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signoutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.signoutButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signoutButton.Image = ((System.Drawing.Image)(resources.GetObject("signoutButton.Image")));
            this.signoutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(64, 24);
            this.signoutButton.Text = "Signout";
            this.signoutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // minimizedProfilePicture
            // 
            this.minimizedProfilePicture.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizedProfilePicture.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minimizedProfilePicture.Margin = new System.Windows.Forms.Padding(0);
            this.minimizedProfilePicture.Name = "minimizedProfilePicture";
            this.minimizedProfilePicture.Size = new System.Drawing.Size(171, 27);
            this.minimizedProfilePicture.Text = "minimizedProfilePicture";
            this.minimizedProfilePicture.Click += new System.EventHandler(this.minimizedProfilePicture_Click);
            this.minimizedProfilePicture.MouseLeave += new System.EventHandler(this.minimizedProfilePicture_MouseLeave);
            this.minimizedProfilePicture.MouseHover += new System.EventHandler(this.minimizedProfilePicture_MouseHover);
            // 
            // gameOfLifeButton
            // 
            this.gameOfLifeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gameOfLifeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameOfLifeButton.Image = ((System.Drawing.Image)(resources.GetObject("gameOfLifeButton.Image")));
            this.gameOfLifeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameOfLifeButton.Name = "gameOfLifeButton";
            this.gameOfLifeButton.Size = new System.Drawing.Size(98, 24);
            this.gameOfLifeButton.Text = "Game of Life";
            this.gameOfLifeButton.Click += new System.EventHandler(this.gameOfLifeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.refresh;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(24, 24);
            this.refreshButton.Text = "refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(1255, 228);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(52, 17);
            this.infoLabel.TabIndex = 40;
            this.infoLabel.Text = "label1";
            // 
            // aboutLabel
            // 
            this.aboutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.aboutLabel.Location = new System.Drawing.Point(1295, 206);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(61, 17);
            this.aboutLabel.TabIndex = 39;
            this.aboutLabel.Text = "ABOUT";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(62, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Liked Pages";
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(31, 370);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(247, 132);
            this.listBoxLikedPages.TabIndex = 37;
            // 
            // albumsLabel
            // 
            this.albumsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.albumsLabel.AutoSize = true;
            this.albumsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.albumsLabel.Location = new System.Drawing.Point(83, 150);
            this.albumsLabel.Name = "albumsLabel";
            this.albumsLabel.Size = new System.Drawing.Size(60, 17);
            this.albumsLabel.TabIndex = 36;
            this.albumsLabel.Text = "Albums";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(31, 170);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(247, 132);
            this.listBoxAlbums.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(1295, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Friends";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBoxFriends);
            this.panel1.Location = new System.Drawing.Point(1216, 392);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 106);
            this.panel1.TabIndex = 32;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(0, 4);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(224, 100);
            this.listBoxFriends.TabIndex = 3;
            // 
            // notification
            // 
            this.notification.BackColor = System.Drawing.Color.MidnightBlue;
            this.notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notification.Location = new System.Drawing.Point(1206, 612);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(245, 88);
            this.notification.TabIndex = 35;
            this.notification.Text = "notify";
            this.notification.UseVisualStyleBackColor = false;
            this.notification.Visible = false;
            // 
            // pictureBoxCommercial
            // 
            this.pictureBoxCommercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCommercial.Location = new System.Drawing.Point(8, 555);
            this.pictureBoxCommercial.Name = "pictureBoxCommercial";
            this.pictureBoxCommercial.Size = new System.Drawing.Size(188, 153);
            this.pictureBoxCommercial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommercial.TabIndex = 34;
            this.pictureBoxCommercial.TabStop = false;
            // 
            // centralPanelArea
            // 
            this.centralPanelArea.Controls.Add(this.pictureBoxLoggedUserPicture);
            this.centralPanelArea.Controls.Add(this.textBoxPost);
            this.centralPanelArea.Controls.Add(this.buttonPost);
            this.centralPanelArea.Controls.Add(this.labelLoggedUserName);
            this.centralPanelArea.Location = new System.Drawing.Point(433, 37);
            this.centralPanelArea.Name = "centralPanelArea";
            this.centralPanelArea.Size = new System.Drawing.Size(599, 309);
            this.centralPanelArea.TabIndex = 33;
            // 
            // pictureBoxLoggedUserPicture
            // 
            this.pictureBoxLoggedUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLoggedUserPicture.Location = new System.Drawing.Point(195, 2);
            this.pictureBoxLoggedUserPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLoggedUserPicture.Name = "pictureBoxLoggedUserPicture";
            this.pictureBoxLoggedUserPicture.Size = new System.Drawing.Size(180, 164);
            this.pictureBoxLoggedUserPicture.TabIndex = 2;
            this.pictureBoxLoggedUserPicture.TabStop = false;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(71, 206);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(448, 71);
            this.textBoxPost.TabIndex = 11;
            this.textBoxPost.Text = "Enter  post here:";
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPost.Location = new System.Drawing.Point(451, 283);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(68, 23);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = false;
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggedUserName.Location = new System.Drawing.Point(168, 164);
            this.labelLoggedUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(243, 29);
            this.labelLoggedUserName.TabIndex = 19;
            this.labelLoggedUserName.Text = "-Logged user label-";
            this.labelLoggedUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoggedUserForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1459, 745);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.albumsLabel);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.pictureBoxCommercial);
            this.Controls.Add(this.centralPanelArea);
            this.Controls.Add(this.toolstrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoggedUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoggedUserForm_Load);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommercial)).EndInit();
            this.centralPanelArea.ResumeLayout(false);
            this.centralPanelArea.PerformLayout();
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
        private ToolStripButton gameOfLifeButton;
        private Label infoLabel;
        private Label aboutLabel;
        private Label label4;
        private ListBox listBoxLikedPages;
        private Label albumsLabel;
        private ListBox listBoxAlbums;
        private Label label2;
        private Panel panel1;
        private ListBox listBoxFriends;
        private Button notification;
        private PictureBox pictureBoxCommercial;
        private Panel centralPanelArea;
        private PictureBox pictureBoxLoggedUserPicture;
        private RichTextBox textBoxPost;
        private Button buttonPost;
        private Label labelLoggedUserName;
    }
}