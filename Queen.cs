using System;


namespace QueenAttack.Models
{
  public class Queen
  {
    public static bool Attack(int queenX, int queenY, int computerX, int computerY)
    {
      bool horizontal = queenX == computerX;
      bool vertical = queenY == computerY;
      bool diagonal = Math.Abs(queenX - computerX) == Math.Abs(queenY - computerY);
      
      if (horizontal || vertical || diagonal)
      {
          return true;
      }
      else
      {
          return false;
      }
    }
  }
}