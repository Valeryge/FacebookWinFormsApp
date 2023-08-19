using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;
using FacebookApp.ControlComponents;
using FacebookApp.GameOfLifeFiles;
using FacebookApp.GameOfLifeFiles.IBuilder;
using Timer = System.Windows.Forms.Timer;

namespace FacebookApp
{
    public partial class UserForm : Form
    {
        public UserForm(MyFacebookService i_FbService)
        {
            k_FacebookService = i_FbService;
            k_PostsContainer = new VerticalBox(k_FacebookService.CurrentProfileUser.Posts.Count);
           r_CommercialsTimer = new Timer();
            r_NotificationTimer = new Timer();
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
            r_NotificationTimer.Tick += Timer_Tick;
            r_NotificationTimer.Interval = 10000;
            r_NotificationTimer.Start();
        }

        private void Timer_Tick(object i_Sender, EventArgs i_E)
        {
            //notification.Text = k_FacebookService.GetNotification(); 
            notification.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                if (this.Visible)
                {
                    this.Invoke(new Action(() =>
                    {
                        notification.Visible = false;
                    }));
                }
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
            String usersName = k_FacebookService.CurrentProfileUser.Name;
            this.Text = usersName + "'s FaceBook";
            //loadUsersName
            labelLoggedUserName.Text = usersName;
            //loadProfilePicture
            pictureBoxLoggedUserPicture.BackgroundImage = k_FacebookService.CurrentProfileUser.ImageLarge; 
            pictureBoxLoggedUserPicture.BringToFront();
            k_PostsContainer.MaximumSize = new Size(700, 500);
            k_PostsContainer.Location = new Point(450,450);  //better
            this.loadAlbums();
            this.loadLikedPages();
            this.loadFriends();
            this.loadPosts();
            this.loadInfo();
        }

        private void loadInfo()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine(k_FacebookService.CurrentProfileUser.Hometown != null ? 
                String.Format("From {0}", k_FacebookService.CurrentProfileUser.Hometown.Name) : "No hometown to show"); 
            text.AppendLine(k_FacebookService.CurrentProfileUser.Educations != null && k_FacebookService.CurrentProfileUser.Educations.Length > 0 ? 
                String.Format("Went to {0}", k_FacebookService.CurrentProfileUser.Educations[0].School.Name) : "No schools to show"); 
            text.AppendLine(k_FacebookService.CurrentProfileUser.Birthday != null ? 
                String.Format("Born on {0}", k_FacebookService.CurrentProfileUser.Birthday) : "No birthday to show");
            infoLabel.Text = text.ToString();
        }

        private void loadLikedPages()
        {
            pageBindingSource.DataSource = k_FacebookService.CurrentProfileUser.LikedPages;
          //  listBoxLikedPages.DataSource = pageBindingSource;
           // listBoxLikedPages.DisplayMember = Name;
            //foreach (Page page in k_FacebookService.CurrentProfileUser.LikedPages)
            //{
            //    listBoxLikedPages.Items.Add(page);
            //}
        }

        private void loadFriends()
        {
            foreach (User friend in k_FacebookService.CurrentProfileUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
            }
        }

        private void loadPosts()
        {
            k_PostsContainer.Clear();
            Label labelPosts = new Label();
            labelPosts.Text = "Posts:";
            k_PostsContainer.Controls.Add(labelPosts);
            k_PostsContainer.Controls.Add(createHeaderHbox());
           // this exists since we cannot post(creating a new post is possible, but properties are readonly)
           // Thus we've created a demo to add as new posts
             if (k_FacebookService.LocalAddedPosts.ContainsKey(k_FacebookService.CurrentProfileUser))
             {
                 addLocalPosts();
             }

             //this is data returned from fb services
            addRemotePosts();
        }

        private void addRemotePosts()
        {
            int i = 0;

            foreach (Post post in k_FacebookService.CurrentProfileUser.Posts)
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
                [k_FacebookService.CurrentProfileUser])
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
            FacebookObjectCollection<Album> albums = k_FacebookService.CurrentProfileUser.Albums;

