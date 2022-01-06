using System;
using System.Linq;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public struct CountCapitals : IMenuItemOperation
    {
        private void countCapitals()
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

        public void onItemSelected(MenuItem i_MenuItem)
        {
            countCapitals();
        }
    }

    public struct ShowVersion : IMenuItemOperation
    {
        void IMenuItemOperation.onItemSelected(MenuItem i_MenuItem)
        {
            Console.WriteLine("Version: 22.1.4.8930");
            Program.PressAnyKeyToContinue();
        }
    }

    public struct ShowTime : IMenuItemOperation
    {
        public void onItemSelected(MenuItem i_MenuItem)
        {
            Console.WriteLine("The current time is: {0}", DateTime.Now.ToString("HH:mm"));
            Program.PressAnyKeyToContinue();
        }
    }

    public struct ShowDate : IMenuItemOperation
    {
        public void onItemSelected(MenuItem i_MenuItem)
        {
            Console.WriteLine("The current date is: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
            Program.PressAnyKeyToContinue();
        }
    }       

    public struct DisplayItem : IMenuItemOperation // TODO : Adjust to same build as delegates method
    {
        public void DisplayInnerMenu(MenuItem i_MenuItem)
        {
            int goBack = 0;
            int itemCounter = 0;
            int userInput;

            do
            {
                Console.Clear();
                //Console.WriteLine(i_MenuItem.Title);
                Console.WriteLine(i_MenuItem.getTitleToPrint());
                Console.WriteLine(string.Format(@"{0}. {1}", itemCounter++, i_MenuItem.PrevItem == null ? "Exit" : "Back"));

                foreach (MenuItem item in i_MenuItem.ItemList)
                {
                    Console.WriteLine(string.Format(@"{0}. {1}", itemCounter++, item.Title));
                }

                userInput = getChoiceFromUser(goBack, itemCounter - 1);

                if (userInput != goBack)
                {
                    Console.Clear();
                    i_MenuItem.ItemList[userInput - 1].ItemChosen();
                }

                itemCounter = 0;
            }
            while (userInput != goBack);

            Console.WriteLine("Exiting {0}, bye bye :)", i_MenuItem.Title);
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
        }

        private static int getChoiceFromUser(int i_MinNumber, int i_ItemCount)
        {
            bool validInput;
            string msgToUser = string.Format(@"{0}Please select option ({1}-{2}):", Environment.NewLine, i_MinNumber, i_ItemCount);

            Console.WriteLine(msgToUser);
            validInput = int.TryParse(Console.ReadLine(), out int inputNumber);

            while (!validInput || inputNumber > i_ItemCount || inputNumber < i_MinNumber)
            {
                msgToUser = string.Format(@"Invalid input, please try again:({0}-{1})", i_MinNumber, i_ItemCount);
                Console.WriteLine(msgToUser);
                validInput = int.TryParse(Console.ReadLine(), out inputNumber);
            }

            return inputNumber;
        }

        void IMenuItemOperation.onItemSelected(MenuItem i_MenuItem)
        {
            DisplayInnerMenu(i_MenuItem);
        }
    }
}
