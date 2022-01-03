using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class CreatorOfDelegatesMenu
    {
        public static MainMenu CreateMenu()
        {
            MainMenu mainMenu = new MainMenu("Main Delegates");
            MenuItem versionAndSpaces = new MenuItem("Version And Spaces");
            MenuItem dateAndTime = new MenuItem("Show Date/Time");
            MenuItem countSpaces = new MenuItem("Count Spaces");
            MenuItem showVersion = new MenuItem("Show Version");
            MenuItem showTime = new MenuItem("Show Time");
            MenuItem showDate = new MenuItem("Show Date");

            mainMenu.MainMenuList.ItemChosen += DelegatesMethods.MenuItem_ItemChosen_DisplayInnerMenu;
            versionAndSpaces.ItemChosen += DelegatesMethods.MenuItem_ItemChosen_DisplayInnerMenu;
            dateAndTime.ItemChosen += DelegatesMethods.MenuItem_ItemChosen_DisplayInnerMenu;
            countSpaces.ItemChosen += DelegatesMethods.MenuItem_ItemChosen_CountSpaces;
            showVersion.ItemChosen += DelegatesMethods.MenuItem_ItemChosen_ShowVersion;
            showTime.ItemChosen += DelegatesMethods.MenuItem_ItemChosen_ShowTime;
            showDate.ItemChosen += DelegatesMethods.MenuItem_ItemChosen_ShowDate;
            mainMenu.AddItem(versionAndSpaces);
            mainMenu.AddItem(dateAndTime);
            versionAndSpaces.AddItem(countSpaces);
            versionAndSpaces.AddItem(showVersion);
            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);

            return mainMenu;
        }
    }
}