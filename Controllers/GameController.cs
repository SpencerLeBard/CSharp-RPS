using System;

namespace rockpaperscissors.Controllers
{
  class GameController
  {
    public void Run()
    {
      GetUserInput();
    }

    private void GetUserInput()
    {
      System.Console.WriteLine("Rock, Paper, or Scissors?");
      var input = Console.ReadLine().ToLower();

      switch (input)
      {
        case "rock":
        case "paper":
        case "scissors":
          Game();
          break;
        // case "rock":
        //   System.Console.WriteLine("You Lose");
        //   break;
        // case "paper":
        //   System.Console.WriteLine("You Lose");
        //   break;
        // case "scissors":
        //   System.Console.WriteLine("You Win");
        //   break;
        default:
          System.Console.WriteLine("Wrong Answer");
          break;
      }
    }
    private void Game()
    {
      Random rnd = new Random();
      int number = rnd.Next(1, 100);
      if (number <= 33)
      {
        Console.WriteLine("You Win");
      }
      else if (number <= 66)
      {
        Console.WriteLine("You Tied");
      }
      else
      {
        Console.WriteLine("You Lose");
      }

    }
  }
}