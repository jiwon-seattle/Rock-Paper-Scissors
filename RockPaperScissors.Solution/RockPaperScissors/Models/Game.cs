using System;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1Sign { get; set; }
    public string Player2Sign { get; set; }

    public void AssignSigns(string input1, string input2)
    {
      Player1Sign = input1;
      Player2Sign = input2;
    }
    
  }
}
