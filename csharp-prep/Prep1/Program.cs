using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string FirstNamezn=Console.ReadLine();
        Console.Write("What is your last name? ");
        string LastNamezn=Console.ReadLine();
        Console.Write($"Your name is {LastNamezn}, {LastNamezn} {FirstNamezn}");
    }
}