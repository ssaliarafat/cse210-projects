public class Resume
{
    public string _name = "";
//My job list with the List<> data type, new List<> means i have initialized this to a new list
    public List<Job> _jobList = new List<Job>(); 

     // A single method that shows both name and job details from the job class
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobList) //To iterate through the list which stores the 2 jobs and calling another function for job details
        {
            job.DisplayJobDetails();
        }
    }
}