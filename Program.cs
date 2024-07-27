using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static bool playAgain = true;
        static int computerPoints = 0;
        static int points = 0;

        static string ComputerChoice()
        {
            Random random = new Random();
            int randomNr = random.Next(1, 4);
            switch (randomNr)
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
                default:
                    return "ROCK";
            }
        }

        static string UserChoice()
        {
            string userChoice;
            while (true)
            {
                Console.WriteLine("Rock, Paper, or Scissors?");
                userChoice = Console.ReadLine().ToUpper();

                if (userChoice == "ROCK" || userChoice == "PAPER" || userChoice == "SCISSORS")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            return userChoice;
        }

        static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "It's a Draw!";
            }
            else if ((userChoice == "ROCK" && computerChoice == "SCISSORS") ||
                     (userChoice == "PAPER" && computerChoice == "ROCK") ||
                     (userChoice == "SCISSORS" && computerChoice == "PAPER"))
            {
                points++;
                return "You Win!";
            }
            else
            {
                computerPoints++;
                return "Computer Wins!";
            }
        }

        static bool PlayAgain()
        {
            while (true)
            {
                Console.Write("Play Again? (Y/N): ");
                string input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    Console.WriteLine($"Final Score: Computer {computerPoints} || You: {points}");
                    Console.WriteLine("Thanks for playing! See you later!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter Y or N.");
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                string userChoice = UserChoice();
                string computerChoice = ComputerChoice();

                Console.WriteLine($"You chose {userChoice}\nComputer chose {computerChoice}");
                Console.WriteLine(DetermineWinner(userChoice, computerChoice));
                Console.WriteLine($"Your score: {points} || Computer's score: {computerPoints}");

            } while (PlayAgain());

            Console.ReadLine();
        }
    }
}
