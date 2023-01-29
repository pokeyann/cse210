using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Learning02 World!");

    Job job1 = new Job();
    job1._jobTitle = "Data Developer";
    job1._company = "Data World";
    job1._startYear = 2006;
    job1._endYear = 2020;
    job1.JobInformation();
    Console.WriteLine(job1);

    Job job2 = new Job();
    job2._jobTitle = "Database Administrator";
    job2._company = "King of the MySql Castle";
    job2._startYear = 1994;
    job2._endYear = 1997;
    job2.JobInformation();
    Console.WriteLine(job2);

  }
}