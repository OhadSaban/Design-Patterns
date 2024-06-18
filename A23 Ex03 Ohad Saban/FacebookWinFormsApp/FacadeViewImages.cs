using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class FacadeViewImages : IObserver
    {
        private User m_LoggedInUser;
        private Album m_SelectedAlbum;
        private Photo m_SelectedPhoto;
        private List<Photo> m_AlbumPhotosList = new List<Photo>();
        private bool m_showOldestImageFirst;
        private List<Photo> m_FavoritePhotos = new List<Photo>();

        public FacadeViewImages(User i_User)
        {
            m_LoggedInUser = i_User;
        }

        public void AddPhotoToFavoriteList(Photo photo)
        {
            if (!m_FavoritePhotos.Contains(photo))
            {
                m_FavoritePhotos.Add(photo);
            }
        }

        public void RemovePhotoFromFavoriteList(Photo photo)
        {
            if (m_FavoritePhotos.Contains(photo))
            {
                m_FavoritePhotos.Remove(photo);
            }
        }

        public List<Photo> GetFavoritePhotos()
        {
            return m_FavoritePhotos;
        }

        public List<Album> FetchUserAlbums()
        {
            return m_LoggedInUser.Albums.ToList();
        }

        public bool SortImages(int i_Index)
        {
            bool sorted = false;
            if (i_Index == 0)
            {
                if (m_showOldestImageFirst)
                {
                    m_AlbumPhotosList.Reverse();
                    m_showOldestImageFirst = false;
                    sorted = true;
                }
            }
            else
            {
                if (!m_showOldestImageFirst)
                {
                    m_AlbumPhotosList.Reverse();
                    m_showOldestImageFirst = true;
                    sorted = true;
                }
            }

            return sorted;
        }

        public string GetCurrentAlbumName()
        {
            string name = string.IsNullOrEmpty(m_SelectedAlbum.Name) ? "Nameless Album" : m_SelectedAlbum.Name;
            return name;
        }

        public void ChangeAlbum(Album i_Album)
        {
            m_showOldestImageFirst = false;
            m_SelectedAlbum = i_Album;
            m_AlbumPhotosList = i_Album.Photos.ToList();
        }

        public void ChangePhoto(Photo i_Photo)
        {
            m_SelectedPhoto = i_Photo;
        }

        public List<Photo> GetCurrentListPhotos()
        {
            return m_AlbumPhotosList;
        }
    }
}
