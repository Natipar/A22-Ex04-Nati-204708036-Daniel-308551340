using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private const int k_GoBack = 0;
        private readonly List<MenuItem> r_ItemsList = new List<MenuItem>();
        private readonly string r_Title;
        private string m_PrevItem;

        public event Action<MenuItem> ItemChosen;

        public List<MenuItem> ItemList
        {
            get
            {
                return r_ItemsList;
            }
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

        public MenuItem(string i_Title)
        {
            this.r_Title = i_Title;
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_ItemsList.Add(i_ItemToAdd);
            i_ItemToAdd.PrevItem = this.Title;
        }

        public void ItemChosenFunc()
        {
            OnItemChosen();
        }

        protected virtual void OnItemChosen()
        {
            if (ItemChosen != null)
            {
                ItemChosen.Invoke(this);
            }
        }
    }
}