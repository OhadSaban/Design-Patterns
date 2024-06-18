using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IComperor
    {
        bool ShouldSwap(Post i_PrevPost, Post i_NextPost);
    }
}
