using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Delegates.MainMenu menuDelegates = CreatorOfDelegatesMenu.CreateMenu();
            menuDelegates.Show();

            Interfaces.MainMenu menuInterface = CreatorOfInterfacesMenu.CreateMenu();
            menuInterface.Show();
        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}