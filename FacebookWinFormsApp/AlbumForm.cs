using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace FacebookApp
{
    public partial class AlbumForm : Form
    {
        public AlbumForm(Album i_Album)
        {
            InitializeComponent();
            new Thread(() => myInitializeComponent(i_Album)).Start();
        }

        private void myInitializeComponent(Album i_Album)
        {
            this.Padding = new Padding(10);
            int currentX = 40;
            int currentY = 50;
            albumNameLabel.Invoke(new Action(() => albumNameLabel.Text = i_Album.Name));
            this.Size = new Size(1200, 700);
            this.AutoScroll = true;

            foreach (Photo photo in i_Album.Photos)
            {
                PictureBox pictureBox = new PictureBox();

                pictureBox.Image = photo.ImageNormal;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Size = new Size(300, 300);
                pictureBox.Location = new Point(currentX, currentY);
                new ToolTip().SetToolTip(pictureBox, buildPhotoDescription(photo));

                if (currentX + 300 > this.Width)
                {
                    currentX = 40;
                    currentY += 300;
                }
                else
                {
                    currentX += 300;
                }

                this.Controls.Add(pictureBox);
            }
        }

        private String buildPhotoDescription(Photo i_Photo)
        {
            StringBuilder description = new StringBuilder();

            if (!string.IsNullOrEmpty(i_Photo.Name))
            {
                description.AppendLine("Name: " + i_Photo.Name);
            }
            else
            {
                description.AppendLine("Unnamed photo");
            }

            description.AppendLine("Date: " + i_Photo.CreatedTime);
            description.AppendLine("Liked by: " + getStringOfUsers(i_Photo.LikedBy));

            return description.ToString();
        }

        private String getStringOfUsers(FacebookObjectCollection<User> i_Users)
        {
            StringBuilder names = new StringBuilder();

            foreach(User user in i_Users)
            {
                names.Append(user.Name + ", ");
            }

            return names.ToString();
        }

        private void backButton_Click(object i_Sender, EventArgs i_E)
        {
            this.Close();
        }
    }
}
