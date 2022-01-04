using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private const int k_goBackFlag = 0;
        private readonly string r_Label;
        private string m_PrevMenu;
        private readonly List<MenuItem> r_MenuItemsList = new List<MenuItem>();

        public event Action<MenuItem> ItemSelected;

        public List<MenuItem> ItemList
        {
            get{ return r_MenuItemsList; }
        }

        public string Label
        {
            get { return this.r_Label; }
        }

        public string PrevItem
        {
            get {return this.m_PrevMenu;}
            set { this.m_PrevMenu = value; }
        }

        public MenuItem(string i_Title)
        {
            this.r_Label = i_Title;
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_MenuItemsList.Add(i_ItemToAdd);
            i_ItemToAdd.PrevItem = this.Label;
        }

        public void ItemSelectedFunction()
        {
            OnItemSelected();
        }

        protected virtual void OnItemSelected()
        {
            if (ItemSelected != null)
            {
                ItemSelected.Invoke(this);
            }
        }

        public void PrintLabel()
        {
            Console.WriteLine("** {0} **", Label);
            Console.Write("---");
            foreach(char c in Label)
            {
                Console.Write("-");
            }
            Console.WriteLine("---");
        }
    }
}