using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Learning02 World!");

    Job job1 = new Job();
    job1._jobTitle = "Data Developer";
    job1._company = "Data World";
    job1._startYear = "2006";
    job1._endYear = "2020";
    Console.WriteLine(job1._jobTitle);
  }
}