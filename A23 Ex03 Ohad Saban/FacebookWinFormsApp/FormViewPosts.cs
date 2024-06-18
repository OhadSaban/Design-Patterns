using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormViewPosts : Form
    {
        private FacadeViewPosts m_ViewPostsFacad;

        public FormViewPosts(User i_LoggedUser)
        {
            m_ViewPostsFacad = new FacadeViewPosts(i_LoggedUser);
            InitializeComponent();
        }

        private void submitPost()
        {
            m_ViewPostsFacad.SubmitPost(richTextBoxTextPost.Text);
        }

        private void displayPosts()
        {
            List<string> posts = m_ViewPostsFacad.GetPosts(comboBoxSortPosts.Text);
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
            foreach(string post in posts)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
            }

            listBoxPosts.Invoke(new Action(() => listBoxPosts.Update()));
        }

        private void displayComments()
        {
            List<string> comments = m_ViewPostsFacad.DisplayComments(listBoxPosts.SelectedIndex);
            listBoxCommentsInPost.Invoke(new Action(() => listBoxCommentsInPost.Items.Clear()));
            foreach(string comment in comments)
            {
                listBoxCommentsInPost.Invoke(new Action(() => listBoxCommentsInPost.Items.Add(comment)));
            }

            listBoxCommentsInPost.Invoke(new Action(() => listBoxCommentsInPost.Update()));
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedItem != null)
            {
                displayComments();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            submitPost();
        }

        private void comboBoxSortPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPosts();
        }

        private void FormViewPosts_Load(object sender, EventArgs e)
        {
            comboBoxSortPosts.SelectedIndex = 0;
            listBoxPosts.SelectedIndex = 0;
        }
    }
}
