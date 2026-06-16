public class Resume
{
    public string _personsName = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_personsName}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();
        }
    }
}