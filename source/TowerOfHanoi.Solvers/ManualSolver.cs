﻿using System;
using System.Collections.Generic;
using TowerOfHanoi.Common;

namespace TowerOfHanoi.ManualSolver
{
  public class ManualSolver : ISolveTowers
  {
    public int MillisecondDelayBetweenMoves { get; } = 0;

    public IEnumerable<TowerGameMoveModel> SolveFromStart(IReadonlyTowerGame game)
    {
      var lastError = "";
      while (true)
      {
        var validInput = false;
        var sourcePeg = 0;
        var destPeg = 0;
        try
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(lastError);
          lastError = "";
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Enter the Source Peg Number:");
          sourcePeg = int.Parse(Console.ReadLine() ?? string.Empty);
          Console.WriteLine("Enter the Destination Peg Number:");
          destPeg = int.Parse(Console.ReadLine() ?? string.Empty);
          validInput = true;
        }
        catch (Exception e)
        {
          lastError = e.Message;
        }

        if (!validInput) continue;

        yield return new TowerGameMoveModel
        {
          From = (PegNumber)sourcePeg,
          To = (PegNumber)destPeg,
        };

        if (game.IsGameOver())
        {
          yield break;
        }
      }
    }
  }
}