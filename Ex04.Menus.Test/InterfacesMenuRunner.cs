using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public static class InterfacesMenuRunner
    {
        public static MainMenu CreateMenu()
        {
            MainMenu mainMenu = new MainMenu("Interfaces Main Menu");
            MenuItem versionAndCapitals = new MenuItem("Version And Capitals");
            MenuItem dateAndTime = new MenuItem("Show Date/Time");
            MenuItem countCapitals = new MenuItem("Count Capitals");
            MenuItem showVersion = new MenuItem("Show Version");
            MenuItem showTime = new MenuItem("Show Time");
            MenuItem showDate = new MenuItem("Show Date");

            mainMenu.MainMenuItem.ItemOperation = new DisplayItem();
            versionAndCapitals.ItemOperation = new DisplayItem();
            dateAndTime.ItemOperation = new DisplayItem();
            countCapitals.ItemOperation = new CountCapitals();
            showVersion.ItemOperation = new ShowVersion();
            showTime.ItemOperation = new ShowTime();
            showDate.ItemOperation = new ShowDate();
            mainMenu.AddMenuItem(versionAndCapitals);
            mainMenu.AddMenuItem(dateAndTime);
            versionAndCapitals.AddItem(countCapitals);
            versionAndCapitals.AddItem(showVersion);
            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);

            return mainMenu;
        }
    }
}