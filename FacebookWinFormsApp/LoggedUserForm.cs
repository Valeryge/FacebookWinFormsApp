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
using System.Threading;

namespace BasicFacebookFeatures
{
    
    public partial class LoggedUserForm : Form
    {
        private readonly MyFacebookService k_FacebookService;
        private readonly int k_ElementsInPostsList = 3;
        private readonly VerticalBox k_PostsContainer;

        public LoggedUserForm(MyFacebookService i_FbService)
        {
            k_FacebookService = i_FbService;
            k_PostsContainer = new VerticalBox(k_FacebookService.User.Posts.Count);
            User thisUser = k_FacebookService.User;
            this.InitializeComponent();
            this.myInitializeComponent();
        }

        private void myInitializeComponent()
        {
            this.Size = new Size(1500, 700);
            this.Controls.Add(k_PostsContainer);
            loadToolbar();
            myRefresh();
        }

        private void initNotifications()
        {
            System.Windows.Forms.Timer notificationTimer = new System.Windows.Forms.Timer();
            notificationTimer.Tick += Timer_Tick;
            notificationTimer.Interval = 40000;
            notificationTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            notification.Text = k_FacebookService.GetNotification();
            notification.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                this.Invoke(new Action(() =>
                {
                    notification.Visible = false;
                }));
            });
        }
        private void myRefresh()
        {
            clearAllData();
            loadProfile();
        }


        private void loadToolbar()
        {
            minimizedProfilePicture.Text = k_FacebookService.LoggedUser.FirstName;
            minimizedProfilePicture.Image = k_FacebookService.LoggedUser.ImageSmall;
        }

        private void loadProfile()
        {
            //loadWindowName
            String usersName = k_FacebookService.User.Name;
            this.Text = usersName + "'s FaceBook";

            //loadUsersName
            labelLoggedUserName.Text = usersName;

            //loadProfilePicture
            pictureBoxLoggedUserPicture.BackgroundImage = k_FacebookService.User.ImageLarge; //TODO: fix size;
            pictureBoxLoggedUserPicture.BringToFront();


            k_PostsContainer.MaximumSize = new Size(700, 500);
            k_PostsContainer.Location = new Point(450, 350);  //better

            this.loadAlbums();
            this.loadLikedPages();
            this.loadFriends();
            this.loadPosts();
            this.loadInfo();
        }

        private void loadInfo()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine(k_FacebookService.User.Hometown != null ? 
                String.Format("From {0}", k_FacebookService.User.Hometown.Name) : "No hometown to show"); 
            text.AppendLine(k_FacebookService.User.Educations != null && k_FacebookService.User.Educations.Length > 0 ? 
                String.Format("Went to {0}", k_FacebookService.User.Educations[0].School.Name) : "No schools to show"); 
            text.AppendLine(k_FacebookService.User.Birthday != null ? 
                String.Format("Born on {0}", k_FacebookService.User.Birthday) : "No birthday to show");
            infoLabel.Text = text.ToString();
            
        }

        private void loadLikedPages()
        {
            foreach (Page page in k_FacebookService.User.LikedPages)
            {
                listBoxLikedPages.Items.Add(page);
            }
        }

        private void loadFriends()
        {
            foreach (User friend in k_FacebookService.User.Friends)
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

           // this exists since we cannot post(creating a new post is possible, but properties are readonly)
           // Thus we've created a demo to add as new posts
             if (k_FacebookService.LocalAddedPosts.ContainsKey(k_FacebookService.User))
             {
                 addLocalPosts();
             }

            //this is data returned from fb services
            addRemotePosts();
        }

        private void addRemotePosts()
        {
            int i = 0;
            foreach (Post post in k_FacebookService.User.Posts)
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
            foreach (MyFacebookService.LocalPost localAddedPost in k_FacebookService.LocalAddedPosts
                [k_FacebookService.User])
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

                Post post = new Post();
                
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
            FacebookObjectCollection<Album> albums = k_FacebookService.User.Albums;

            foreach (Album album in albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            // listBoxAlbums.SelectedValueChanged += OnSelectionAlbumChanged;
        }

        //TODO: Post
        private void OnPostButtonClicked(object sender, EventArgs e)
        {
            k_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.POST_CLICKED].Add(new FaceBookAction(FaceBookAction.ActionType.POST_CLICKED));
            k_FacebookService.AddNewLocalPost(textBoxPost.Text);
            this.loadPosts();
        }
        
        private void refreshButton_Click(object sender, EventArgs e)
        {
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.ActionType.REFRESH_CLICKED));
            myRefresh();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.ActionType.LOGOUT_CLICKED));
            this.Close();
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItem != null)
            {
                loadNewProfile((User)listBoxFriends.SelectedItem);
                k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.ActionType.LOADED_DIFFERENT_PROFILE));
            }
        }

        private void loadNewProfile(User i_NewProfile)
        {
            k_FacebookService.InitCurrentProfile(i_NewProfile);
            myRefresh();
        }

        private void clearAllData()
        {
            listBoxAlbums.Items.Clear();
            listBoxFriends.Items.Clear();
            listBoxLikedPages.Items.Clear();
            k_PostsContainer.Clear();
        }

        private void minimizedProfilePicture_Click(object sender, EventArgs e)
        {
            loadNewProfile(k_FacebookService.LoggedUser);
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
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.ActionType.SETTINGS_CLICKED));
            SettingsForm settingsFrom = new SettingsForm(k_FacebookService);
            settingsFrom.FormClosed += settingsForm_Closed;
            this.Hide();
            settingsFrom.Show();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAlbumsWindow();
        }

        private void fetchAlbumsWindow()
        {
            AlbumForm albumForm = new AlbumForm((Album)listBoxAlbums.SelectedItem);
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.ActionType.ALBUM_VIEWED));
            albumForm.FormClosed += albumForm_Closed;
            this.Hide();
            albumForm.Show();
           
        }

        private void settingsForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
        private void albumForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void LoggedUserForm_Load(object sender, EventArgs e)
        {
            initNotifications();
            initCommercials();
        }

        private void initCommercials()
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += showCommercial;
            timer1.Interval = 10000;
            timer1.Start();
          //  showCommercial();
        }

        // private void Timer1_Tick(object sender, EventArgs e)
        // {
        //     showCommercial();
        // }

        private void showCommercial(object sender, EventArgs e)
        {
            string runningPath = System.AppDomain.CurrentDomain.BaseDirectory;
            List<string> files = new List<string>(Directory.GetFiles(String.Format("{0}Resources/Commercials/", Path.GetFullPath(Path.Combine(runningPath, @"..\..\..\")))));
            string File = files.OrderBy(s => Guid.NewGuid()).First();
            pictureBoxCommercial.Load(File);
        }

        private void gameOfLifeButton_Click(object sender, EventArgs e)
        {
            k_FacebookService.LogManager.logCollection[FaceBookAction.ActionType.POST_CLICKED].Add(new FaceBookAction(FaceBookAction.ActionType.PLAYING_GAME_OF_LIFE)); //TODO: maybe can update some value to the user, same for every event
            GameOfLifeForm gameForm = new GameOfLifeForm(k_FacebookService);
            this.Hide();
            gameForm.FormClosed += GameForm_FormClosed;
            gameForm.Show();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
