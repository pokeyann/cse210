using System;

class Program
{
  static void Main(string[] args)
  {
    /*Console.WriteLine("Hello Prep1 World!");*/

    Console.Write("What is your first name? ");
    String fname = Console.ReadLine();

    Console.Write("What is your last name? ");
    String lname = Console.ReadLine();

    Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
  }
}