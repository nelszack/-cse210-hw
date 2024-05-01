using System;

class Program
{
    static void Main(string[] args)
    {
        Random random= new Random();
        int number=random.Next(0,5);
        Console.WriteLine(number);
    }
}