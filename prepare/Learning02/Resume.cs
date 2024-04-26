using System;

public class Resume{
    public string _personNamezn;
    public List<Job> _jobszn= new List<Job>();

    public void Display(){
        Console.WriteLine($"name: {_personNamezn}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobszn)
        {
            job.Display();
        }
    }

}