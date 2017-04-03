using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{ 
 public class Game
{
    public Player playerOne;
    public Player playerTwo;

    public Game()
    {

    }
    public void RunGame()
    {
        WelcomePlayer();
        PickPlayers();
        playerOne.GetPlayerName();
        playerTwo.GetPlayerName();
        Console.Clear();
        playerOne.GetPlayerChoice();
        Console.Clear();
        playerTwo.GetPlayerChoice();
        string roundWinner = PickAWinner();
        GetWinner(roundWinner);
        DisplayScore();
        TrackWins();
    }
    private void RestartRound()
    {
        playerOne.GetPlayerChoice();
        Console.Clear();
        playerTwo.GetPlayerChoice();
        Console.Clear();
        string roundWinner = PickAWinner();
        GetWinner(roundWinner);
        DisplayScore();
        TrackWins();
        RestartGame();
    }
    private void WelcomePlayer()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        Console.WriteLine("The rules of the game:\nRock destroys Scissors and pwns Lizard\n\nPaper pwns Rock and destroys Spock\n\nScissors slices paper and romoves the head of Lizard\n\nLizard whips Spock and consumes Paper\n\nSpock deconstructs Scissors and eplodes Rock\n");
    }
    private string PickPlayers()
    {
        Console.WriteLine("How many people will be playing, '1' or '2'?");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            playerOne = new Human();
            playerTwo = new Computer();
        }
        else if (userInput == "2")
        {
            playerOne = new Human();
            playerTwo = new Human();
        }
        else
        {
            Console.WriteLine("I dont think you understood the question...");
            PickPlayers();
        }
        return userInput;
    }
    private string PickAWinner()
    {
        string winner = "";

        if (playerOne.choice == "Rock" && (playerTwo.choice == "Scissors" || playerTwo.choice == "Lizard"))
        {
            winner = playerOne.choice;
            Console.WriteLine($"{playerOne.name} wins the round!");
        }
        else if (playerOne.choice == "paper" && (playerTwo.choice == "rock" || playerTwo.choice == "spock"))
        {
            winner = playerOne.choice;
            Console.WriteLine($"{playerOne.name} wins the round!");
        }
        else if (playerOne.choice == "scissors" && (playerTwo.choice == "paper" || playerTwo.choice == "lizard"))
        {
            winner = playerOne.choice;
            Console.WriteLine($"{playerOne.name} wins the round!");
        }
        else if (playerOne.choice == "lizard" && (playerTwo.choice == "paper" || playerTwo.choice == "spock"))
        {
            winner = playerOne.choice;
            Console.WriteLine($"{playerOne.name} wins the round!");
        }
        else if (playerOne.choice == "spock" && (playerTwo.choice == "rock" || playerTwo.choice == "scissors"))
        {
            winner = playerOne.choice;
            Console.WriteLine($"{playerOne.name} wins the round!");
        }
        else if (playerTwo.choice == "rock" && (playerOne.choice == "scissors" || playerOne.choice == "lizard"))
        {
            winner = playerTwo.choice;
            Console.WriteLine($"{playerTwo.name} wins the round!");
        }
        else if (playerTwo.choice == "paper" && (playerOne.choice == "rock" || playerOne.choice == "spock"))
        {
            winner = playerTwo.choice;
            Console.WriteLine($"{playerTwo.name} wins the round!");
        }
        else if (playerTwo.choice == "scissors" && (playerOne.choice == "paper" || playerOne.choice == "lizard"))
        {
            winner = playerTwo.choice;
            Console.WriteLine($"{playerTwo.name} wins the round!");
        }
        else if (playerTwo.choice == "lizard" && (playerOne.choice == "paper" || playerOne.choice == "spock"))
        {
            winner = playerTwo.choice;
            Console.WriteLine($"{playerTwo.name} wins the round!");
        }
        else if (playerTwo.choice == "spock" && (playerOne.choice == "rock" || playerOne.choice == "scissors"))
        {
            winner = playerTwo.choice;
            Console.WriteLine($"{playerTwo.name} wins the round!");
        }
        else
        {
            Console.WriteLine("It's a Tie!");
        }
        return winner;
    }
    private void GetWinner(string roundWinner)
    {
        if (roundWinner == playerOne.choice)
        {
            playerOne.score++;
        }
        else if (roundWinner == playerTwo.choice)
        {
            playerTwo.score++;
        }
    }
    private void DisplayScore()
    {
        Console.WriteLine($"{playerOne.name} \nScore:{playerOne.score}\n");
        Console.WriteLine($"{playerTwo.name} \nScore:{playerTwo.score}\n");
    }
    private void TrackWins()
    {
        if (playerOne.score == 3)
        {
            Console.WriteLine($"{playerOne.name} wins the game!");
        }
        else if (playerTwo.score == 3)
        {
            Console.WriteLine($"{playerTwo.name} wins the game!");
        }
        else
        {
            RestartRound();
        }
    }
    private string RestartGame()
    {
        Console.WriteLine("Would you like to restart the game, 'yes' or 'no'");
        string userInput = Console.ReadLine();
        if (userInput == "yes")
        {
            RunGame();
        }
        else if (userInput == "no")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("I dont think you understood the question...");
            RestartGame();
        }
        return userInput;
    }
}
}
