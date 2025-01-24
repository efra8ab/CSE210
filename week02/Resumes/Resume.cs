
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Work Experience: \n");
        
        foreach (Job job in _jobs)
        {
            Console.Write("-> ");
            job.Display();
        }
    }
}