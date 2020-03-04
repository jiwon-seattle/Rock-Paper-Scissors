using System;

namespace RockPaperScissors.Models
{
  public class Player
  {
    public string Name { get; set; }
    public string Sign { get; set; }

    public Player(string name)
    {
      Name = name;
    }
  }
}