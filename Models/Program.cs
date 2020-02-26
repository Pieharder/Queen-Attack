using System;
using QueenAttack.Models;

namespace QueenAttack
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a Queen x coordinate 1-7");
      string queenXLocation = Console.ReadLine();
      int queenX = int.Parse(queenXLocation);
      Console.WriteLine("Please enter a Queen y coordinate 1-7");
      string queenYLocation = Console.ReadLine();
      int queenY = int.Parse(queenYLocation);
      Console.WriteLine("Please enter an opponent x coordinate 1-7");
      string computerXLocation = Console.ReadLine();
      int computerX = int.Parse(computerXLocation);
      Console.WriteLine("Please enter an opponent y coordinate 1-7");
      string computerYLocation = Console.ReadLine();
      int computerY = int.Parse(computerYLocation);

      
      bool result = Queen.Attack(queenX, queenY, computerX, computerY);
      if(result)
      {
          Console.WriteLine("can attack");
      }
      else
      {
          Console.WriteLine("cannot attack");
      }
    }
    }
  }
