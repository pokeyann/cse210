using System;

class Program
{
  static void Main(string[] args)
  {
    List<int> numbers = new List<int>();

    Console.WriteLine("Hello Prep4 World!");

    Console.WriteLine("Enter a list of numbers, type 0 when finished.");

    int userNumber = -1;
    do
    {

      Console.WriteLine("Enter a number: ");

      string userResponse = Console.ReadLine();

      userNumber = int.Parse(userResponse);

    } while (userNumber != 0);

    numbers.Add(userNumber);
    Console.WriteLine("numbers");

  }
}