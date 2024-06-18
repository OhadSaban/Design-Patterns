using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class FacadeViewPosts
    {
        private readonly int r_PageSize = 10;
        private User m_User;
        private List<Post> m_UserPosts;
        private List<ListPage> m_Pages = new List<ListPage>();
        private int m_CurrentPage = -1;
        private int m_NextPostToSaveIndex;
        private bool m_finalePageReached;
        private bool m_isPostOrderReversed;

        public FacadeViewPosts(User i_LoggedUser)
        {
            m_User = i_LoggedUser;
            m_UserPosts = m_User.Posts.ToList();
        }

        public List<string> Init()
        {
            m_Pages = new List<ListPage>();
            m_CurrentPage = -1;
            m_NextPostToSaveIndex = 0;
            m_finalePageReached = false;
            return LoadNextPage();
        }

        public List<string> LoadPreviousPage()
        {
            if (m_CurrentPage > 0)
            {
                m_CurrentPage--;
            }

            return loadPage();
        }

        public List<string> LoadNextPage()
        {
            List<string> postsContent;
            m_CurrentPage++;
            if (m_Pages.Count == m_CurrentPage)
            {
                if (m_finalePageReached)
                {
                    m_CurrentPage--;
                    postsContent = loadPage();
                }
                else
                {
                    postsContent = createNewPage();
                }
            }
            else
            {
                postsContent = loadPage();
            }

            return postsContent;
        }

        private List<string> createNewPage()
        {
            ListPage newPage = new ListPage(m_CurrentPage, r_PageSize);
            List<string> postContents = new List<string>();
            int postIndex = m_NextPostToSaveIndex;
            int postsAddedCounter = 0;
            while (postsAddedCounter < r_PageSize)
            {
                if (postIndex >= m_UserPosts.Count)
                {
                    m_finalePageReached = true;
                    break;
                }

                Post currPost = m_UserPosts[postIndex];
                bool noPostDisplay = currPost.Type.Equals(Post.eType.status);
                if (!noPostDisplay)
                {
                    postsAddedCounter++;
                    newPage.AddItem(postIndex);
                    postContents.Add(addPostContent(currPost));
                }

                postIndex++;
            }

            if (postsAddedCounter != 0)
            {
                m_NextPostToSaveIndex = postIndex + 1;
                m_Pages.Add(newPage);
            }
            else
            {
                m_CurrentPage--;
                LoadNextPage();
            }

            return postContents;
        }

        private List<string> loadPage()
        {
            ListPage page = m_Pages[m_CurrentPage];
            int[] postsIndicies = page.GetItems();
            List<string> postsContents = new List<string>();
            foreach (int index in postsIndicies)
            {
                bool maxIndexReached = index >= m_UserPosts.Count;
                bool lastPostDisplayed = (m_CurrentPage == m_Pages.Count - 1) && (index == 0);
                bool breakCondition = maxIndexReached || lastPostDisplayed;
                if (breakCondition)
                {
                    break;
                }

                Post currPost = m_UserPosts[index];
                postsContents.Add(addPostContent(currPost));
            }

            return postsContents;
        }

        private string addPostContent(Post i_Post)
        {
            string postContent;
            bool nullMessage = i_Post.Message is null;
            bool nullCaption = i_Post.Caption is null;
            if (!nullMessage)
            {
                postContent = i_Post.Message;
            }
            else if (!nullCaption)
            {
                postContent = i_Post.Caption;
            }
            else
            {
                postContent = string.Format("No Caption: Post id is {0}", i_Post.Id);
            }

            return postContent;
        }

        public void SubmitPost(string i_NewPostText)
        {
            try
            {
                if (string.IsNullOrEmpty(i_NewPostText))
                {
                    MessageBox.Show("Cannot post an empty status!");
                }
                else
                {
                    Status postedStatus = m_User.PostStatus(i_NewPostText);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                }
            }
            catch (FacebookOAuthException e)
            {
                MessageBox.Show("Could not post, lacking proper premissions!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<string> DisplayComments(int i_PostIndex)
        {
            List<string> postCommentsList = new List<string>();
            int postIndex = m_Pages[m_CurrentPage].GetItem(i_PostIndex);
            Post selectedPost = null;
            if (postIndex - 1 >= 0)
            {
                selectedPost = m_UserPosts[postIndex - 1];
            }
            else
            {
                selectedPost = m_UserPosts[0];
            }

            try
            {
                if (selectedPost.Comments.Count == 0)
                {
                    postCommentsList.Add("No comments by users of this app");
                }
                else
                {
                    foreach (Comment comment in selectedPost.Comments)
                    {
                        postCommentsList.Add(comment.Message);
                    }
                }
            }
            catch(Facebook.FacebookOAuthException e)
            {
                MessageBox.Show("An authentication exception has occured!");
            }

            return postCommentsList;
        }

        public void SortPosts(int i_Index)
        {
            if (i_Index == 0)
            {
                if (m_isPostOrderReversed)
                {
                    m_UserPosts.Reverse();
                    m_isPostOrderReversed = false;
                    Init();
                }
            }
            else
            {
                if (!m_isPostOrderReversed)
                {
                    m_UserPosts.Reverse();
                    m_isPostOrderReversed = true;
                    Init();
                }
            }
        }
    }
}
