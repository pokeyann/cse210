using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep3 World!");

    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 100);

    int guess = -1;

    while (guess != magicNumber)
    {
      Console.WriteLine("What is your guess?");
      guess = int.Parse(Console.ReadLine());

      if (magicNumber < guess)
      {
        Console.WriteLine("Lower");
      }

      else if (magicNumber > guess)
      {
        Console.WriteLine("Higher");
      }

      else
      {
        Console.WriteLine("You guessed it!");
      }
    }
  }
}


/*Console.WriteLine("What is the magic number?");
      int magicNumber = int.Parse(Console.ReadLine());*/