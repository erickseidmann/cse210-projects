using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._Company = "ESS";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2023;

        job1.showJob();
    }
    
}