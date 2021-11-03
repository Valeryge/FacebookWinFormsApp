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
        //private readonly LoginResult k_LoginResult;
        // private readonly User k_LoggedUser;
        private MyFacebookService m_FacebookService = new MyFacebookService();

        public LoggedUserForm(LoginResult i_LoginResult)
        {
            //  k_LoginResult = i_LoginResult;
            //k_LoggedUser = i_LoginResult.LoggedInUser;
            m_FacebookService.Init(i_LoginResult);
            this.InitializeComponent();
            this.MyInitializeComponent();
        }

        private void MyInitializeComponent()
        {
            //loadWindowName
            String usersName = m_FacebookService.GetUser().Name;
            this.Text = usersName + "'s FaceBook";

            //loadUsersName
            labelLoggedUserName.Text = usersName;

            //loadProfilePicture
            pictureBoxLoggedUserPicture.Image = m_FacebookService.GetUser().ImageNormal; //TODO: fix size;
            pictureBoxLoggedUserPicture.BringToFront();
            minimizedProfilePicture.Text = m_FacebookService.GetUser().FirstName;
            minimizedProfilePicture.Image = m_FacebookService.GetUser().ImageSmall;

            loadProfile();
        }

        private void loadProfile()
        {
            this.loadAlbums();
            this.loadPosts();
        }

        private void loadAlbums()
        {
            FacebookObjectCollection<Album> albums = m_FacebookService.GetUser().Albums;

            foreach (Album album in albums)
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
            FlowLayoutPanel vBoxWrapper = new FlowLayoutPanel();
            vBoxWrapper.Size = new Size(300, 1000);
            vBoxWrapper.Padding = new Padding(10);
            vBoxWrapper.FlowDirection = FlowDirection.TopDown;
            vBoxWrapper.Location = new Point(800, 100);
            vBoxWrapper.BorderStyle = BorderStyle.FixedSingle;

            FlowLayoutPanel hBoxHeaders = new FlowLayoutPanel();
            hBoxHeaders.FlowDirection = FlowDirection.RightToLeft;
            hBoxHeaders.BorderStyle = BorderStyle.FixedSingle;
            hBoxHeaders.Size = new Size(280, 100);
            hBoxHeaders.Padding = new Padding(10);

            TextBox labelHeaderName = new TextBox();
            labelHeaderName.Text = "Author's Description";

            TextBox labelHeaderTime = new TextBox();
            labelHeaderName.Text = "Time";

            TextBox labelHeaderPicture = new TextBox();
            labelHeaderName.Text = "Album";

            hBoxHeaders.Controls.Add(labelHeaderName);
            hBoxHeaders.Controls.Add(labelHeaderTime);
            hBoxHeaders.Controls.Add(labelHeaderPicture);

            vBoxWrapper.Controls.Add(hBoxHeaders);

            int i = 0;
            FacebookObjectCollection<Post> posts = m_FacebookService.GetUser().Posts;
            foreach (Post post in posts)
            {
                FlowLayoutPanel hBox = new FlowLayoutPanel();
                hBox.FlowDirection = FlowDirection.RightToLeft;
                hBox.Size = new Size(280, 50);
                hBox.Padding = new Padding(10);
                hBox.BorderStyle = BorderStyle.FixedSingle;
                hBox.BackColor = Color.Blue;
                
                // hBox.HorizontalScroll.Enabled = true;
                //only shows one of the uploaded picture, maybe theres an algorithm that allows guessing the next pictures url if such exists.

                //Fake:
                //handle likes
                //handle comments
                string thisPostsPictureUrl = post.PictureURL;
                Label labelPostTime = new Label();
                 labelPostTime.Text = post.CreatedTime.Value.ToString();
                 labelPostTime.Name = "labelPostNum" + i;
                 hBox.Controls.Add(labelPostTime);

                 if (thisPostsPictureUrl != null)
                 {
                    hBox.Size = new Size(280, 150);
                    //handle pictures
                    PictureBox addedPictureBox = new PictureBox();
                    addedPictureBox.Name = "pictureBoxNum " + i;
                     addedPictureBox.Size = new Size(100, 100); //What's the size limit??
                     i += 1;
                     hBox.Controls.Add(addedPictureBox);
                     foundPictures.AddLast(new LinkedListNode<PictureBox>(addedPictureBox));
                     addedPictureBox.Load(thisPostsPictureUrl);
                   
                 }
                 else
                 {
                    PictureBox addedPictureBox = new PictureBox();
                    addedPictureBox.Size = new Size(50, 50);
                }

                 Label labelPost = new Label();
                 if (labelPost != null)
                 {
                     labelPost.Text = post.Message;
                     labelPost.AutoSize = true;
                     labelPost.Name = "labelPostNum" + i;
                     labelPost.BackColor = Color.Aqua;
                     hBox.Controls.Add(labelPost);

                 }
                 vBoxWrapper.Controls.Add(hBox);

            }
            this.Controls.Add(vBoxWrapper);
        }

        private void onButtonTestClicked(object sender, EventArgs e)
        {
            User user = m_FacebookService.GetUser();
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

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
