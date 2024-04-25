using System;
// Zack Nelson 4/25/24 ,get user name and desplay in terminal
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