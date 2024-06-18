using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormViewFriends : Form
    {
        private FacadeViewFriends m_Facad;
        private User m_User;

        public FormViewFriends()
        {
            InitializeComponent();
        }

        public FormViewFriends(User i_User)
        {
            m_Facad = new FacadeViewFriends(i_User);
            m_User = i_User;
            InitializeComponent();
        }

        private void initFilters()
        {
            comboBoxHometown.SelectedItem = comboBoxHometown.Items[0];
            comboBoxGender.SelectedItem = comboBoxGender.Items[0];
            comboBoxLocation.SelectedItem = comboBoxLocation.Items[0];
            comboBoxSingle.SelectedItem = comboBoxSingle.Items[0];
        }

        private void updateFriendsList()
        {
            List<Friend> updatedFriendList = m_Facad.UpdateFriendList();
            if (listBoxFriends.InvokeRequired)
            {

                listBoxFriends.Invoke(new Action(() => friendBindingSource.DataSource = updatedFriendList));
            }
            else
            {
                friendBindingSource.DataSource = updatedFriendList;
            }
        }


        private void buttonApply_Click(object sender, EventArgs e)
        {
            updateFriendsList();
        }

        private void comboBoxSingle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxSingle.Text;
            m_Facad.UpdateSingleFilter(selectedValue);
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxGender.Text;
            m_Facad.UpdateGenderFilter(selectedValue);
        }

        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxLocation.Text;
            m_Facad.UpdateLocationFilter(selectedValue);
        }

        private void comboBoxHometown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxHometown.Text;
            m_Facad.UpdateHometownFilter(selectedValue);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormViewFriends_Load(object sender, EventArgs e)
        {
            initFilters();
            new Thread(updateFriendsList).Start();
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItem != null)
            {
                displayFriendImage(listBoxFriends.SelectedItem as Friend);
            }
        }

        private void displayFriendImage(Friend i_Friend)
        {
            pictureBoxProfilePicture.LoadAsync(i_Friend.PictureURL);
        }
    }
}
