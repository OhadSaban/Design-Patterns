using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class HometownFilter : IFilter
    {
        private string r_Name;

        private string[] r_Values;

        private string m_CurrentValue;

        public string Name
        {
            get
            {
                return r_Name;
            }
        }

        public string[] Values
        {
            get
            {
                string[] valuesArr = new string[r_Values.Length];
                r_Values.CopyTo(valuesArr, 0);
                return valuesArr;
            }
        }

        public string CurrentValue
        {
            get
            {
                return m_CurrentValue;
            }

            set
            {
                bool isValid = isValidValue(value);
                if (isValid)
                {
                    m_CurrentValue = value;
                }
            }
        }

        public HometownFilter()
        {
            r_Name = "Hometown";
            m_CurrentValue = "All";
            r_Values = new string[] { "All", "Same", "Different" };
        }

        public bool ValidateItem(string i_ItemProperty)
        {
            bool isValidItem = false;
            if (m_CurrentValue.Equals("All"))
            {
                isValidItem = true;
            }
            else
            {
                isValidItem = isValueMatchCurrentValue(i_ItemProperty);
            }

            return isValidItem;
        }

        private bool isValidValue(string i_Value)
        {
            bool isValid = r_Values.Contains(i_Value);
            return isValid;
        }

        private bool isValueMatchCurrentValue(string i_InputValue)
        {
            bool isMatching = false;
            if (isValidValue(i_InputValue))
            {
                isMatching = m_CurrentValue.Equals(i_InputValue);
            }

            return isMatching;
        }
    }
}
