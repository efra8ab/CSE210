using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        Resume myResume = new Resume();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2021;
        job1._startYear = 2000;
        
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2005;
        job2._endYear = 2018;

        myResume.jobList.Add(job1);
        myResume.jobList.Add(job2);  
        myResume._name = "John Smith";      
        
        myResume.Display();

    }
}