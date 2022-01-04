namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly MenuItem r_AllMainMenuItems;

        public MenuItem AllMainMenuItems
        {
            get { return r_AllMainMenuItems; }
        }

        public MainMenu(string i_MenuTitle)
        {
            r_AllMainMenuItems = new MenuItem(i_MenuTitle);
        }


        public void Show()
        {
            r_AllMainMenuItems.ItemSelectedFunction();
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_AllMainMenuItems.AddItem(i_ItemToAdd);
        }

    }
}