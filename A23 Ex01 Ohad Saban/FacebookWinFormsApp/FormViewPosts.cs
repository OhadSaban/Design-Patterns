using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormViewPosts : Form
    {
        private readonly int r_PageSize = 10;
        private User m_User;
        private List<Post> m_UserPosts;
        private List<ListPage> m_Pages = new List<ListPage>();
        private int m_CurrentPage = -1;
        private int m_NextPostToSaveIndex;
        private bool m_finalePageReached;
        private bool m_isPostOrderReversed;

        public FormViewPosts(User i_LoggedUser)
        {
            m_User = i_LoggedUser;
            m_UserPosts = m_User.Posts.ToList();
            InitializeComponent();
            populateForm();
        }

        private void populateForm()
        {
            m_Pages = new List<ListPage>();
            m_CurrentPage = -1;
            m_NextPostToSaveIndex = 0;
            m_finalePageReached = false;
            nextPostsPage();
        }

        private void nextPostsPage()
        {
            m_CurrentPage++;
            listBoxPosts.Items.Clear();
            if (m_Pages.Count == m_CurrentPage)
            {
                if (m_finalePageReached)
                {
                    m_CurrentPage--;
                    loadPage();
                }
                else
                {
                    createNewPage();
                }
            }
            else
            {
                loadPage();
            }
            listBoxPosts.Update();
        }

        private void prevPostPage()
        {
            if (m_CurrentPage > 0)
            {
                listBoxPosts.Items.Clear();
                m_CurrentPage--;
                loadPage();
                listBoxPosts.Update();
            }
        }

        private void createNewPage()
        {
            ListPage newPage = new ListPage(m_CurrentPage, r_PageSize);
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
                    newPage.addItem(postIndex);
                    addPostContent(currPost);
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
                nextPostsPage();
            }
        }

        private void loadPage()
        {
            ListPage page = m_Pages[m_CurrentPage];
            int[] postsIndicies = page.getItems();
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
                addPostContent(currPost);
            }
        }

        private void addPostContent(Post i_Post)
        {
            bool nullMessage = i_Post.Message is null;
            bool nullCaption = i_Post.Caption is null;
            if (!nullMessage)
            {
                listBoxPosts.Items.Add(i_Post.Message);
            }
            else if (!nullCaption)
            {
                listBoxPosts.Items.Add(i_Post.Caption);
            }
            else
            {
                listBoxPosts.Items.Add(string.Format("No Caption: Post id is {0}", i_Post.Id));
            }
        }


        private void submitPost()
        {
            try
            {
                if (string.IsNullOrEmpty(richTextBoxTextPost.Text))
                {
                    MessageBox.Show("Cannot post an empty status!");
                }
                else
                {
                    Status postedStatus = m_User.PostStatus(richTextBoxTextPost.Text);
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
        


        private void displayComments()
        {
            int postIndex = m_Pages[m_CurrentPage].getItem(listBoxPosts.SelectedIndex);
            Post selectedPost = m_UserPosts[postIndex - 1];
            listBoxCommentsInPost.Items.Clear();
            try
            {
                if (selectedPost.Comments.Count == 0)
                {
                    listBoxCommentsInPost.Items.Add("No comments by users of this app");
                }
                else
                {
                    foreach (Comment comment in selectedPost.Comments)
                    {
                        listBoxCommentsInPost.Items.Add(comment.Message);
                    }
                }
                listBoxCommentsInPost.Update();
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

        private void buttonNextPage_Click_1(object sender, EventArgs e)
        {
            nextPostsPage();
        }

        private void buttonPrevPage_Click_1(object sender, EventArgs e)
        {
            prevPostPage();
        }

        private void listBoxPosts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem != null)
            {
                displayComments();
            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click_1(object sender, EventArgs e)
        {
            submitPost();
        }

        private void comboBoxSortPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortPosts();
        }

        private void sortPosts()
        {
            if (comboBoxSortPosts.SelectedIndex == 0)
            {
                if(m_isPostOrderReversed)
                {
                    m_UserPosts.Reverse();
                    m_isPostOrderReversed = false;
                    populateForm();
                }
            }
            else
            {
                if (!m_isPostOrderReversed)
                {
                    m_UserPosts.Reverse();
                    m_isPostOrderReversed = true;
                    populateForm();
                }
            }
        }
    }
}
