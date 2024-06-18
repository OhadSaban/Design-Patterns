using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    interface IFilter
    {
        string Name { get; }

        string[] Values { get; }

        string CurrentValue { get; set; }

        bool ValidateItem(string i_Item);
    }
}
