using System;
// using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {

      Game game = new Game();
      Console.WriteLine("Enter player 1's sign:");
      string input1 = Console.ReadLine().ToLower();
      Console.WriteLine("Enter player 2's sign:");
      string input2 = Console.ReadLine().ToLower();
      game.AssignSigns(input1, input2);
      Console.WriteLine($"{game.Player1Sign} v. {game.Player2Sign} = {game.CheckWinner()}");
      
    }
  }
}
