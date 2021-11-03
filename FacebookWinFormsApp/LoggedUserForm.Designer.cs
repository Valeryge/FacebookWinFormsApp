
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
            this.buttonTest2WithoutDesigner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.postsListsBox = new System.Windows.Forms.ListBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.RichTextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.minimizedProfilePicture = new System.Windows.Forms.ToolStripLabel();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.signoutButton = new System.Windows.Forms.ToolStripButton();
            this.facebookLogo = new System.Windows.Forms.ToolStripLabel();
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoggedUserPicture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.toolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTest2WithoutDesigner
            // 
            this.buttonTest2WithoutDesigner.Location = new System.Drawing.Point(500, 287);
            this.buttonTest2WithoutDesigner.Name = "buttonTest2WithoutDesigner";
            this.buttonTest2WithoutDesigner.Size = new System.Drawing.Size(75, 23);
            this.buttonTest2WithoutDesigner.TabIndex = 9;
            this.buttonTest2WithoutDesigner.Text = "button test 2";
            this.buttonTest2WithoutDesigner.UseVisualStyleBackColor = true;
            this.buttonTest2WithoutDesigner.Click += new System.EventHandler(this.OnPostButtonClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(346, 170);
            this.labelLoggedUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(132, 17);
            this.labelLoggedUserName.TabIndex = 1;
            this.labelLoggedUserName.Text = "-Logged user label-";
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(14, 133);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(126, 116);
            this.listBoxAlbums.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBoxAlbums);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(21, 193);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 266);
            this.panel2.TabIndex = 5;
            // 
            // postsListsBox
            // 
            this.postsListsBox.FormattingEnabled = true;
            this.postsListsBox.ItemHeight = 16;
            this.postsListsBox.Location = new System.Drawing.Point(244, 327);
            this.postsListsBox.Margin = new System.Windows.Forms.Padding(2);
            this.postsListsBox.Name = "postsListsBox";
            this.postsListsBox.Size = new System.Drawing.Size(331, 212);
            this.postsListsBox.TabIndex = 8;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(244, 287);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "post Button";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.OnPostButtonClicked);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(244, 210);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(331, 71);
            this.textBoxPost.TabIndex = 11;
            this.textBoxPost.Text = "";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(87, 488);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 12;
            this.buttonTest.Text = "Test!";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.onButtonTestClicked);
            // 
            // minimizedProfilePicture
            // 
            this.minimizedProfilePicture.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizedProfilePicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizedProfilePicture.Margin = new System.Windows.Forms.Padding(0);
            this.minimizedProfilePicture.Name = "minimizedProfilePicture";
            this.minimizedProfilePicture.Size = new System.Drawing.Size(204, 30);
            this.minimizedProfilePicture.Text = "minimizedProfilePicture";
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
            this.toolstrip.Size = new System.Drawing.Size(1133, 34);
            this.toolstrip.TabIndex = 14;
            this.toolstrip.Text = "toolStrip1";
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(80, 27);
            this.settingsButton.Text = "Settings";
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(70, 27);
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
            this.signoutButton.Size = new System.Drawing.Size(77, 27);
            this.signoutButton.Text = "Signout";
            this.signoutButton.Click += new System.EventHandler(this.signoutButton_Click);
            // 
            // facebookLogo
            // 
            this.facebookLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facebookLogo.Image = global::BasicFacebookFeatures.Properties.Resources.logo;
            this.facebookLogo.Margin = new System.Windows.Forms.Padding(0);
            this.facebookLogo.Name = "facebookLogo";
            this.facebookLogo.Size = new System.Drawing.Size(20, 30);
            this.facebookLogo.Text = "toolStripLabel1";
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.Location = new System.Drawing.Point(24, 518);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(187, 79);
            this.pictureBoxTest.TabIndex = 13;
            this.pictureBoxTest.TabStop = false;
            // 
            // pictureBoxLoggedUserPicture
            // 
            this.pictureBoxLoggedUserPicture.Location = new System.Drawing.Point(357, 77);
            this.pictureBoxLoggedUserPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLoggedUserPicture.Name = "pictureBoxLoggedUserPicture";
            this.pictureBoxLoggedUserPicture.Size = new System.Drawing.Size(88, 91);
            this.pictureBoxLoggedUserPicture.TabIndex = 2;
            this.pictureBoxLoggedUserPicture.TabStop = false;
            // 
            // LoggedUserForm
            // 
            this.ClientSize = new System.Drawing.Size(1133, 618);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.pictureBoxTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.postsListsBox);
            this.Controls.Add(this.labelLoggedUserName);
            this.Controls.Add(this.pictureBoxLoggedUserPicture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonTest2WithoutDesigner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoggedUserForm";
            this.panel2.ResumeLayout(false);
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLoggedUserName;
        private PictureBox pictureBoxLoggedUserPicture;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private Panel panel2;
        private ListBox postsListsBox;
        private Button buttonPost;
        private Button buttonTest2WithoutDesigner;
        private RichTextBox textBoxPost;
        private Button buttonTest;
        private PictureBox pictureBoxTest;
        private ToolStripButton signoutButton;
        private ToolStripButton settingsButton;
        private ToolStripButton refreshButton;
        private ToolStripLabel minimizedProfilePicture;
        private ToolStrip toolstrip;
        private ToolStripLabel facebookLogo;
    }
}