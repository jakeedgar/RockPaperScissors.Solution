using System;
using System.Collections.Generic;
using RockPaperScissors;

public class Program
{
  public static void Main()
  {
    while (true)
    {
      Console.WriteLine("player one choose rock paper or scissors.");
      string playerOne = Console.ReadLine();
      while (true)
      {
        if ((playerOne != "rock") && (playerOne != "paper") && (playerOne != "scissors"))
        {
          Console.WriteLine("please enter rock paper or scissors.");
          playerOne = Console.ReadLine();
        }
        else
        {
          break;
        }
      }
      Console.WriteLine("player two choose rock paper or scissors.");
      string playerTwo = Console.ReadLine();
      while (true)
      {
        if ((playerTwo != "rock") && (playerTwo != "paper") && (playerTwo != "scissors"))
        {
          Console.WriteLine("please enter rock paper or scissors.");
          playerTwo = Console.ReadLine();
        }
        else
        {
          break;
        }
      }
      Game newGame = new Game(playerOne, playerTwo);
      newGame.RunGame();
      Console.WriteLine(newGame.result);
      break;
    }
  }
}