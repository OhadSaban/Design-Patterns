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
    public partial class FormViewFriends : Form
    {
        private FacebookObjectCollection<User> m_UserFriends;
        private User m_User;
        private bool m_FilterSameHometown = false;
        private bool m_FilterDifferentHometown = false;
        private bool m_FilterIsMale = false;
        private bool m_FilterIsFemale = false;
        private bool m_FilterSameLocation = false;
        private bool m_FilterDifferentLocation = false;
        private bool m_FilterIsSingle = false;
        private bool m_FilterIsNotSingle = false;
        public FormViewFriends()
        {
            InitializeComponent();
        }

        public FormViewFriends(User i_User)
        {
            m_User = i_User;
            m_UserFriends = i_User.Friends;
            InitializeComponent();
            populateComponents();
        }

        private void populateComponents()
        {
            initFilters();
            updateFriendsList();
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
            listBoxFriends.Items.Clear();
            if (m_User.Friends.Count == 0)
            {
                MessageBox.Show(string.Format("None of {0} friends are using this app!", m_User.Name));
            }
            else
            {
                foreach (User friend in m_User.Friends)
                {
                    if (filterFriend(friend))
                    {
                        listBoxFriends.Items.Add(friend);
                    }
                }

                listBoxFriends.SelectedIndex = 0;
            }
            listBoxFriends.Update();
            
        }

        private void displayFriendInfo(User i_Friends)
        {
            User friend = i_Friends;
            labelFriendName.Text = friend.Name;
            pictureBoxFriendProfile.LoadAsync(friend.PictureLargeURL);
            labelFriendFrom.Text = string.Format("From: {0}", friend.Hometown);
            labelFriendLocation.Text = string.Format("Currently At: {0}",friend.Location);
            labelFriendGender.Text = string.Format("Gender: {0}", friend.Gender);
            labelFriendRelationship.Text = string.Format("Relationship Status: {0}", friend.RelationshipStatus);
            labelFriendEmail.Text = string.Format("Email: {0}", friend.Email);
            labelFriendBirthday.Text = string.Format("Birthday: {0}", friend.Birthday);
        }

        private bool filterFriend(User i_friend)
        {
            bool toDisplay = true;
            bool userHasProperty;
            bool friendHasProperty;
            if (m_FilterSameHometown)
            {
                userHasProperty = !(m_User.Hometown is null);
                friendHasProperty = !(i_friend.Hometown is null);
                toDisplay =userHasProperty && friendHasProperty && m_User.Hometown.Equals(i_friend.Hometown);
            } 
            else if(m_FilterDifferentHometown)
            {
                userHasProperty = !(m_User.Hometown is null);
                friendHasProperty = !(i_friend.Hometown is null);
                toDisplay = userHasProperty && friendHasProperty && !m_User.Hometown.Equals(i_friend.Hometown);
            }
            if (m_FilterIsMale)
            {
                friendHasProperty = !(i_friend.Gender is null);
                toDisplay = friendHasProperty && i_friend.Gender.Equals(User.eGender.male);
            }
            else if (m_FilterIsFemale)
            {
                friendHasProperty = !(i_friend.Gender is null);
                toDisplay = friendHasProperty && i_friend.Gender.Equals(User.eGender.female);
            }
            if (m_FilterSameLocation)
            {
                userHasProperty = !(m_User.Location is null);
                friendHasProperty = !(i_friend.Location is null);
                toDisplay = userHasProperty && friendHasProperty && m_User.Location.Equals(i_friend.Location);
            }
            else if (m_FilterDifferentLocation)
            {
                userHasProperty = !(m_User.Location is null);
                friendHasProperty = !(i_friend.Location is null);
                toDisplay = userHasProperty && friendHasProperty && !m_User.Location.Equals(i_friend.Location);
            }

            if (m_FilterIsSingle)
            {
                friendHasProperty = !(i_friend.RelationshipStatus is null);
                toDisplay = friendHasProperty && i_friend.RelationshipStatus == User.eRelationshipStatus.Single;
            }
            else if (m_FilterIsNotSingle)
            {
                friendHasProperty = !(i_friend.RelationshipStatus is null);
                toDisplay = friendHasProperty && i_friend.RelationshipStatus != User.eRelationshipStatus.Single;
            }

            return toDisplay;
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItem != null)
            {
                displayFriendInfo(listBoxFriends.SelectedItem as User);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxHometown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxHometown.Text;

            if (selectedValue.Equals("All"))
            {
                m_FilterDifferentHometown = false;
                m_FilterSameHometown = false;
            } 
            else if (selectedValue.Equals("Same"))
            {
                m_FilterDifferentHometown = false;
                m_FilterSameHometown = true;
            }
            else
            {
                m_FilterDifferentHometown = true;
                m_FilterSameHometown = false;
            }
        }

        private void comboBoxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxLocation.Text;

            if (selectedValue.Equals("All"))
            {
                m_FilterDifferentLocation = false;
                m_FilterSameLocation = false;
            }
            else if (selectedValue.Equals("Same"))
            {
                m_FilterDifferentLocation = false;
                m_FilterSameLocation = true;
            }
            else
            {
                m_FilterDifferentLocation = true;
                m_FilterSameLocation = false;
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxGender.Text;

            if (selectedValue.Equals("All"))
            {
                m_FilterIsMale = false;
                m_FilterIsFemale = false;
            }
            else if (selectedValue.Equals("Female"))
            {
                m_FilterIsMale = false;
                m_FilterIsFemale = true;
            }
            else
            {
                m_FilterIsMale = true;
                m_FilterIsFemale = false;
            }
        }

        private void comboBoxSingle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxSingle.Text;

            if (selectedValue.Equals("All"))
            {
                m_FilterIsSingle = false;
                m_FilterIsNotSingle = false;
            }
            else if (selectedValue.Equals("Yes"))
            {
                m_FilterIsSingle = true;
                m_FilterIsNotSingle = false;
            }
            else
            {
                m_FilterIsSingle = false;
                m_FilterIsNotSingle = true;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            updateFriendsList();
        }
    }
}
