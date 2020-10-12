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
      }
    }
    private void Game()
    {
      Random rnd = new Random();
      int number = rnd.Next(1, 10);
      if (number <= 3)
      {
        Console.WriteLine("You Win");
      }
      else
      {
        Console.WriteLine("You Lose");
      }

    }
  }
}