using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Message = FacebookWrapper.ObjectModel.Message;

namespace BasicFacebookFeatures
{
    public partial class FormViewImages : Form
    {
        private User m_LoggedInUser;
        private Album m_SelectedAlbum;
        private List<Album> m_UserAlbumsList;
        private List<Photo> m_AlbumPhotosList;
        private int m_CurrentPhotoIndex;
        private bool m_showOldestImageFirst;
        public FormViewImages(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchUserAlbums();
            comboBoxAlbums.SelectedIndex = 0;
        }

        private void fetchUserAlbums()
        {
            m_UserAlbumsList = m_LoggedInUser.Albums.ToList();
            comboBoxAlbums.Items.Clear();
            if (m_UserAlbumsList.Count == 0)
            {
                MessageBox.Show(string.Format("{0} doesnt have any albums", m_LoggedInUser.Name));
            }
            else
            {
                foreach (Album album in m_UserAlbumsList)
                {
                    comboBoxAlbums.Items.Add(album);
                }
            }
            comboBoxAlbums.Update();
        }

        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            nextPhoto();
        }

        private void nextPhoto()
        {
            try
            {
                if (m_CurrentPhotoIndex + 1 < m_AlbumPhotosList.Count)
                {
                    m_CurrentPhotoIndex++;
                   
                }
                else
                {
                    m_CurrentPhotoIndex = 0;
                }
                loadAlbumImage();
            }
            catch (Exception e)
            {
                MessageBox.Show("Choose first an album from the list of albums");
            }
        }

        private void buttonPrevPhoto_Click(object sender, EventArgs e)
        {
            previousPhoto();
        }

        private void previousPhoto()
        {
            try
            {
                if (m_CurrentPhotoIndex - 1 >= 0)
                {
                    m_CurrentPhotoIndex--;
                }
                else
                {
                    m_CurrentPhotoIndex = m_AlbumPhotosList.Count - 1;
                }
                loadAlbumImage();
            }
            catch(Exception e)
            {
                MessageBox.Show("Choose first an album from the list of albums");
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            sortImages();
        }

        private void sortImages()
        {
            if (comboBoxSortedBy.SelectedIndex == 0)
            {
                if (m_showOldestImageFirst)
                {
                    m_AlbumPhotosList.Reverse();
                    m_showOldestImageFirst = false;
                    m_CurrentPhotoIndex = 0;
                    loadAlbumImage();
                }
            }
            else
            {
                if (!m_showOldestImageFirst)
                {
                    m_AlbumPhotosList.Reverse();
                    m_showOldestImageFirst = true;
                    m_CurrentPhotoIndex = 0;
                    loadAlbumImage();
                }
            }
        }
        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelChooseAlbum_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSelectedAlbum();
        }

        private void changeSelectedAlbum()
        {
            m_showOldestImageFirst = false;
            comboBoxSortedBy.SelectedIndex = 0;
            m_SelectedAlbum = comboBoxAlbums.SelectedItem as Album;
            m_AlbumPhotosList = m_SelectedAlbum.Photos.ToList();
            string albumName = string.IsNullOrEmpty(m_SelectedAlbum.Name) ? "Nameless Album" : m_SelectedAlbum.Name;
            string albumCover = m_SelectedAlbum.PictureAlbumURL;
            if (!(albumCover is null))
            {
                pictureBoxAlbum.LoadAsync(albumCover);
            }
            else
            {
                MessageBox.Show("Album lacks coverphoto");
            }
            labelAlbumName.Text = albumName;
            m_CurrentPhotoIndex = 0;
            loadAlbumImage();
        }

        private void loadAlbumImage()
        {
            Photo currentPhoto;
            if (m_AlbumPhotosList.Count == 0)
            {
                MessageBox.Show("This Album contains no pictures!");
            }
            else
            {
                currentPhoto = m_AlbumPhotosList[m_CurrentPhotoIndex];
                pictureBoxImageInAlbum.LoadAsync(currentPhoto.PictureNormalURL);
            }
        }

        private void comboBoxSortedBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

