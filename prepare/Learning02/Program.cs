using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Engineer";
        job1._company = "NASA";
        job1._startYear = 2011;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "IC Designer";
        job2._company = "Intel";
        job2._startYear = 2024;
        job2._endYear = 2050;

        Resume myResume = new Resume();
        myResume._name = "Diego Deotti";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}