            foreach (Album album in albums)
            {
                listBoxAlbums.Items.Add(album);
            }

        }

        private void OnPostButtonClicked(object i_Sender, EventArgs i_E)
        {
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.eActionType.PostClicked));
            k_FacebookService.AddNewLocalPost(textBoxPost.Text);
            Post newPost = new Post();
            this.loadPosts();
        }
        
        private void refreshButton_Click(object i_Sender, EventArgs i_E)
        {
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.eActionType.RefreshClicked));
            myRefresh();
        }

        private void signOutButton_Click(object i_Sender, EventArgs i_E)
        {
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.eActionType.LogoutClicked));
            this.Close();
        }

        private void listBoxFriends_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            if (listBoxFriends.SelectedItem != null)
            {
                loadNewProfile((User)listBoxFriends.SelectedItem);
                k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.eActionType.LoadedDifferentProfile));
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
         //   listBoxLikedPages.Items.Clear();
            k_PostsContainer.Clear();
        }

        private void minimizedProfilePicture_Click(object i_Sender, EventArgs i_E)
        {
            loadNewProfile(k_FacebookService.LoggedUser);
        }

        private void minimizedProfilePicture_MouseHover(object i_Sender, EventArgs i_E)
        {
            this.Cursor = Cursors.Hand;
        }

        private void minimizedProfilePicture_MouseLeave(object i_Sender, EventArgs i_E)
        {
            this.Cursor = Cursors.Default;
        }

        private void settingsButton_Click(object i_Sender, EventArgs i_E)
        {
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.eActionType.SettingClicked));
            SettingsForm settingsFrom = new SettingsForm(k_FacebookService);
            settingsFrom.FormClosed += settingsForm_Closed;
            this.Hide();
            settingsFrom.Show();
        }

        private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            fetchAlbumsWindow();
        }

        private void fetchAlbumsWindow()
        {
            AlbumForm albumForm = new AlbumForm((Album)listBoxAlbums.SelectedItem);
            k_FacebookService.LogManager.ActionsList.Add(new FaceBookAction(FaceBookAction.eActionType.AlbumViewed));
            albumForm.FormClosed += albumForm_Closed;
            this.Hide();
            albumForm.Show();
           
        }

        private void settingsForm_Closed(object i_Sender, EventArgs i_E)
        {
            this.Show();
        }
        private void albumForm_Closed(object i_Sender, EventArgs i_E)
        {
            this.Show();
        }

        private void LoggedUserForm_Load(object i_Sender, EventArgs i_E)
        {
            initNotifications();
       //     initCommercials();
        }

        private void initCommercials()
        {
            r_CommercialsTimer.Tick += commercialTimer_Tick;
            r_CommercialsTimer.Interval = 10000;
            r_CommercialsTimer.Start();
            showCommercial();
        }

         private void commercialTimer_Tick(object i_Sender, EventArgs i_E)
         {
             showCommercial();
         }

        private void showCommercial()
        {
            string runningPath = System.AppDomain.CurrentDomain.BaseDirectory;
             List<string> files = new List<string>(Directory.GetFiles(string.Format(@"{0}Resources/Commercials/", Path.GetFullPath(Path.Combine(runningPath, @"..\..\..\")))));
             string File = files.OrderBy(s => Guid.NewGuid()).First();
             pictureBoxCommercial.Load(File);
        }

        private void gameOfLifeButton_Click(object sender, EventArgs e)
        {
            k_FacebookService.LogManager.ActionsList.Add(
                new FaceBookAction(FaceBookAction.eActionType.PlayingGameOfLife));

            try
            {
              
                IGameComposer myGameComposer = MyGameComposer.Create();
                injectToGameComposer(myGameComposer);
                GameOfLifeForm gameForm = myGameComposer.Compose();
                gameForm.FormClosed += GameForm_FormClosed;
                this.Hide();
                gameForm.Show();
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void setImagePickerStrategy(IGameComposer myGameComposer)
        {
            if (k_FacebookService.CurrentProfileUser == k_FacebookService.LoggedUser)
            {
                myGameComposer.ImagePickerStrategy = new FromMyPageStrategy();
                //      m_ImagePicker = new FromMyPageStrategy();
            } else
            {
                myGameComposer.ImagePickerStrategy = new FromFriendsStrategy();
          //      m_ImagePicker = new FromFriendsStrategy();
            }
            myGameComposer.ImagePickerStrategy.RequestedUser = k_FacebookService.CurrentProfileUser;
        }

        private void injectToGameComposer(IGameComposer myGameComposer)
        {
            myGameComposer.Rows = 12;
            myGameComposer.Columns = myGameComposer.Rows;
            setImagePickerStrategy(myGameComposer);
            // myGameComposer.BackGroundImage = m_ImagePicker.GetImage(k_FacebookService.LoggedUser);
        }

        private void GameForm_FormClosed(object i_Sender, EventArgs i_E)
        {
            this.Show();
        }

        private void LoggedUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            removeTimers();
        }

        private void removeTimers()
        {
            r_CommercialsTimer.Stop();
            r_NotificationTimer.Stop();
        }

        private readonly MyFacebookService k_FacebookService;
        private readonly int k_ElementsInPostsList = 3;
        private readonly VerticalBox k_PostsContainer;
        private readonly Timer r_CommercialsTimer;
        private readonly Timer r_NotificationTimer;
        private IImagePickerStrategy m_ImagePicker;
    }
}
