using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Please enter your grade percentage:  ");
    string gradePercent = Console.ReadLine();
    int answer = int.Parse(gradePercent);

    string letter = "";

    if (answer >= 90)
    {
      letter = "A";
    }

    else if (answer >= 80)
    {
      letter = "B";
    }

    else if (answer >= 70)
    {
      letter = "C";
    }

    else if (answer >= 60)
    {
      letter = "D";
    }

    else
    {
      letter = "F";
    }

    Console.WriteLine($"Your letter grade is {letter}");

    if (answer >= 70)
    {
      Console.WriteLine("Congratulations, you passed!");
    }

    else
    {
      Console.WriteLine("You did not pass, better luck next time.");
    }
  }
}

