using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostSorter
    {
        private IComperor m_Comperor;

        public PostSorter(IComperor i_Comperor)
        {
            m_Comperor = i_Comperor;
        }

        public List<Post> Sort(List<Post> i_UnsortedPosts)
        {
            for (int i = 0; i < i_UnsortedPosts.Count; i++)
            {
                for (int j = 0; j < i_UnsortedPosts.Count - i - 1; j++)
                {
                    if (m_Comperor.ShouldSwap(i_UnsortedPosts[j], i_UnsortedPosts[j + 1]))
                    {
                        Swap(i_UnsortedPosts, j, j + 1);
                    }
                }
            }

            return i_UnsortedPosts;
        }

        private void Swap(List<Post> i_UnsortedPosts, int i_PrevIndex, int i_NextIndex)
        {
            Post temp = i_UnsortedPosts[i_PrevIndex];
            i_UnsortedPosts[i_PrevIndex] = i_UnsortedPosts[i_NextIndex];
            i_UnsortedPosts[i_NextIndex] = temp;
        }
    }
}
