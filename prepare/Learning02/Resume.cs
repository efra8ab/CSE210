using System;

public class Resume
    {
        public string _name;
        public List<Job> jobList = new List<Job>();

        public Resume()
        {
        }

        public void Display()
        {
        Console.WriteLine($"\nName: {_name}");
            Console.WriteLine("Jobs: ");
            foreach (Job job in jobList)
            {
                job.Display();
            }

        }
    }