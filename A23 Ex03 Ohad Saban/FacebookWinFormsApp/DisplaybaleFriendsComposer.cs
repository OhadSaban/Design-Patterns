using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class DisplaybaleFriendsComposer
    {
        private DisplayableFriendsBuilder m_FriendsListBuilder = new DisplayableFriendsBuilder();

        public DisplaybaleFriendsComposer(){}

        public List<Friend> GetDisplayableFriendsList(User i_LoggedUser, IFilterGroup i_FilterGroup, FacebookObjectCollection<User> i_Datasource)
        {
            return m_FriendsListBuilder.GetDisplayableFriendsList(i_LoggedUser, i_FilterGroup, i_Datasource);
        }
    }
}
