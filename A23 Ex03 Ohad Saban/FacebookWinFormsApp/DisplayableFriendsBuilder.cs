using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class DisplayableFriendsBuilder
    {
        public DisplayableFriendsBuilder()
        {
        }

        public List<Friend> GetDisplayableFriendsList(User i_LoggedUser, IFilterGroup i_FilterGroup, FacebookObjectCollection<User> i_Datasource)
        {
            List<User> filteredList = filterList(i_LoggedUser, i_FilterGroup, i_Datasource);
            List<Friend> friendsList = createFriendsList(filteredList);
            return friendsList;
        }

        private List<User> filterList(User i_LoggedUser, IFilterGroup i_FilterGroup, FacebookObjectCollection<User> i_Datasoruce)
        {
            List<User> filteredList = new List<User>();
            foreach(User user in i_Datasoruce)
            {
                bool toIncludeItem = i_FilterGroup.FilterItem(i_LoggedUser, user);
                if(toIncludeItem)
                {
                    filteredList.Add(user);
                }
            }

            return filteredList;
        }

        private List<Friend> createFriendsList(List<User> i_FilteredList)
        {
            List<Friend> newList = new List<Friend>();
            foreach(User user in i_FilteredList)
            {
                newList.Add(new Friend(user));
            }

            return newList;
        }
    }
}
