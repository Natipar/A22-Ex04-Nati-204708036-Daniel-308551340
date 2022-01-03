namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItemList;

        public MenuItem MainMenuList
        {
            get { return r_MenuItemList; }
        }

        public MainMenu(string i_MenuTitle)
        {
            r_MenuItemList = new MenuItem(i_MenuTitle);
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_MenuItemList.AddItem(i_ItemToAdd);
        }

        public void Show()
        {
            r_MenuItemList.ItemChosenFunc();
        }
    }
}