using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesMenuRunner
    {
        public static MainMenu CreateMenu()
        {
            MainMenu mainMenu = new MainMenu("Delegates Main Menu");
            MenuItem dateAndTime = new MenuItem("Show Date/Time");
            MenuItem versionAndSpaces = new MenuItem("Version And Capitals");
            MenuItem showDate = new MenuItem("Show Date");
            MenuItem showTime = new MenuItem("Show Time");
            MenuItem countCapitals = new MenuItem("Count Capitals");
            MenuItem showVersion = new MenuItem("Show Version");

            mainMenu.AllMainMenuItems.ItemSelected += DelegatesMethods.MenuItem_ItemSelected_DisplayMenu;
            dateAndTime.ItemSelected += DelegatesMethods.MenuItem_ItemSelected_DisplayMenu;
            versionAndSpaces.ItemSelected += DelegatesMethods.MenuItem_ItemSelected_DisplayMenu;
            showDate.ItemSelected += DelegatesMethods.MenuItem_ItemSelected_ShowDate;
            showTime.ItemSelected += DelegatesMethods.MenuItem_ItemSelected_ShowTime;
            countCapitals.ItemSelected += DelegatesMethods.MenuItem_ItemSelected_CountCapitals;
            showVersion.ItemSelected += DelegatesMethods.MenuItem_ItemSelected_ShowVersion;
            mainMenu.AddItem(dateAndTime);
            mainMenu.AddItem(versionAndSpaces);
            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);
            versionAndSpaces.AddItem(countCapitals);
            versionAndSpaces.AddItem(showVersion);


            return mainMenu;
        }
    }
}
