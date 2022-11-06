using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_CollectionGenerics
{
    class Menu
    {

        public static void ShowMenu()
        {
            // Creates an instantiation 
            Stack Stack = new Stack();
            List List = new List();

            // Menu options
            // String of available menuoptions
            string[] menuOptions = new string[] { "Stack", "List", "Exit" };
            int menuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                char prefix = '*';

                Console.WriteLine("Welcome to Kristinas Stack and List project!\n*********************************************\n");
                Console.WriteLine("Choose one option in menu by using the arrow keys and then press enter: ");
                Console.WriteLine("-----------------------------------------------------------------------\n");

                // Output the available menu to choose from by using the arrow keys
                if (menuSelect == 0)
                {
                    Console.WriteLine($"{prefix}  << " + menuOptions[0] + " >>");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                }
                else if (menuSelect == 1)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine($"{prefix}  << " + menuOptions[1] + " >>");
                    Console.WriteLine(menuOptions[2]);
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine($"{prefix}  << " + menuOptions[2] + " >>");
                }
                // Allow the user to use arrow keys to go "up" and "down" in menu
                var keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                // Allow confirmation with Enter key
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    // The function of choices
                    switch (menuSelect)
                    {
                        case 0:
                            Stack.MyStack();
                            break;
                        case 1:
                            List.MyList();
                            break;
                        case 2:
                            Exit();
                            break;
                    }
                }
            }
        }

        // Method that exit the program
        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Exit the program!");
            Environment.Exit(0);
        }
    }
}

