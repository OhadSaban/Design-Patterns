using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IFilterGroup
    {
        string[] FilterNames
        {
            get;
        }

        bool FilterItem(User i_Source, User i_ItemToFilter);

        void ChangeFilterState(string i_FilterName, string i_NewState);
    }
}
