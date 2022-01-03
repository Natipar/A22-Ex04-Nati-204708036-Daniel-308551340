using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public static class CreatorOfInterfacesMenu
    {
        public static MainMenu CreateMenu()
        {
            MainMenu mainMenu = new MainMenu("Main Interfaces");
            MenuItem versionAndSpaces = new MenuItem("Version And Spaces");
            MenuItem dateAndTime = new MenuItem("Show Date/Time");
            MenuItem countSpaces = new MenuItem("Count Spaces");
            MenuItem showVersion = new MenuItem("Show Version");
            MenuItem showTime = new MenuItem("Show Time");
            MenuItem showDate = new MenuItem("Show Date");

            mainMenu.MainMenuItem.ItemOperation = new DisplayItem();
            versionAndSpaces.ItemOperation = new DisplayItem();
            dateAndTime.ItemOperation = new DisplayItem();
            countSpaces.ItemOperation = new CountSpaces();
            showVersion.ItemOperation = new ShowVersion();
            showTime.ItemOperation = new ShowTime();
            showDate.ItemOperation = new ShowDate();
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