using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class FacadeViewFriends
    {
        private User m_User;
        private readonly IFilterGroup r_FilterGroup;
        private DisplaybaleFriendsComposer r_FriendsListComposer;

        public FacadeViewFriends(User i_User)
        {
            m_User = i_User;
            r_FilterGroup = FilterGroupFactory.CreateFilterGroup("friends");
            r_FriendsListComposer = new DisplaybaleFriendsComposer();
        }

        public List<Friend> UpdateFriendList()
        {
            List<Friend> updatedFriendsList =
                r_FriendsListComposer.GetDisplayableFriendsList(m_User, r_FilterGroup, m_User.Friends);
            return updatedFriendsList;
        }

        public void UpdateGenderFilter(string i_SelectedValue)
        {
            r_FilterGroup.ChangeFilterState("Gender", i_SelectedValue);
        }

        public void UpdateSingleFilter(string i_SelectedValue)
        {
            r_FilterGroup.ChangeFilterState("Single", i_SelectedValue);
        }

        public void UpdateLocationFilter(string i_SelectedValue)
        {
            r_FilterGroup.ChangeFilterState("Location", i_SelectedValue);
        }

        public void UpdateHometownFilter(string i_SelectedValue)
        {
            r_FilterGroup.ChangeFilterState("Hometown", i_SelectedValue);
        }
    }
}
