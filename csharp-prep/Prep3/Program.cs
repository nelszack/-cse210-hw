using System;

class Program
{
    static void Main(string[] args)
    {   
        string newGame="yes";
        do{
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine($"{magicNumber}");
        int number=-9;
        int count=0;
            do {
            Console.Write("what is your guess? ");
            string guess=Console.ReadLine();
            number=int.Parse(guess);
            if (number>magicNumber){
                Console.WriteLine("Lower");
            }
            else if (number<magicNumber){
                Console.WriteLine("Higher");
            }
            count+=1;
        }while (number!=magicNumber);
        Console.WriteLine($"correct number of trys {count}");
        Console.Write("do you want to play again? ");
        newGame=Console.ReadLine();
        }while(newGame=="yes");

    }
}