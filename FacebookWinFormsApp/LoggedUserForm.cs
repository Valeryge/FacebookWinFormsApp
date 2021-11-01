using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.DOM;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LoggedUserForm : Form
    {
        private readonly LoginResult k_LoginResult;
        private readonly User k_LoggedUser;

        public LoggedUserForm(LoginResult i_LoginResult)
        {
            k_LoginResult = i_LoginResult;
            k_LoggedUser = i_LoginResult.LoggedInUser;
            this.InitializeComponent();
            this.MyInitializeComponent();
        }

        private void MyInitializeComponent()
        {
            //loadWindowName
            this.Text = k_LoggedUser.Name + "'s FaceBook";

            //loadUsersName
            labelLoggedUserName.Text = k_LoggedUser.Name;

            //loadProfilePicture
            pictureBoxLoggedUserPicture.Image = k_LoggedUser.ImageNormal; //TODO: fix size;
            pictureBoxLoggedUserPicture.BringToFront();
            
            this.loadAlbums();

            this.loadPosts();
        }

        private void loadAlbums()
        {
            foreach (Album album in k_LoggedUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }
            listBoxAlbums.SelectedValueChanged += OnSelectionAlbumChanged;
        }

        //TODO: this function should update the pictures to the user
        private void OnSelectionAlbumChanged(object i_Sender, EventArgs i_E)
        {
            Album selectedAlbum = (Album)listBoxAlbums.SelectedItem;

            //     pictureBoxLoggedUserPicture.Image = selectedAlbum.CoverPhoto.ImageNormal;

            string DescriptionsOfPhotoList = "";
            foreach (Photo photo in selectedAlbum.Photos)
            {
                if (photo.Name == "")
                {

                }
                else
                {
                    DescriptionsOfPhotoList += photo.Name;
                    DescriptionsOfPhotoList += "\n";
                }

            }

            MessageBox.Show("Exhibition(awkward): \n" + "The names of all the pictures:\n " + DescriptionsOfPhotoList);
        }

        //TODO: Post
        private void OnPostButtonClicked(object sender, EventArgs e)
        {

        }

        //1. we need to try and create an Hbox component - would be really helpful and cool
        //2. we need to create some sort of pane (flowpane seems the best here) and add the Hboxes to our posts.
        //3. we need to make the larger component scrollable
        //maybe a table would do just fine for (1-3)
        //4. hey - we can make a fictive feed out of this feature.
        private void loadPosts()
        {
            LinkedList<PictureBox> foundPictures = new LinkedList<PictureBox>();

            int i = 0;
            foreach (Post post in k_LoggedUser.Posts)
            {
                //only shows one of the uploaded picture, maybe theres an algorithm that allows guessing the next pictures url if such exists.
                string thisPostsPictureUrl = post.PictureURL;

                //real:
                //handle names
                //handle time

                //Fake:
                //handle likes
                //handle comments
                 // Panel panelPost = new Panel();
                 // FlowLayoutPanel panelPost2 = new FlowLayoutPanel();
//
                 Label labelPostTime = new Label();
                 labelPostTime.Text = post.CreatedTime.Value.ToString();
                 labelPostTime.Location = new Point(850 + 50, 100 * i + 10);
                 labelPostTime.Name = "labelPostNum" + i;
//                 // panelPost.Controls.Add(labelPostTime);
// //                panelPost2.Controls.Add(labelPostTime);
                 this.Controls.Add(labelPostTime);
                 //
                 if (thisPostsPictureUrl != null)
                 {
                     //handle pictures
                     PictureBox addedPictureBox = new PictureBox();
                     addedPictureBox.Location = new Point(labelPostTime.Location.X - 110, labelPostTime.Location.Y);
                     addedPictureBox.Name = "pictureBoxNum " + i;
                     addedPictureBox.Size = new Size(100, 100); //What's the size limit??
                     i += 1;
                     this.Controls.Add(addedPictureBox);
                 
                     // panelPost.Controls.Add(addedPictureBox);
                     // panelPost2.Controls.Add(addedPictureBox);

                     foundPictures.AddLast(new LinkedListNode<PictureBox>(addedPictureBox));
                     addedPictureBox.Load(thisPostsPictureUrl);

                 }

            
                 Label labelPost = new Label();
                 if (labelPost != null)
                 {
                     labelPost.Text = post.Message;
                     labelPost.AutoSize = true;
                     labelPost.Location = new Point(foundPictures.Last.Value.Location.X + 220, foundPictures.Last.Value.Location.Y);
                     labelPost.Name = "labelPostNum" + i;
                     labelPost.BackColor = Color.Aqua;
                     // panelPost.Controls.Add(labelPost);
                     // panelPost2.Controls.Add(labelPostTime);
                   
                     this.Controls.Add(labelPost);
                     
                 }


                
                //     panelPost.Location = new Point(500 + 50, 0);
            // //    panelPost.Padding = new Padding(5);
            //     this.Controls.Add(panelPost);
            //     panelPost.Visible = true;
            //
            //     panelPost2.Location = new Point(500 + 50, 0);
            //     panelPost2.Visible = true;
            //     this.Controls.Add(panelPost2);

                
               
            }
        }

        private void onButtonTestClicked(object sender, EventArgs e)
        {
            User user = this.k_LoggedUser;
            // FacebookObjectCollection<FriendList> thisUsersFL = user.FriendLists;
            FacebookObjectCollection<User> thisUsersFriends = user.Friends; //this also returns 0 friends

            FacebookObjectCollection<Post> thisUsersPosts = user.Posts;
            //doesn't show comments on posts
            //doesn't show the likes, there is however a property "LikedBy" with an error
            //show links work
            //shows message/description
            //doesn't show place (maybe has no place?)
            //created time works
            //onlyway to get more data on the posts themselves
            //doesn't show tagged users

            loadPosts();

            FacebookObjectCollection<Post> thisUsersFeed = user.NewsFeed;
            FacebookObjectCollection<Checkin> thisUsersCheckins = user.Checkins;
            FacebookObjectCollection<Post> thisUsersWallPosts = user.WallPosts;
        }


    }
}
