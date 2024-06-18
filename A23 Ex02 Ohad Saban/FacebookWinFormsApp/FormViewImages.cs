using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormViewImages : Form
    {
        private FacadeViewImages m_Facad;

        public FormViewImages(User i_LoggedInUser)
        {
            m_Facad = new FacadeViewImages(i_LoggedInUser);
            InitializeComponent();
            new Thread(startActivity).Start();
        }

        private void startActivity()
        {
            List<Album> albums = m_Facad.FetchUserAlbums();
            displayAlbums(albums);
            comboBoxAlbums.Invoke(new Action(() => comboBoxAlbums.SelectedIndex = 0));
        }

        private void displayAlbums(List<Album> i_AlbumsList)
        {
            comboBoxAlbums.Invoke(new Action(() => comboBoxAlbums.Items.Clear()));
            foreach (Album album in i_AlbumsList)
            {
                comboBoxAlbums.Invoke(new Action(() => comboBoxAlbums.Items.Add(album)));
            }

            comboBoxAlbums.Invoke(new Action(() => comboBoxAlbums.Update()));
        }

        private void loadAlbumImage()
        {
            string pictureURL = m_Facad.LoadAlbumImage();
            if(pictureURL != null)
            {
                pictureBoxImageInAlbum.LoadAsync(pictureURL);
            }
            else
            {
                MessageBox.Show("This Album contains no pictures!");
            }
        }

        private void loadNextPhoto()
        {
            try
            {
                m_Facad.NextImage();
                loadAlbumImage();
            }
            catch(Exception e)
            {
                MessageBox.Show("Choose first an album from the list of albums");
            }
        }

        private void loadPreviousPhoto()
        {
            try
            {
                m_Facad.PreviousImage();
                loadAlbumImage();
            }
            catch(Exception e)
            {
                MessageBox.Show("Choose first an album from the list of albums");
            }
        }

        private void buttonPrevPhoto_Click(object sender, EventArgs e)
        {
            loadPreviousPhoto();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            bool isSorted = m_Facad.SortImages(comboBoxSortedBy.SelectedIndex);
            if(isSorted)
            {
                loadAlbumImage();
            }
        }

        private void comboBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSelectedAlbum();
        }

        private void changeSelectedAlbum()
        {
            Album album = comboBoxAlbums.SelectedItem as Album;
            m_Facad.ChangeAlbum(album);
            string albumName = m_Facad.GetCurrentAlbumName();
            string albumCover = m_Facad.GetCurrentAlbumCover();
            comboBoxSortedBy.SelectedIndex = 0;
            if (!(albumCover is null))
            {
                pictureBoxAlbum.LoadAsync(albumCover);
            }
            else
            {
                MessageBox.Show("Album lacks coverphoto");
            }

            labelAlbumName.Text = albumName;
            loadAlbumImage();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            loadNextPhoto();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}