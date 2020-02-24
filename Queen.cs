using System;

class Program
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