using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Real Estate Agent";
        job1._company = "E2&Asociados";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Assistant accountant";
        job2._company = "H&M Financial and Tax";
        job2._startYear = 2020;
        job2._endYear = 2023;
        
        Resume myResume = new Resume();
        myResume._name = "Steven Savarin";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}