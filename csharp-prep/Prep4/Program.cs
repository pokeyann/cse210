using System;
using System.Collections.Generic;

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

      {
        numbers.Add(userNumber);
      }

    } while (userNumber != 0);


    int sum = 0;

    foreach (int number in numbers)
    {
      sum += number;
    }

    Console.WriteLine($"The sum is: {sum}");

    int average = (sum) / numbers.Count;
    Console.WriteLine($"The average is: {average}");

    int max = numbers[0];

    foreach (int number in numbers)
    {
      if (number > max)
      {
        max = number;
      }
    }
    Console.WriteLine($"The largest number is: {max}");
  }
}