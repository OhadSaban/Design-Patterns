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
        private List<IObserver> m_Observers = new List<IObserver>();

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
            AttachObserver(m_Facad);
        }

        private void displayAlbums(List<Album> i_AlbumsList)
        {
            if (!this.IsHandleCreated)
            {
                Thread.Sleep(1000);
            }

            comboBoxAlbums.Invoke(new Action(() => comboBoxAlbums.Items.Clear()));
            listBoxPhotosInAlbum.Invoke(new Action(() => listBoxPhotosInAlbum.Items.Clear()));

            foreach (Album album in i_AlbumsList)
            {
                comboBoxAlbums.Invoke(new Action(() => comboBoxAlbums.Items.Add(album)));
            }

            List<Photo> listPhotos = i_AlbumsList[0].Photos.ToList();
            displayPhotos(listPhotos);
            comboBoxAlbums.Invoke(new Action(() => listBoxPhotosInAlbum.Update()));
            comboBoxAlbums.Invoke(new Action(() => comboBoxAlbums.Update()));
        }

        private void displayPhotos(List<Photo> i_AlbumPhotosList)
        {
            if (i_AlbumPhotosList is null)
            {
                MessageBox.Show("No Favorite Photos");
            }
            else
            {
                listBoxPhotosInAlbum.Invoke(new Action(() => listBoxPhotosInAlbum.Items.Clear()));
                foreach (Photo photo in i_AlbumPhotosList)
                {
                    listBoxPhotosInAlbum.Invoke(new Action(() => listBoxPhotosInAlbum.Items.Add(photo)));
                }
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            bool isSorted = m_Facad.SortImages(comboBoxSortedBy.SelectedIndex);
            if (isSorted)
            {
                List<Photo> listPhotosAlbum = m_Facad.GetCurrentListPhotos();
                displayPhotos(listPhotosAlbum);
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
            comboBoxSortedBy.SelectedIndex = 0;
            List<Photo> listPhotos = m_Facad.GetCurrentListPhotos();
            displayPhotos(listPhotos);
            labelAlbumName.Text = albumName;
            buttonApply.Enabled = true;
        }

        private void changeSelectedPhoto()
        {
            Photo photo = listBoxPhotosInAlbum.SelectedItem as Photo;
            m_Facad.ChangePhoto(photo);
            if (!(photo.PictureAlbumURL is null))
            {
                pictureBoxImageInAlbum.LoadAsync(photo.PictureNormalURL);
            }
            else
            {
                MessageBox.Show("Photo lacks photo");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void listBoxPhotosInAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeSelectedPhoto();
        }

        private void buttonMark_Click(object sender, EventArgs e)
        {
            if (listBoxPhotosInAlbum.SelectedIndex != null)
            {
                addPhotoToFavoriteList();
            }
        }

        private void addPhotoToFavoriteList()
        {
            Photo photo = listBoxPhotosInAlbum.SelectedItem as Photo;
            foreach (IObserver observer in m_Observers)
            {
                observer.AddPhotoToFavoriteList(photo);
            }
        }

        private void buttonUnmark_Click(object sender, EventArgs e)
        {
            if (listBoxPhotosInAlbum.SelectedIndex != null)
            {
                removePhotoFromFavoriteList();
            }
        }

        private void removePhotoFromFavoriteList()
        {
            Photo photo = listBoxPhotosInAlbum.SelectedItem as Photo;
            foreach (IObserver observer in m_Observers)
            {
                observer.RemovePhotoFromFavoriteList(photo);
            }
        }

        public void AttachObserver(IObserver i_Observer)
        {
            m_Observers.Add(i_Observer);
        }

        public void DetachObserver(IObserver i_Observer)
        {
            m_Observers.Remove(i_Observer);
        }

        private void buttonFavoritePhotos_Click(object sender, EventArgs e)
        {
            displayFavoritePhotos();
            buttonApply.Enabled = false;
        }

        private void displayFavoritePhotos()
        {
            List<Photo> listFavoritePhotos = m_Facad.GetFavoritePhotos();
            displayPhotos(listFavoritePhotos);
        }
    }
}