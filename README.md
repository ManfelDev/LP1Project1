# Project 1 of "Linguagens de Programação 1"

### Objective of the Project:

Implement Implement a system called "Puzzle das Lâmpadas"(Lamps Puzzle) in the form of application in console in C# 8.0/.NET 6.0.

## Authored by

- [@Rafael-j-03](https://github.com/Rafael-j-03) - Rafael José - 22202078
- [@rodrigogomes01](https://github.com/rodrigogomes01) - Rodrigo Gomes - 22201252

## How our project was made

- The code production was done by Rafael José with the help of Rodrigo Gomes in some details while interpreting the project of the code as well as XML documentation and README.md development in which Rafael José helped with explaining in some technical aspects for a better understanding of the document.

- 1st commit - Added .gitignore and LP1Project1 solution; - Rafael José - 22202078

- 2nd commit - Added project 'LampsPuzzle'; - Rafael José - 22202078

- 3rd commit - Added an Introduction for the game, and a new method that makes the console wait for the player to press any key, and then clear the console; - Rafael José - 22202078

- 4th commit - Added the main loop for the game; - Rafael José - 22202078

- 5th commit - Added a method to set the player's choice while printing the buttons and checking if it is valid or not, and fix on the logic of the game loop; - Rafael José - 22202078

- 6th commit -  Added a enumeration that represents the state of the lamps, and a method to store the state of the lamps and initialize them as off; - Rodrigo Gomes - 22201252

- 7th commit - Added a method that activates the button chosen by the player; - Rodrigo Gomes - 22201252

- 8th commit - Added methods for each button, with their respective changes; - Rafael José - 22202078

- 9th commit - Added a method that checks the state of the lamps, and prints the state of each one by colors; - Rafael José - 22202078

- 10th commit - Added methods to check if the player win or lose defined by the conditions of each one; - Rafael José - 22202078

- 11th and 12th commit - Fixes on some comments and text, and added better visual understanding and game design elements for the code; - Rafael José - 22202078

- 13th commit - Added Console.Clean when the game starts; - Rafael José - 22202078

- 14th commit - Added README.md; - Rodrigo Gomes - 22201252

- 15th commit - Added .gitignore and flowchart; - Rodrigo Gomes - 22201252

- 16th commit - Updated README.md; - Rodrigo Gomes - 22201252

- 17th commit - Changed win message; - Rafael José - 22202078

- 18th commit - Updated README.md; - Rodrigo Gomes - 22201252

[Git Repository](https://github.com/Rafael-j-03/LP1Project1)

## Development of our work

- We started by creating the project in our git repository which we used to communicate and develop our project;

- We interpret the project's statement and with that we started our code by adding an introduction with a method that prints the initial details of the game as well as a method that waits for the player to press a key and then clear the console;

- The main game loop works with a for loop that sets the game loop by the condition that the player can press the buttons until he reaches the maximum of his plays (6) consequently calls the methods when it is inside the loop;

- We created an enumeration that represents the state of the lamps and added a method that stores the state of the lamps and initialize them as off;

- We added a method to set the player choice, that will print, again, what every button does and let the player pick one. This method will read the player´s choice using a variable to check if the player's choice is valid and if it is that stores the player's choice;

- Depending on the choice of the player we added a method that activates the button chosen by the player;

- Each button has a method that changes the state of the lamps and returns their states respectively depending on the button chosen by the player;

- A new method was added to activate the button chosen by the player;

- We added a method that checks the state of the lamps and prints the state of each one by colors;

- By the end of the game we added a method that checks if the player wins or loses, on a maximum of 6 plays and a loop break in case of victory or loss and clear the console, print the lamp states and the respective message for each case (win or lose) and then the game ends;

## Flowchart

![Flowchart](./flowchart.png)

## References

- We've searched on the web for how to use "try" and "catch", more specifically on StackOverflow and .NET api, and we clarified some doubts with code suggested by ChatGPT;

- We've also searched on the web for how to use colors in the console, more specifically on StackOverflow and .NET api, and we clarified some doubts with code suggested by ChatGPT;
