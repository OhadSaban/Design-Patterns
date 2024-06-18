using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class Friend
    {
        private readonly User r_User;

        private readonly Dictionary<string, string> r_InformationDict;

        private readonly string r_Name;

        public Dictionary<string, string> Information
        {
            get
            {
                Dictionary<string, string> informationCopy = new Dictionary<string, string>();
                foreach(KeyValuePair<string, string> pair in r_InformationDict)
                {
                    informationCopy.Add(pair.Key, pair.Value);
                }

                return informationCopy;
            }
        }

        public string PictureURL
        {
            get
            {                               
                return r_InformationDict["ProfilePictureURL"];
            }
        }

        public User AssociatedUser
        {
            get
            {
                return r_User;
            }
        }

        public string Name
        {
            get
            {
                return r_Name;
            }
        }

        public string Location
        {
            get
            {
                return r_InformationDict["Location"];
            }
        }

        public string Hometown
        {
            get
            {
                return r_InformationDict["Hometown"];
            }
        }

        public string Relationship
        {
            get
            {
                return r_InformationDict["RelationshipStatus"];
            }
        }

        public string Birthday
        {
            get
            {
                return r_InformationDict["Birthday"];
            }
        }

        public string Email
        {
            get
            {
                return r_InformationDict["Email"];
            }
        }

        public string Gender
        {
            get
            {
                return r_InformationDict["Gender"];
            }
        }


        public Friend(User i_User)
        {
            r_User = i_User;
            r_InformationDict = new Dictionary<string, string>();
            r_Name = i_User.Name;
            populateBasicInfo();
        }

        private void populateBasicInfo()
        {
            string location = String.IsNullOrEmpty(r_User.Location.Name) ? "Not Specified" : r_User.Location.Name;
            string gender = String.IsNullOrEmpty(r_User.Gender.ToString()) ? "Not Specified" : r_User.Gender.ToString();
            string relationshipStatus = r_User.RelationshipStatus == null ? "Not Specified" : r_User.RelationshipStatus.ToString();
            string hometown = r_User.Hometown == null ? "Not Specified" : r_User.Hometown.Name;
            string birthday = String.IsNullOrEmpty(r_User.Birthday) ? "Not Specified" : r_User.Birthday;
            string email = String.IsNullOrEmpty(r_User.Email) ? "Not Specified" : r_User.Email;
            string profilePictureUrl = String.IsNullOrEmpty(r_User.PictureNormalURL) ? string.Empty : r_User.PictureNormalURL;

            r_InformationDict.Add("Name", r_User.Name);
            r_InformationDict.Add("Gender", gender);
            r_InformationDict.Add("RelationshipStatus", relationshipStatus);
            r_InformationDict.Add("Location", location);
            r_InformationDict.Add("Hometown", hometown);
            r_InformationDict.Add("Birthday", birthday);
            r_InformationDict.Add("Email", email);
            r_InformationDict.Add("ProfilePictureURL", profilePictureUrl);
        }

        public string GetFriendInfo(string i_Category)
        {
            string key = i_Category;
            string value = r_InformationDict[key];
            return value;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
