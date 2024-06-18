using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMenu : Form
    {
        private User m_UserLoggedIn;
        private LoginResult m_LoginResults;
        private FormViewImages m_FormViewImages;
        private FormViewPosts m_FormViewPosts;
        private FormViewFriends m_FormViewFriends;
        private string m_UserName;
        private string m_ProfilePicture;

        public FormMenu()
        {
            InitializeComponent();
        }

        public FormMenu(User i_UserLoggedIn, LoginResult i_LoginResults)
        {
            m_UserLoggedIn = i_UserLoggedIn;
            m_LoginResults = i_LoginResults;
            m_UserName = m_UserLoggedIn.Name;
            m_ProfilePicture = m_UserLoggedIn.PictureLargeURL;
            InitializeComponent();
            populateComponents();
        }

        private void populateComponents()
        {
            labelUserFirstName.Text = m_UserLoggedIn.FirstName;
            pictureBoxProfilePicture.LoadAsync(m_UserLoggedIn.PictureLargeURL);
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            m_FormViewPosts = new FormViewPosts(m_UserLoggedIn);
            this.Visible = false;
            DialogResult formViewPostResult = m_FormViewPosts.ShowDialog();
            this.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            m_FormViewFriends = new FormViewFriends(m_UserLoggedIn);
            Visible = false;
            DialogResult formViewFriendsResult = m_FormViewFriends.ShowDialog();
            Visible = true;
        }

        private void buttonImages_Click(object sender, EventArgs e)
        {
            m_FormViewImages = new FormViewImages(m_UserLoggedIn);
            Visible = false;
            m_FormViewImages.ShowDialog();
            Visible = true;
        }
    }
}
