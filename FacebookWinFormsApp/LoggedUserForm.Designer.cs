
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
            this.buttonTest2WithoutDesigner = new System.Windows.Forms.Button();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.pictureBoxLoggedUserPicture = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.postsListsBox = new System.Windows.Forms.ListBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.RichTextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).BeginInit();
            this.panel2.SuspendLayout();
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
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(346, 170);
            this.labelLoggedUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(97, 13);
            this.labelLoggedUserName.TabIndex = 1;
            this.labelLoggedUserName.Text = "-Logged user label-";
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
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(25, 98);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(126, 121);
            this.listBoxAlbums.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBoxAlbums);
            this.panel2.Location = new System.Drawing.Point(21, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 249);
            this.panel2.TabIndex = 5;
            // 
            // postsListsBox
            // 
            this.postsListsBox.FormattingEnabled = true;
            this.postsListsBox.Location = new System.Drawing.Point(244, 327);
            this.postsListsBox.Margin = new System.Windows.Forms.Padding(2);
            this.postsListsBox.Name = "postsListsBox";
            this.postsListsBox.Size = new System.Drawing.Size(331, 134);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // LoggedUserForm
            // 
            this.ClientSize = new System.Drawing.Size(1126, 609);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLoggedUserName;
        private PictureBox pictureBoxLoggedUserPicture;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private Panel panel2;
        private ListBox postsListsBox;
        private Button buttonPost;
        private Button buttonTest2WithoutDesigner;
        private RichTextBox textBoxPost;
        private Button buttonTest;
        private Label label1;
    }
}