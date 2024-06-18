using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IObserver
    {
        void AddPhotoToFavoriteList(Photo photo);

        void RemovePhotoFromFavoriteList(Photo photo);
    }
}
