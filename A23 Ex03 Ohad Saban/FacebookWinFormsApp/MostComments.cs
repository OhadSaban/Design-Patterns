using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class MostComments : IComperor
    {
        public bool ShouldSwap(Post i_PrevPost, Post i_NextPost)
        {
            return i_PrevPost.Comments.Count < i_NextPost.Comments.Count;
        }
    }
}
