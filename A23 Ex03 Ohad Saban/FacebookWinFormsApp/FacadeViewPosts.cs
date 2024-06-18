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
        private User m_User;
        private List<Post> m_UserPosts;
        private PostsCollection m_PostsCollection;
        private IIterator m_Iterator;
        private Dictionary<Post, string> m_PostDisplayDict;
        private Dictionary<int, Post> m_IndexToPostDict;

        public FacadeViewPosts(User i_LoggedUser)
        {
            m_User = i_LoggedUser;
            m_UserPosts = m_User.Posts.ToList();
            m_PostsCollection = new PostsCollection(m_UserPosts);
            m_Iterator = null;
            m_PostDisplayDict = new Dictionary<Post, string>();
            m_IndexToPostDict = new Dictionary<int, Post>();
        }

        public List<string> GetPosts(string i_SortingParamter)
        {
            m_PostDisplayDict = new Dictionary<Post, string>();
            m_IndexToPostDict = new Dictionary<int, Post>();
            m_PostsCollection.Sort(i_SortingParamter);
            m_Iterator = m_PostsCollection.CreateIterator();
            while(m_Iterator.MoveNext())
            {
                addPostToDict(m_Iterator.Current);
            }

            return m_PostDisplayDict.Values.ToList();
        }

        private void addPostToDict(object i_Post)
        {
            Post currentPost = i_Post as Post;
            string currPostContent = getPostContent(currentPost);
            if(currPostContent != null)
            {
                int count = m_PostDisplayDict.Count;
                m_PostDisplayDict.Add(currentPost, currPostContent);
                m_IndexToPostDict.Add(count, currentPost);
            }
        }

        private string getPostContent(Post i_Post)
        {
            string postContent;
            bool nullMessage = i_Post.Message is null;
            bool nullCaption = i_Post.Caption is null;
            bool nullName = i_Post.Name is null;
            if (!nullMessage)
            {
                postContent = i_Post.Message;
            }
            else if (!nullCaption)
            {
                postContent = i_Post.Caption;
            }
            else if (!nullName)
            {
                postContent = i_Post.Name;
            }
            else
            {
                postContent = null;
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
            try
            {
                Post selectedPost = m_IndexToPostDict[i_PostIndex];
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
    }
}
