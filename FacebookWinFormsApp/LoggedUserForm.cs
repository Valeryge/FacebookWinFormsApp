using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.Text = k_LoggedUser.Name + "'s FaceBook";
            labelLoggedUserName.Text = "User: " + k_LoggedUser.Name;
            pictureBoxLoggedUserPicture.Image = k_LoggedUser.ImageNormal; //TODO: fix size;

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
            string[] urls;

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
    }
}
