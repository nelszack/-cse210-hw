using System;
// Zack Nelson , 4/26/24
class Program
{
    static void Main(string[] args)
    {
        Job job1zn=new Job();
        job1zn._jobTitlezn="Software Engineer";
        job1zn._companyzn="Microsoft";
        job1zn._startYearzn=2019;
        job1zn._endYearzn=2022;
        job1zn.Display();
        
        Job job2zn=new Job();
        job2zn._jobTitlezn="Manager";
        job2zn._companyzn="Apple";
        job2zn._startYearzn=2022;
        job2zn._endYearzn=2023;
        job2zn.Display();
        
        Job job3zn=new Job("BYUI","Assistant Manager",2023,2025);
        job3zn.Display();

        Resume myResumezn=new Resume();
        myResumezn._personNamezn="John Smith";
        myResumezn._jobszn.Add(job1zn);
        myResumezn._jobszn.Add(job2zn);
        myResumezn._jobszn.Add(job3zn);
        myResumezn.Display();
        
        
    }
}