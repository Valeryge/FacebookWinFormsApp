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
        private MyFacebookService m_FacebookService;
        private readonly int k_ElementsInPostsList = 3;
        private readonly VerticalBox k_PostsContainer;

        public LoggedUserForm(MyFacebookService i_FbService)
        {
            m_FacebookService = i_FbService;
            //m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.LOGIN_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
          

            k_PostsContainer = new VerticalBox(m_FacebookService.User.Posts.Count);
            this.InitializeComponent();
            this.myInitializeComponent();
        }

        private void myInitializeComponent()
        {
            this.Size = new Size(1200, 700);
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
            // foreach (var actionType in m_FacebookService.LogManager.logCollection.Keys)
            // {
            //     foreach (var singleAction in m_FacebookService.LogManager.logCollection[actionType])
            //     {
            //         listBoxLatestActions.Items.Add("Action Type: " + actionType + " " + singleAction.ToString());
            //     }
            // }

            foreach (FaceBookAction action in m_FacebookService.LogManager.ActionsList)
            {
                listBoxLatestActions.Items.Add(action.ToString());
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


    //TODO: condition to if was today show time and write today, otherwise write date.
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

  
     
        //TODO: Post
        private void OnPostButtonClicked(object sender, EventArgs e)
        {
            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.POST_CLICKED].Add(new FaceBookAction(DateTime.Now, false, FaceBookAction.ActionType.POST_CLICKED));
            //m_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(DateTime.Now, false));
            //   m_FacebookService.User.PostStatus("test1", "test2");
            m_FacebookService.AddNewLocalPost(textBoxPost.Text);
         this.loadPosts();
        }

    

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.REFRESH_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
            m_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(DateTime.Now, false, FaceBookAction.ActionType.REFRESH_CLICKED));
            myRefresh();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            // m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.LOGOUT_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
            m_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(DateTime.Now, false, FaceBookAction.ActionType.LOGOUT_CLICKED));
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
                m_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(DateTime.Now, false, FaceBookAction.ActionType.LOADED_DIFFERENT_PROFILE));
            }
        }

        private void loadNewProfile(User i_NewProfile)
        {
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
            //            m_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.SETTINGS_CLICKED].Add(new FaceBookAction(DateTime.Now, false));
            m_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(DateTime.Now, false, FaceBookAction.ActionType.SETTINGS_CLICKED));
            SettingsForm settingsFrom = new SettingsForm(m_FacebookService.LogManager);
            settingsFrom.FormClosed += settingsForm_Closed;
            this.Hide();
            settingsFrom.Show();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumForm albumForm = new AlbumForm((Album)listBoxAlbums.SelectedItem);
            m_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(DateTime.Now, false, FaceBookAction.ActionType.ALBUM_VIEWED));
            // albumForm.FormClosed += albumForm_Closed;
            // this.Hide();
            // albumForm.Show();
            TabPage tp = new TabPage();
            tp.Name = "test";
            foreach (Control control in albumForm.Controls)
            {
                tp.Controls.Add(control);
            }
            tabControlMainApp.TabPages.Add(tp);
        }

        private void settingsForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void albumForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
