using System;
using System.Linq;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class DelegatesMethods
    {
        public static void MenuItem_ItemSelected_DisplayMenu(MenuItem i_MenuItem)
        {
            int itemCounter = 0;
            int userInput;
            int goBackFlag = 0;

            do
            {
                Console.Clear();
                i_MenuItem.PrintLabel();

                foreach (MenuItem item in i_MenuItem.ItemList)
                {
                    Console.WriteLine(string.Format(@"{0}. {1}", ++itemCounter, item.Label));
                }

                Console.WriteLine(string.Format(@"0. {0}", i_MenuItem.PrevItem == null ? "Exit" : "Back"));
                itemCounter++; // Adding the Exit/Back item

                userInput = getUserSelection(goBackFlag, itemCounter - 1);

                if (userInput != goBackFlag)
                {
                    Console.Clear();
                    i_MenuItem.ItemList[userInput - 1].ItemSelectedFunction();
                }

                itemCounter = 0;
            }
            while (userInput != goBackFlag);

            Console.WriteLine("Exiting {0}, bye bye :)",i_MenuItem.Label);
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
        }

        public static void MenuItem_ItemSelected_ShowTime(MenuItem i_MenuItem)
        {
            Console.WriteLine("The current time is: {0}", DateTime.Now.ToString("HH:mm"));
            Program.PressAnyKeyToContinue();
        }

        public static void MenuItem_ItemSelected_ShowDate(MenuItem i_MenuItem)
        {
            Console.WriteLine("The current date is: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
            Program.PressAnyKeyToContinue();
        }


        public static void MenuItem_ItemSelected_CountCapitals(MenuItem i_MenuItem)
        {
            int capitalsCounter = 0;
            Console.WriteLine("Please enter a sentence to count its uppercase letters: ");
            string stringToCount = Console.ReadLine();
            if (stringToCount != null)
            {
                for (int i = 0; i < stringToCount.Length; i++)
                {
                    if (char.IsUpper(stringToCount[i]))
                    {
                        capitalsCounter++;
                    }
                }
            }

            Console.WriteLine("There are {0} capital letters in the sentence.", capitalsCounter);
            Program.PressAnyKeyToContinue();
        }

        public static void MenuItem_ItemSelected_ShowVersion(MenuItem i_MenuItem)
        {
            Console.WriteLine("Version: 22.1.4.8930");
            Program.PressAnyKeyToContinue();
        }


        private static int getUserSelection(int i_MinNumber, int i_ItemCount) // TODO: Review it works proeprly
        {
            bool validInput;
            string msgToUser = string.Format(@"{0}Please select option [{1} - {2}]:", Environment.NewLine, i_MinNumber, i_ItemCount);

            Console.WriteLine(msgToUser);
            validInput = int.TryParse(Console.ReadLine(), out int inputNumber);

            while (!validInput || inputNumber > i_ItemCount || inputNumber < i_MinNumber)
            {
                msgToUser = string.Format(@"Invalid input, please try again:[{0} - {1}]", i_MinNumber, i_ItemCount);
                Console.WriteLine(msgToUser);
                validInput = int.TryParse(Console.ReadLine(), out inputNumber);
            }

            return inputNumber;
        }
    }
}
