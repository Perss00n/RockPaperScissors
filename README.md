# Rock Paper Scissors Game

This is a simple console-based Rock Paper Scissors game implemented in C# by me. It is part of my learning journey as I practice my coding skills to become a backend developer. The game allows you to play against the computer, keeps track of the scores, and gives you the option to play multiple rounds.

## Features

- User-friendly console interface.
- Random computer choices.
- Score tracking for both the user and the computer.
- Option to play multiple rounds.

## How to Play

1. Run the program.
2. Enter your choice: "Rock", "Paper", or "Scissors".
3. The computer will randomly select its choice.
4. The winner of the round is determined and the scores are updated.
5. You will be asked if you want to play again.
6. The game will display the final score when you decide to stop playing.

## Code Overview

The game logic is implemented in the `Program` class within the `RockPaperScissors` namespace. Here's a brief overview of the main components:

- `ComputerChoice()`: Generates a random choice for the computer.
- `UserChoice()`: Prompts the user to enter their choice and validates the input.
- `DetermineWinner()`: Determines the winner of the round based on the user and computer choices.
- `PlayAgain()`: Asks the user if they want to play another round and displays the final scores if they choose to stop.
- `Main()`: The main game loop that ties everything together.


