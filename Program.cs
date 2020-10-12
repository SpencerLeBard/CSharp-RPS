using System;
using rockpaperscissors.Controllers;

namespace rockpaperscissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine(@"
____  ____  ____  _  __   ____  ____  ____  _____ ____    ____  ____  _  ____  ____  ____  ____  ____ 
/  __\/  _ \/   _\/ |/ /  /  __\/  _ \/  __\/  __//  __\  / ___\/   _\/ \/ ___\/ ___\/  _ \/  __\/ ___\
|  \/|| / \||  /  |   /   |  \/|| / \||  \/||  \  |  \/|  |    \|  /  | ||    \|    \| / \||  \/||    \
|    /| \_/||  \_ |   \   |  __/| |-|||  __/|  /_ |    /  \___ ||  \_ | |\___ |\___ || \_/||    /\___ |
\_/\_\\____/\____/\_|\_\  \_/   \_/ \|\_/   \____\\_/\_\  \____/\____/\_/\____/\____/\____/\_/\_\\____/");
      Console.WriteLine("Hello, Neo");
      GameController gc = new GameController();
      gc.Run();
    }
  }
}
