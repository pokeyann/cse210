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

/* 
1.	Write
a.	Random generated prompt
b.	User input journal entry, answering prompt
c.	Returns to menu options when hit enter

2.	Display
a.	Display all journal entries
i.	Include date and prompt

3.	Load
a.	Loads saved file
b.	Displays saved file

4.	Save
a.	Save journal entries to file
i.	Add date
ii.	include prompt
iii.	Include journal entry
iv.	Overwrites file each time saved with new journal entries

5.	Quit
a.	Ends program

6.	Create list of prompt questions

7.	Need to randomly generate prompt questions
*/

