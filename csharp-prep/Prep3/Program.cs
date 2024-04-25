using System;
// Zack Nelson 4/25/24 ,generate random number then have the user guess until corect
class Program
{
    static void Main(string[] args)
    {   
        string newGamezn="yes";
        do{
        Random randomGeneratorzn = new Random();
        int magicNumberzn = randomGeneratorzn.Next(1, 100);
        int numberzn=-9;
        int countzn=0;
            do {
            Console.Write("what is your guess? ");
            string guesszn=Console.ReadLine();
            numberzn=int.Parse(guesszn);
            if (numberzn>magicNumberzn){
                Console.WriteLine("Lower");
            }
            else if (numberzn<magicNumberzn){
                Console.WriteLine("Higher");
            }
            countzn+=1;
        }while (numberzn!=magicNumberzn);
        Console.WriteLine($"correct number of trys {countzn}");
        Console.Write("do you want to play again? ");
        newGamezn=Console.ReadLine();
        }while(newGamezn=="yes");

    }
}