using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostsCollection : IAggregate
    {
        private List<Post> m_Posts;
        private PostSorter m_Sorter;

        public PostsCollection(List<Post> i_Posts)
        {
            m_Posts = i_Posts;
            Sort("Newest");
        }

        public void Sort(string i_SortingParamter)
        {
            if (i_SortingParamter.Equals("Newest"))
            {
                m_Sorter = new PostSorter(new NewestPosts());
            }
            else if (i_SortingParamter.Equals("Oldest"))
            {
                m_Sorter = new PostSorter(new OldestPosts());
            }
            else if (i_SortingParamter.Equals("Most Likes"))
            {
                m_Sorter = new PostSorter(new MostLikes());
            }
            else if (i_SortingParamter.Equals("Most Comments"))
            {
                m_Sorter = new PostSorter(new MostComments());
            }
            else
            {
                throw new Exception("Illegale sorting paramter. what are you even doing here? chatGPT would have written something better");
            }

            m_Posts = m_Sorter.Sort(m_Posts);
        }

        public IIterator CreateIterator()
        {
            return new PostsCollectionIterator(this);
        }

        private class PostsCollectionIterator : IIterator
        {
            private PostsCollection m_Aggregate;
            private int m_CurrentIndex = -1;
            private int m_CountPosts = -1;

            public object Current
            {
                get
                {
                    return m_Aggregate.m_Posts[m_CurrentIndex];
                }
            }

            public PostsCollectionIterator(PostsCollection i_Aggregate)
            {
                m_Aggregate = i_Aggregate;
                m_CountPosts = m_Aggregate.m_Posts.Count;
            }

            public void Reset()
            {
                m_CurrentIndex = -1;
            }

            public bool MoveNext()
            {
                if (m_CountPosts != m_Aggregate.m_Posts.Count)
                {
                    throw new Exception("Cannot change the collection");
                }

                if (m_CurrentIndex >= m_Aggregate.m_Posts.Count)
                {
                    throw new Exception("Already reached the end of the collection!");
                }

                return ++m_CurrentIndex < m_Aggregate.m_Posts.Count;
            }
        }
    }
}
