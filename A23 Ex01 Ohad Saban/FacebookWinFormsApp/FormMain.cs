using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResults;
        private FormMenu m_FormMenu;
        private bool m_IsUserLoggedIn;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!m_IsUserLoggedIn)
            {
                login();
            }
            else
            {
                openApp();
            }
            
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login()
        {
            m_LoginResults = FacebookService.Login(
                "1371101000087084",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResults.AccessToken))
            {
                m_LoggedInUser = m_LoginResults.LoggedInUser;
                buttonLogout.Enabled = true;
                buttonLogin.Text = "Open App";
                m_IsUserLoggedIn = true;
            }
            else
            {
                MessageBox.Show(m_LoginResults.ErrorMessage, "Login Failed! Try again");
            }
        }

        private void openApp()
        {
            m_FormMenu = new FormMenu(m_LoggedInUser, m_LoginResults);
            this.Visible = false;
            m_FormMenu.ShowDialog();
            this.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser != null)
            {
                FacebookService.Logout();
                m_LoggedInUser = null;
                m_LoginResults = null;
                m_IsUserLoggedIn = false;
                buttonLogin.Text = "Login";
                buttonLogout.Enabled = false;
            }
        }
    }
}
