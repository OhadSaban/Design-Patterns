using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    class ListPage
    {
        private int m_Size;
        private int m_PageIndex;
        private int[] m_ItemsIndicies;
        private int m_AvailableCellIndex;

        public int Size
        {
            get
            {
                return m_Size;
            }
        }

        public int StartIndex
        {
            get
            {
                return m_ItemsIndicies[0];
            }
        }

        public int EndIndex
        {
            get
            {
                return m_ItemsIndicies[Size - 1];
            }
        }

        public int PageNumber
        {
            get
            {
                return m_PageIndex;
            }
        }

        public ListPage(int i_PageIndex, int i_PageSize)
        {
            m_Size = i_PageSize;
            m_PageIndex = i_PageIndex;
            m_ItemsIndicies = new int[m_Size];
        }

        public void AddItem(int i_ItemIndex)
        {
            if (m_AvailableCellIndex < m_Size)
            {
                m_ItemsIndicies[m_AvailableCellIndex] = i_ItemIndex;
                m_AvailableCellIndex++;
            }
        }

        public int[] GetItems()
        {
            int[] copyArr = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                copyArr[i] = m_ItemsIndicies[i];
            }

            return copyArr;
        }

        public int GetItem(int i_Index)
        {
            return m_ItemsIndicies[i_Index];
        }
    }
}
