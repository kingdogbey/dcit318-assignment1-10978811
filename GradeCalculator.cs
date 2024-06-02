// See https://aka.ms/new-console-template for more information
using System;

class GradeCalculator{
  static void Main()
  {
    Console.WriteLine( "Enter a numerical grade between 0 and 100");
    int grade= Convert.ToInt32(Console.ReadLine());

    if (grade >= 90)
    {
        Console.WriteLine("You Scored Grade A");
    }
    else if (grade  >= 80)
    {
        Console.WriteLine("You Scored Grade B");
    }
    else if (grade >= 70)
    {
        Console.WriteLine("You Scored Grade C");
    }
    else if (grade >= 60)
    {
        Console.WriteLine("You Scored Grade D ");
    }
    else 
    {
        Console.WriteLine("You Scored Grade F");
    }
  }
}