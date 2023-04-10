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
            int numberOfPlays = 6; // Number of plays the player can do

            Introduction();

            // Loop for the game
            for (int i = 0; i < numberOfPlays; i++)
            {
                int choice = SetPlayerChoice(i);
                ButtonChosen(choice);

                if (PlayerWin())
                    break; // Breaks the loop
                
                else if (PlayerLose(i, numberOfPlays))
                    break; // Breaks the loop

                Console.Clear(); // Clear the console
            }
        }

        /// <summary>
        /// Method that set and prints the introduction of the game
        /// </summary>
        static void Introduction()
        {   
            // Prints the introduction of the game
            Console.WriteLine("There are 3 lamps in a room " +
            "(Represented by '0's, if a lamp is red is turned off, " +
            "if a lamp is green is turned on)\n" +
            "You can press a button to switch the state of the lamps.\n" +
            "The first button switches the state of the first lamp.\n" +
            "The second button changes state between the first and second lamp.\n" +
            "The third button changes state between the second and third lamp.\n" +
            "The lamps are off at the beginning.\n" +
            "You have 6 chances to press the buttons.\n" +
            "You win if all the lamps are on.\n" +
            "You lose if you have pressed the buttons 6 times and " +
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
        private static int SetPlayerChoice(int i)
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
                    Console.WriteLine(LampsState());
                    // Prints the choice of buttons
                    Console.Write("CHOOSE A BUTTON (1-3)\n" +
                    "1. Switches the state of the first lamp\n" +
                    "2. Changes state between the first and second lamp\n" +
                    "3. Changes state between the second and third lamp\n" +
                    $"\nYou have pressed a button {i} time(s)\n" +
                    "\nSelected button: ");
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
            if (choice == 1)
                {
                    ActivateButton1();
                } 
            else if (choice == 2)
                {   
                    ActivateButton2();
                }
            else if (choice == 3)
                {
                    ActivateButton3();
                }

            return (int)lampState;
        }

        /// <summary>
        /// Method that changes the state of the first lamp
        /// </summary>
        /// <returns>The state of the lamps after the 1st button is pressed</returns>
        private static int ActivateButton1()
        {
            lampState ^= LampState.Lamp1On;

            return (int)lampState;
        }

        /// <summary>
        /// Method that changes the state of the first and second lamps
        /// </summary>
        /// <returns>The state of the lamps after the 2nd button is pressed</returns>
        private static int ActivateButton2()
        {
            if (((lampState & LampState.Lamp1On) != LampState.Lamp1On &&
                (lampState & LampState.Lamp2On) == LampState.Lamp2On) ||
                ((lampState & LampState.Lamp1On) == LampState.Lamp1On &&
                (lampState & LampState.Lamp2On) != LampState.Lamp2On))
            {
                lampState ^= LampState.Lamp1On;
                lampState ^= LampState.Lamp2On;
            }

            return (int)lampState;
        }

        /// <summary>
        /// Method that changes the state of the second and third lamps
        /// </summary>
        /// <returns>The state of the lamps after the 3rd button is pressed</returns>
        private static int ActivateButton3()
        {
            if (((lampState & LampState.Lamp2On) != LampState.Lamp2On &&
                (lampState & LampState.Lamp3On) == LampState.Lamp3On) ||
                ((lampState & LampState.Lamp2On) == LampState.Lamp2On &&
                (lampState & LampState.Lamp3On) != LampState.Lamp3On))
            {
                lampState ^= LampState.Lamp2On;
                lampState ^= LampState.Lamp3On;
            }

            return (int)lampState;
        }

        /// <summary>
        /// Method that checks the state of the lamps
        /// </summary>
        /// <returns>The state of the lamps</returns>
        private static string LampsState()
        {   
            string state = ""; // Variable to store the state of the lamps

            // (We searched the web for how to use colors in the console,
            // and we clarified it in ChatGPT)
            if ((lampState & LampState.Lamp1On) == LampState.Lamp1On)
                state += "\u001b[32m0 "; // '0' Green
            else
                state += "\u001b[31m0 "; // '0' Red

            if ((lampState & LampState.Lamp2On) == LampState.Lamp2On)
                state += "\u001b[32m0 "; // '0' Green
            else
                state += "\u001b[31m0 "; // '0' Red

            if ((lampState & LampState.Lamp3On) == LampState.Lamp3On)
                state += "\u001b[32m0 "; // '0' Green
            else
                state += "\u001b[31m0 "; // '0' Red

            // Append a reset color code to ensure that the console 
            // color is reset to the original color after the last lamp
            state += "\u001b[0m\n";

            return state;
        }

        /// <summary>
        /// Method that runs if the player wins or not
        /// </summary>
        /// <returns>If the player wins or not</returns>
        private static bool PlayerWin()
        {
            if ((lampState == (LampState.Lamp1On |
                               LampState.Lamp2On |
                               LampState.Lamp3On)))
            {
                Console.Clear(); // Clears the console
                Console.WriteLine(LampsState());
                Console.WriteLine("You win!"); // Prints the message of win
                return true;
            }

            else
                return false;
        }

        /// <summary>
        /// Method that runs if the player loses or not
        /// </summary>
        /// <param name="i">Check how many buttons have the player pressed</param>
        /// <param name="numberOfPlays">The number of plays</param>
        /// <returns>If the player loses or not</returns>
        private static bool PlayerLose(int i, int numberOfPlays)
        {
            if (i == numberOfPlays - 1)
            {
                Console.Clear(); // Clears the console
                Console.WriteLine(LampsState());
                Console.WriteLine("You have pressed the buttons 6 times " +
                                  "and did not complete the challenge! " +
                                  "You lost!"); // Prints the message of lose
                return true;
            }

            else
                return false;
        }
    }
}