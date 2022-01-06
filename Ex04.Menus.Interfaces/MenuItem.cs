using System.Collections.Generic;
using System;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public IMenuItemOperation m_ItemOperation;
        private const int k_GoBack = 0;
        private readonly List<MenuItem> r_ItemsList = new List<MenuItem>();
        private readonly string r_Title;
        private string m_PrevItem = null;

        public MenuItem(string i_Title)
        {
            this.r_Title = i_Title;
        }

        public List<MenuItem> ItemList
        {
            get { return r_ItemsList; }
        }

        public IMenuItemOperation ItemOperation
        {
            get
            {
                return m_ItemOperation;
            }

            set
            {
                m_ItemOperation = value;
            }
        }

        public void ItemChosen()
        {
            m_ItemOperation.onItemSelected(this);
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_ItemsList.Add(i_ItemToAdd);
            i_ItemToAdd.PrevItem = this.Title;
        }

        public string PrevItem
        {
            get
            {
                return this.m_PrevItem;
            }

            set
            {
                this.m_PrevItem = value;
            }
        }

        public string Title
        {
            get
            {
                return this.r_Title;
            }
        }
        
        public string getTitleToPrint()
        {
            string titleToReturn = null;
            titleToReturn = string.Format("** {0} **", Title) + Environment.NewLine;
            titleToReturn += "---";
            foreach (char c in Title)
            {
                titleToReturn+="-";
            }
            titleToReturn += "---";
            return titleToReturn;
        }
    }
}