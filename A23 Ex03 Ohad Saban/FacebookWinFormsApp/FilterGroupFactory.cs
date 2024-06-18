using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public static class FilterGroupFactory
    {
        public static IFilterGroup CreateFilterGroup(string i_Type)
        {
            IFilterGroup newFilterGroup;

            if(i_Type.Equals("friends"))
            {
                newFilterGroup = new FriendsFilterGroup();
            }
            else
            {
                throw new Exception("Filter group from this type is not supported");
            }

            return newFilterGroup;
        }
    }
}
