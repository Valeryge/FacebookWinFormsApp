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
        private MyFacebookService m_FacebookService = new MyFacebookService();
        private readonly int k_ElementsInPostsList = 3;
        private readonly VerticalBox k_PostsContainer;

        public LoggedUserForm(LoginResult i_LoginResult)
        {
            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.LOGIN_CLICKED].Add(new FaceBookAction(DateTime.Now, false));

            m_FacebookService.Init(i_LoginResult);
            k_PostsContainer = new VerticalBox(m_FacebookService.User.Posts.Count);
            this.InitializeComponent();
            this.myInitializeComponent();
        }

        private void myInitializeComponent()
        {
            this.Controls.Add(k_PostsContainer);
            loadToolbar();
            myRefresh();
        }

        private void myRefresh()
        {
            clearAllData();
            loadProfile();
            loadActions();
        }

        private void loadActions()
        {
            foreach (var actionType in m_FacebookService.LogManager.logCollection.Keys)
            {
                foreach (var singleAction in m_FacebookService.LogManager.logCollection[actionType])
                {
                    listBoxLatestActions.Items.Add("Action Type: " + actionType + " " + singleAction.ToString());
                }
            }
        
        }

        private void loadToolbar()
        {
            minimizedProfilePicture.Text = m_FacebookService.LoggedUser.FirstName;
            minimizedProfilePicture.Image = m_FacebookService.LoggedUser.ImageSmall;
        }

        private void loadProfile()
        {
            //loadWindowName
            String usersName = m_FacebookService.User.Name;
            this.Text = usersName + "'s FaceBook";

            //loadUsersName
            labelLoggedUserName.Text = usersName;

            //loadProfilePicture
            pictureBoxLoggedUserPicture.Image = m_FacebookService.User.ImageNormal; //TODO: fix size;
            pictureBoxLoggedUserPicture.BringToFront();


            k_PostsContainer.MaximumSize = new Size(500, 600);
            k_PostsContainer.Location = new Point(800, tableLayountPanelLibrary.Location.Y);  //better
           
            this.loadAlbums();
            this.loadLikedPages();
            this.loadFriends();
            this.loadPosts();

           
        }

        private void loadLikedPages()
        {
            foreach (Page page in m_FacebookService.User.LikedPages)
            {
                listBoxLikedPages.Items.Add(page);
            }
        }

    private void loadFriends()
        {
            foreach (User friend in m_FacebookService.User.Friends)
            {
                listBoxFriends.Items.Add(friend);
            }
        }


    private void loadPosts()
    {
        // LinkedList<PictureBox> foundPictures = new LinkedList<PictureBox>();
        k_PostsContainer.Clear();
        Label labelPosts = new Label();
        labelPosts.Text = "Posts:";
        k_PostsContainer.Controls.Add(labelPosts);
        k_PostsContainer.Controls.Add(createHeaderHbox());

        //this exists since we cannot post, thus we've created a demo to add as new posts
        if (m_FacebookService.LocalAddedPosts.ContainsKey(m_FacebookService.User))
        {
            addLocalPosts();
          
        }
        
        //this is data returned from fb services
        addRemotePosts();
    }

    private void addRemotePosts()
    {
        int i = 0;
            foreach (Post post in m_FacebookService.User.Posts)
            {
                HorizontalBox hBox = new HorizontalBox(k_ElementsInPostsList);
                hBox.AutoSize = true;
                string thisPostsPictureUrl = post.PictureURL;
                Label labelPostTime = new Label();
                labelPostTime.Text = post.CreatedTime.Value.ToString();
                labelPostTime.Name = "labelPostNum" + i;
                hBox.Controls.Add(labelPostTime);

                if (!(thisPostsPictureUrl == null && post.Name == null))
                {
                    if (thisPostsPictureUrl != null)
                    {
                        //handle pictures
                        PictureBox addedPictureBox = new PictureBox();
                        addedPictureBox.Name = "pictureBoxNum " + i;
                        addedPictureBox.Size = new Size(100, 100);
                        hBox.Controls.Add(addedPictureBox);
                        // foundPictures.AddLast(new LinkedListNode<PictureBox>(addedPictureBox));
                        addedPictureBox.Load(thisPostsPictureUrl);
                    }
                    else
                    {
                        Label labelPicture = new Label();
                        labelPicture.Text = "-No Pictures-";
                        hBox.Controls.Add(labelPicture);
                    }

                    Label labelPost = new Label();
                    if (post.Message != null)
                    {
                        labelPost.AutoSize = true;
                        labelPost.Text = post.Message;
                        labelPost.Name = "labelPostNum" + i;
                    }
                    else
                    {
                        labelPost.Text = "-No description-";
                    }
                    hBox.Controls.Add(labelPost);
                    hBox.Dock = DockStyle.Fill;
                    k_PostsContainer.Controls.Add(hBox);
                }
            }

        }

        private void addLocalPosts()
    {
        foreach (MyFacebookService.LocalPost localAddedPost in m_FacebookService.LocalAddedPosts
            [m_FacebookService.User])
        {
            HorizontalBox box = new HorizontalBox(3);
            Label labelPostTime = new Label();
            labelPostTime.Text = DateTime.Now.ToString();
            box.Controls.Add(labelPostTime);

            Label labelPicture = new Label();
            labelPicture.Text = "-No Pictures-";
            box.Controls.Add(labelPicture);

            Label localPost = new Label();
            localPost.Text = localAddedPost.Message;

            box.Controls.Add(localPost);
            k_PostsContainer.Controls.Add(box);
            
        }
        }

    private HorizontalBox createHeaderHbox()
        {
            HorizontalBox hBoxHeader = new HorizontalBox(k_ElementsInPostsList);

            Label labelTime = new Label();
            labelTime.Text = "Time";
            hBoxHeader.Controls.Add((labelTime));

            Label labelPicture = new Label();
            labelPicture.Text = "Photo";
            hBoxHeader.Controls.Add(labelPicture);

            Label labelName = new Label();
            labelName.Text = "Name/Description";
            hBoxHeader.Controls.Add(labelName);
            
            return hBoxHeader;
        }

        private void loadAlbums()
        {
            FacebookObjectCollection<Album> albums = m_FacebookService.User.Albums;

            foreach (Album album in albums)
            {
                listBoxAlbums.Items.Add(album);
            }

           // listBoxAlbums.SelectedValueChanged += OnSelectionAlbumChanged;
        }

        //TODO: this function should update the pictures to the user
        private void OnSelectionAlbumChanged(object i_Sender, EventArgs i_E)
        {
            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.ALBUM_VIEWED].Add(new FaceBookAction(DateTime.Now, false));

            Album selectedAlbum = (Album)listBoxAlbums.SelectedItem;
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
            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.POST_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
            //   m_FacebookService.User.PostStatus("test1", "test2");
            m_FacebookService.AddNewLocalPost(textBoxPost.Text);
         this.loadPosts();
        }

        private void onButtonTestClicked(object sender, EventArgs e)
        {
            User user = m_FacebookService.User;
            // FacebookObjectCollection<FriendList> thisUsersFL = user.FriendLists;
            FacebookObjectCollection<User> thisUsersFriends = user.Friends; //this also returns 0 friends
            loadLikedPages();
            loadFriends();
            
            FacebookObjectCollection<Post> thisUsersPosts = user.Posts;
            //doesn't show comments on posts
            //doesn't show the likes, there is however a property "LikedBy" with an error
            //show links work
            //shows message/description
            //doesn't show place (maybe has no place?)
            //created time works
            //onlyway to get more data on the posts themselves
            //doesn't show tagged users


            FacebookObjectCollection<Post> thisUsersFeed = user.NewsFeed;
            FacebookObjectCollection<Checkin> thisUsersCheckins = user.Checkins;
            FacebookObjectCollection<Post> thisUsersWallPosts = user.WallPosts;

            //my newsfeed = my checkins = my wallposts = my posts
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.REFRESH_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
            myRefresh();
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.LOGOUT_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
            this.Close();
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItem != null)
            {
                loadNewProfile((User)listBoxFriends.SelectedItem);
            }
        }

        private void loadNewProfile(User i_NewProfile)
        {
            if (i_NewProfile != m_FacebookService.LoggedUser)
            {
                m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.LOADED_DIFFERENT_PROFILE].Add(new FaceBookAction(DateTime.Now, false));
            } 
            m_FacebookService.InitCurrentProfile(i_NewProfile);
            myRefresh();
        }

        private void clearAllData()
        {
            listBoxLatestActions.Items.Clear();
            listBoxAlbums.Items.Clear();
            listBoxFriends.Items.Clear();
            listBoxLikedPages.Items.Clear();
            k_PostsContainer.Clear();
        }

        private void minimizedProfilePicture_Click(object sender, EventArgs e)
        {
            loadNewProfile(m_FacebookService.LoggedUser);
        }

        private void minimizedProfilePicture_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void minimizedProfilePicture_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.SETTINGS_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumForm albumForm = new AlbumForm((Album)listBoxAlbums.SelectedItem);
            albumForm.FormClosed += albumForm_Closed;
            this.Hide();
            albumForm.Show();
        }

        private void albumForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
