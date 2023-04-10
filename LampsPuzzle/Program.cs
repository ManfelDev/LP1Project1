using System;

namespace LampsPuzzle
{   
    class Program
    {   
        /// <summary>
        /// Method that sets the game loop and calls the methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numberOfPlays = 6;

            Introduction();

            // Loop for the game
            for (int i = 0; i < numberOfPlays; i++)
            {
                int choice = SetPlayerChoice();
                ButtonChosen(choice);
            }

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

        /// <summary>
        /// Method that sets and reads the player choice
        /// </summary>
        /// <returns>The choice of the player</returns>
        private static int SetPlayerChoice()
        {
            bool isValid = false; // Variable to verify if the choice is valid
            int choice = 0; // Variable to store the choice of the player

            // While the choice is invalid
            // (We searched the web for how to use "try" and "catch",
            // and we clarified it in ChatGPT)
            while (!isValid)
            {
                try
                {
                    // Prints the choice of buttons
                    Console.WriteLine("Choose a the button (1-3)");
                    // Reads the choice of the player
                    choice = Convert.ToInt32(Console.ReadLine());
                    // Verify if the choice is valid
                    if (choice >= 1 && choice <= 3)
                        isValid = true;
                    // If the choice is invalid
                    else if (choice < 1 || choice > 3)
                        throw new FormatException();
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid button, please choose a " +
                                      "right one (1, 2 or 3)!");
                    PressAnyKeyToContinue();
                }
            }

            return choice;
        }

        /// <summary>
        /// Method to store the state of the lamps and initialize them as off
        /// </summary>
        private static LampState lampState = LampState.Off;

        /// <summary>
        /// Method that activates the button chosen by the player
        /// </summary>
        /// <param name="choice">Button chose by the player</param>
        /// <returns>The state of the lamps after the player's choice</returns>
        private static int ButtonChosen(int choice)
        {
            if (choice == 1) // Activate the first button
                {
                    // Do something
                } 
            else if (choice == 2) // Activate the second button
                {   
                    // Do something
                }
            else if (choice == 3) // Activate the third button
                {
                    // Do something
                }

            return (int)lampState;
        }
    }
}