using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class FacadeViewImages
    {
        private User m_LoggedInUser;
        private Album m_SelectedAlbum;
        private List<Photo> m_AlbumPhotosList;
        private int m_CurrentPhotoIndex;
        private bool m_showOldestImageFirst;

        public FacadeViewImages(User i_User)
        {
            m_LoggedInUser = i_User;
        }

        public List<Album> FetchUserAlbums()
        {
            return m_LoggedInUser.Albums.ToList();
        }

        public string LoadAlbumImage()
        {
            Photo currentPhoto;
            string imageUrl;
            if (m_AlbumPhotosList.Count == 0)
            {
                imageUrl = null;
            }
            else
            {
                currentPhoto = m_AlbumPhotosList[m_CurrentPhotoIndex];
                imageUrl = currentPhoto.PictureNormalURL;
            }

            return imageUrl;
        }

        public void NextImage()
        {
            if (m_CurrentPhotoIndex + 1 < m_AlbumPhotosList.Count)
            {
                m_CurrentPhotoIndex++;
            }
            else
            {
                m_CurrentPhotoIndex = 0;
            }
        }

        public void PreviousImage()
        {
            if (m_CurrentPhotoIndex - 1 >= 0)
            {
                m_CurrentPhotoIndex--;
            }
            else
            {
                m_CurrentPhotoIndex = m_AlbumPhotosList.Count - 1;
            }
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
                    m_CurrentPhotoIndex = 0;
                    sorted = true;
                }
            }
            else
            {
                if (!m_showOldestImageFirst)
                {
                    m_AlbumPhotosList.Reverse();
                    m_showOldestImageFirst = true;
                    m_CurrentPhotoIndex = 0;
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

        public string GetCurrentAlbumCover()
        {
            return m_SelectedAlbum.PictureAlbumURL;
        }

        public void ChangeAlbum(Album i_Album)
        {
            m_showOldestImageFirst = false;
            m_SelectedAlbum = i_Album;
            m_AlbumPhotosList = m_SelectedAlbum.Photos.ToList();
            m_CurrentPhotoIndex = 0;
        }
    }
}
