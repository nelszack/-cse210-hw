using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new();
        Running running1 = new(DateTime.Now.ToString("dd MMM yyyy"), 30, 3.0);
        Biking biking1 = new(DateTime.Now.ToString("dd MMM yyyy"), 30, 6.0);
        Swimming swimming1 = new(DateTime.Now.ToString("dd MMM yyyy"), 30, 3000.0 / 31);
        activity.AddList(running1);
        activity.AddList(biking1);
        activity.AddList(swimming1);
        activity.GetSummary();
    }
}