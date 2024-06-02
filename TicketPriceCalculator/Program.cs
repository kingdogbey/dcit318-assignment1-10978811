// See https://aka.ms/new-console-template for more information
using System;

class TicketPriceCalculator{
  static void Main()
  {
    Console.WriteLine("Enter your Age");
    int age= Convert.ToInt32(Console.ReadLine());

    if (age >=65)
    {
        Console.WriteLine("The price of your ticket is GHC3");
    }
    else if (age <=12)
    {
        Console.WriteLine("The price of your ticket is GHC3");
    }
    else
    {
        Console.WriteLine("The price of your ticket is GHC10");
    }
  }
}