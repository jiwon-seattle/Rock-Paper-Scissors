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

    public string CheckWinner()
    {
      if (Player1Sign == "rock")
      {
        if (Player2Sign =="rock")
        {
          return $"It's a draw!";
        }
        else if (Player2Sign == "scissors")
        {
          return $"Player1 wins";
        }
        else if (Player2Sign == "paper")
        {
          return $"Player2 wins";
        }
        else
        {
          return $"Invalid input. Please try again.";
        }
      }
      else if (Player1Sign == "scissors")
      {
        if (Player2Sign == "scissors")
        {
          return $"It's a draw!";
        }
        else if (Player2Sign == "rock")
        {
          return $"Player2 wins";
        }
        else if (Player2Sign == "paper")
        {
          return $"Player1 wins";
        }
        else
        {
          return $"Invalid input. Please try again.";
        }
      } 
      else if (Player1Sign == "paper")
      {
        if (Player2Sign == "paper")
        {
          return $"It's a draw!";
        }
        else if (Player2Sign == "scissors")
        {
          return $"Player2 wins";
        }
        else if (Player2Sign == "rock")
        {
          return $"Player1 wins";
        }
        else
        {
          return $"Invalid input. Please try again.";
        }
      }
      else
      {
        return $"Invalid input. Please try again.";
      }

    }
    
  }
}
