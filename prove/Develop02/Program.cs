using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");
    Console.WriteLine("Welcome to the Journal Program!");

    //static void PromptGenerator()  why won't the code work when put into a method?

    List<string> prompts = new List<string>();

    prompts.Add("Who is your favorite person? (living or dead)");
    prompts.Add("What is your darkest secret?");
    prompts.Add("If you had the power to create anything, what would you create? Why?");
    prompts.Add("What is your happiest memory?");
    prompts.Add("What is something you regret not saying?");

    int randomNumber = 0;

    Random randomGenerator = new Random();
    randomNumber = randomGenerator.Next(0, prompts.Count);

    Console.WriteLine(prompts[randomNumber]);
  }

  static void Journal()
  {
    Entry();
    // Journal Display method iterates through Entry Display objects and call Entry display method
    // Load
    // Save
    // Quit
  }
  static void Entry()
  {
    //PromptGenerator();
    string journalEntry = Console.ReadLine();
    Console.WriteLine("testing", journalEntry);
    // Entry Display method
    // Date
  }
}
