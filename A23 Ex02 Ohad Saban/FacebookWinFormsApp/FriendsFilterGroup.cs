using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FriendsFilterGroup : IFilterGroup
    {
        private Dictionary<string, IFilter> r_Filters;

        public string[] FilterNames
        {
            get
            {
                return r_Filters.Keys.ToArray();
            }
        }

        public FriendsFilterGroup()
        {
            r_Filters = new Dictionary<string, IFilter>();
            r_Filters.Add("Gender", new GenderFilter());
            r_Filters.Add("Hometown", new HometownFilter());
            r_Filters.Add("Single", new SingleFilter());
            r_Filters.Add("Location", new LocationFilter());
        }

        public bool FilterItem(User i_Source, User i_ItemToFilter)
        {
            User loggedUser = i_Source;
            User friend = i_ItemToFilter;
            bool hometownValid = true;
            bool genderValid = true;
            bool locationValid = true;
            bool singleValid = true;
            if (r_Filters["Gender"].CurrentValue != "All")
            {
                genderValid = checkGender(friend.Gender);
            }

            if (r_Filters["Location"].CurrentValue != "All")
            {
                locationValid = checkLocation(loggedUser.Location, friend.Location);
            }

            if (r_Filters["Hometown"].CurrentValue != "All")
            {
                hometownValid = checkHometown(loggedUser.Hometown, friend.Hometown);
            }

            if (r_Filters["Single"].CurrentValue != "All")
            {
                singleValid = checkIfSingle(friend.RelationshipStatus);
            }

            bool isValidFriend = hometownValid && genderValid && locationValid && singleValid;

            return isValidFriend;
        }

        private bool checkHometown(City i_UserHometown, City i_friendHometown)
        {
            string comparisonRslt;
            bool isHometownValid;
            if(i_UserHometown == null || i_friendHometown == null)
            {
                isHometownValid = false;
            }
            else
            {
                if (i_UserHometown.Equals(i_friendHometown))
                {
                    comparisonRslt = "Same";
                }
                else
                {
                    comparisonRslt = "Different";
                }

                IFilter hometownFilter = r_Filters["Hometown"];
                isHometownValid = hometownFilter.ValidateItem(comparisonRslt);
            }

            return isHometownValid;
        }

        private bool checkGender(User.eGender? i_Gender)
        {
            bool isGenderValid;
            string comparisonRslt;
            if(i_Gender == null)
            {
                isGenderValid = false;
            }
            else
            {
                if (i_Gender == User.eGender.male)
                {
                    comparisonRslt = "Male";
                }
                else
                {
                    comparisonRslt = "Female";
                }

                IFilter genderFilter = r_Filters["Gender"];
                isGenderValid = genderFilter.ValidateItem(comparisonRslt);
            }

            return isGenderValid;
        }

        private bool checkLocation(City i_UserLocation, City i_friendLocation)
        {
            string comparisonRslt;
            bool isLocationValid;
            if (i_UserLocation == null || i_friendLocation == null)
            {
                isLocationValid = false;
            }
            else
            {
                if(i_UserLocation.Equals(i_friendLocation))
                {
                    comparisonRslt = "Same";
                }
                else
                {
                    comparisonRslt = "Different";
                }

                IFilter locationFilter = r_Filters["Location"];
                isLocationValid = locationFilter.ValidateItem(comparisonRslt);
            }

            return isLocationValid;
        }

        private bool checkIfSingle(User.eRelationshipStatus? i_RelationshipStatus)
        {
            string comparisonRslt;
            bool isSingleValid;
            if(i_RelationshipStatus == null)
            {
                isSingleValid = false;
            }
            else
            {
                if (i_RelationshipStatus.Equals("Single"))
                {
                    comparisonRslt = "Yes";
                }
                else
                {
                    comparisonRslt = "No";
                }

                IFilter singleFilter = r_Filters["Single"];
                isSingleValid = singleFilter.ValidateItem(comparisonRslt);
            }

            return isSingleValid;
        }

        public void ChangeFilterState(string i_FilterName, string i_NewState)
        {
            if (doesFilterExists(i_FilterName))
            {
                IFilter targetFilter = r_Filters[i_FilterName];
                targetFilter.CurrentValue = i_NewState;
            }
        }

        private bool doesFilterExists(string i_FilterName)
        {
            bool isExists = r_Filters.ContainsKey(i_FilterName);
            return isExists;
        }
    }
}
