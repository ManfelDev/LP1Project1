using System;

namespace LampsPuzzle
{   
    class Program
    {
        static void Main(string[] args)
        {
            Introduction();
        }

        /// <summary>
        /// Method that set and prints the introduction of the game
        /// </summary>
        static void Introduction()
        {   
            // Prints the introduction of the game
            Console.WriteLine("There are 3 lamps in a room. " +
            "You can press a button to switch the state of the lamps.\n" +
            "The first button switches the state of the first lamp.\n" +
            "The second button changes state between the first and second lamp.\n" +
            "The third button changes state between the second and third lamp.\n" +
            "The lamps are off at the beginning.\n" +
            "You have 6 chances to press the buttons.\n" +
            "You win if all the lamps are on.\n" +
            "You lose if you have press the buttons more than 6 times and " +
            "one or more lamps are still off.\n" +
            "Good luck!");

            PressAnyKeyToContinue();
        }
        
        /// <summary>
        /// Method that makes the console wait for the player to press any key,
        /// and then clear the console
        /// </summary>
        private static void PressAnyKeyToContinue()
        {   
            // Prints the message
            Console.WriteLine("\nPress any key to continue...");
            // Press any key to continue...
            Console.ReadKey();
            // Clear the console
            Console.Clear();
        }
    }
}
