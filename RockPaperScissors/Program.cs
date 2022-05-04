using System;
using System.Collections.Generic;
using RockPaperScissors;

public class Program
{
  public static void Main()
  {
    Console.BackgroundColor = ConsoleColor.Black;
    while (true)
    {
      Console.WriteLine("player one choose rock paper or scissors.");
      Console.ForegroundColor = ConsoleColor.Black;
      string playerOne = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.White;
      while (true)
      {
        if ((playerOne != "rock") && (playerOne != "paper") && (playerOne != "scissors"))
        {
          Console.WriteLine("please enter rock paper or scissors.");
          Console.ForegroundColor = ConsoleColor.Black;
          playerOne = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
          break;
        }
      }
      Console.WriteLine("player two choose rock paper or scissors.");
      Console.ForegroundColor = ConsoleColor.Black;
      string playerTwo = Console.ReadLine();
      Console.ForegroundColor = ConsoleColor.White;
      while (true)
      {
        if ((playerTwo != "rock") && (playerTwo != "paper") && (playerTwo != "scissors"))
        {
          Console.WriteLine("please enter rock paper or scissors.");
          Console.ForegroundColor = ConsoleColor.Black;
          playerTwo = Console.ReadLine();
          Console.ForegroundColor = ConsoleColor.White;
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