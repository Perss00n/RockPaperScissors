/*
CREATED BY Perss00n
Email: Perss00n@gmail.com
Discord: Perss00n
*/
using System;

namespace RockPaperScissors
{
    internal class Program
    {
        // Static variables to keep track of the game state
        static bool playAgain = true;
        static int computerPoints = 0;
        static int points = 0;

        // Method to generate a random choice for the computer
        static string ComputerChoice()
        {
            Random random = new Random(); // Create a new instance of the Random class
            int randomNr = random.Next(1, 4); // Generate a random number between 1 and 3 (inclusive)
            switch (randomNr)
            {
                case 1:
                    return "ROCK"; // Return "ROCK" if the random number is 1
                case 2:
                    return "PAPER"; // Return "PAPER" if the random number is 2
                case 3:
                    return "SCISSORS"; // Return "SCISSORS" if the random number is 3
                default:
                    return "ROCK"; // Default case (should not be hit)
            }
        }

        // Method to get and validate the user's choice
        static string UserChoice()
        {
            string userChoice;
            while (true) // Loop until a valid choice is made
            {
                Console.WriteLine("Rock, Paper, or Scissors?"); // Prompt user for input
                userChoice = Console.ReadLine().ToUpper(); // Read input and convert to uppercase

                // Check if the input is one of the valid choices
                if (userChoice == "ROCK" || userChoice == "PAPER" || userChoice == "SCISSORS")
                {
                    break; // Exit the loop if valid choice is made
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again."); // Inform the user of invalid input
                }
            }
            return userChoice; // Return the valid user choice
        }

        // Method to determine the winner based on user and computer choices
        static string DetermineWinner(string userChoice, string computerChoice)
        {
            // Check if it's a draw
            if (userChoice == computerChoice)
            {
                return "It's a Draw!";
            }
            // Check if the user wins
            else if ((userChoice == "ROCK" && computerChoice == "SCISSORS") ||
                     (userChoice == "PAPER" && computerChoice == "ROCK") ||
                     (userChoice == "SCISSORS" && computerChoice == "PAPER"))
            {
                points++; // Increment user's score
                return "You Win!";
            }
            else
            {
                computerPoints++; // Increment computer's score
                return "Computer Wins!";
            }
        }

        // Method to ask if the user wants to play again
        static bool PlayAgain()
        {
            while (true) // Loop until valid input is received
            {
                Console.Write("Play Again? (Y/N): "); // Prompt user for input
                string input = Console.ReadLine().ToUpper(); // Read input and convert to uppercase
                if (input == "Y")
                {
                    return true; // Return true to continue playing
                }
                else if (input == "N")
                {
                    // Display final scores and thank the user
                    Console.WriteLine($"Final Score: Computer {computerPoints} || You: {points}");
                    Console.WriteLine("Thanks for playing! See you later!");
                    return false; // Return false to end the game
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter Y or N."); // Inform user of invalid input
                }
            }
        }

        // Main method where the game loop is executed
        static void Main(string[] args)
        {
            // Game loop that continues while PlayAgain() returns true
            do
            {
                string userChoice = UserChoice(); // Get the user's choice
                string computerChoice = ComputerChoice(); // Get the computer's choice

                // Display choices and result
                Console.WriteLine($"You chose {userChoice}\nComputer chose {computerChoice}");
                Console.WriteLine(DetermineWinner(userChoice, computerChoice));
                Console.WriteLine($"Your score: {points} || Computer's score: {computerPoints}");

            } while (PlayAgain()); // Continue the loop if the user wants to play again

            Console.ReadLine(); // Keep the console window open until a key is pressed
        }
    }
}
