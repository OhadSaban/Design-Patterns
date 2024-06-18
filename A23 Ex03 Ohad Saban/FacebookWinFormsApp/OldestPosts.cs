using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class OldestPosts : IComperor
    {
        public bool ShouldSwap(Post i_PrevPost, Post i_NextPost)
        {
            DateTime? prevPostDateTime = i_PrevPost.UpdateTime;
            DateTime? nextPostDateTime = i_NextPost.UpdateTime;
            return DateTime.Compare((DateTime)prevPostDateTime, (DateTime)nextPostDateTime) > 0;
        }
    }
}
