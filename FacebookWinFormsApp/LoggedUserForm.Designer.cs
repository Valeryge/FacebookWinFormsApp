
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelLoggedUserName = new System.Windows.Forms.Label();
            this.pictureBoxLoggedUserPicture = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.coverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.postsListsBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelLoggedUserName
            // 
            this.labelLoggedUserName.AutoSize = true;
            this.labelLoggedUserName.Location = new System.Drawing.Point(462, 209);
            this.labelLoggedUserName.Name = "labelLoggedUserName";
            this.labelLoggedUserName.Size = new System.Drawing.Size(132, 17);
            this.labelLoggedUserName.TabIndex = 1;
            this.labelLoggedUserName.Text = "-Logged user label-";
            // 
            // pictureBoxLoggedUserPicture
            // 
            this.pictureBoxLoggedUserPicture.Location = new System.Drawing.Point(476, 95);
            this.pictureBoxLoggedUserPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLoggedUserPicture.Name = "pictureBoxLoggedUserPicture";
            this.pictureBoxLoggedUserPicture.Size = new System.Drawing.Size(118, 112);
            this.pictureBoxLoggedUserPicture.TabIndex = 2;
            this.pictureBoxLoggedUserPicture.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(18, 164);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(167, 148);
            this.listBoxAlbums.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBoxAlbums);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(28, 237);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 327);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(799, 258);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 356);
            this.panel3.TabIndex = 6;
            // 
            // coverPhotoPictureBox
            // 
            this.coverPhotoPictureBox.Location = new System.Drawing.Point(0, -1);
            this.coverPhotoPictureBox.Name = "coverPhotoPictureBox";
            this.coverPhotoPictureBox.Size = new System.Drawing.Size(1079, 208);
            this.coverPhotoPictureBox.TabIndex = 7;
            this.coverPhotoPictureBox.TabStop = false;
            // 
            // postsListsBox
            // 
            this.postsListsBox.FormattingEnabled = true;
            this.postsListsBox.ItemHeight = 16;
            this.postsListsBox.Location = new System.Drawing.Point(326, 249);
            this.postsListsBox.Name = "postsListsBox";
            this.postsListsBox.Size = new System.Drawing.Size(440, 436);
            this.postsListsBox.TabIndex = 8;
            // 
            // LoggedUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 749);
            this.Controls.Add(this.postsListsBox);
            this.Controls.Add(this.coverPhotoPictureBox);
            this.Controls.Add(this.labelLoggedUserName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBoxLoggedUserPicture);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoggedUserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoggedUserPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coverPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLoggedUserName;
        private PictureBox pictureBoxLoggedUserPicture;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private Panel panel2;
        private Panel panel3;
        private PictureBox coverPhotoPictureBox;
        private ListBox postsListsBox;
    }
}