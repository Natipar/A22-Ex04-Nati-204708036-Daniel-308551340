namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly MenuItem r_MainMenuItems;

        public MenuItem MainMenuItems
        {
            get { return r_MainMenuItems; }
        }

        public MainMenu(string i_MenuTitle)
        {
            r_MainMenuItems = new MenuItem(i_MenuTitle);
        }


        public void Show()
        {
            r_MainMenuItems.ItemSelectedFunction();
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            r_MainMenuItems.AddItem(i_ItemToAdd);
        }

    }
}