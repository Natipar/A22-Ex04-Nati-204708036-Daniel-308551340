namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_MainMenuItem;

        public MenuItem MainMenuItem
        {
            get { return r_MainMenuItem; }
        }

        public MainMenu(string i_MenuTitle)
        {
            r_MainMenuItem = new MenuItem(i_MenuTitle);
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            r_MainMenuItem.AddItem(i_ItemToAdd);
        }

        public void Show()
        {
            r_MainMenuItem.ItemChosen();
        }
    }
}