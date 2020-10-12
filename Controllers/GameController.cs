using System;

namespace rockpaperscissors.Controllers
{
  class GameController
  {

    //properties 

    public string choice { get; private set; }

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
          System.Console.WriteLine("You Lose");
          break;
        case "paper":
          System.Console.WriteLine("You Lose");
          break;
        case "scissors":
          System.Console.WriteLine("You Win");
          break;
      }
    }

  }
}