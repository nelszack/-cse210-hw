using System;
class Program
{
    static void Main(string[] args)
    {
        int BreathingCount=0;
        int ReflectionCount=0;
        int ListingCount=0;
        string Selection;
        do{
            Selection=Base.DisplayMenu();
        switch (Selection){
            case "1":
                Console.Clear();
                Breathing B2= new Breathing("Welcome to the Breathing activity.\nThis activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
                B2.DisplayOpening();
                Console.Clear();
                B2.DisplayActivity();
                B2.ClosingMessage();
                BreathingCount+=1;
                Console.WriteLine($"You have compleated this activity {BreathingCount} times");
                B2.StartTimer(8);
                Console.Clear();
                break;
            case "2":
                Console.Clear();
                Reflection B3= new Reflection("Welcome to the Relection Activity.\nThis activity will help you refelcton times in your life when you have shown strength and resilience this will help you reconize the power you have and how you can use it in other aspects of your life");
                B3.DisplayOpening();
                Console.Clear();
                B3.DisplayActivity();
                B3.ClosingMessage();
                ReflectionCount+=1;
                Console.WriteLine($"You have compleated this activity {ReflectionCount} times");
                B3.StartTimer(8);
                Console.Clear();
                break;
            case "3":
                Console.Clear();
                Listing B4=new Listing("Welcome to the Listing activity.\nThis activity will help you refect on the good things in your life be having you list as many things as you can in a certain area");
                B4.DisplayOpening();
                Console.Clear();
                B4.DisplayActivity();
                B4.ClosingMessage();
                ListingCount+=1;
                Console.WriteLine($"You have compleated this activity {ListingCount} times");
                B4.StartTimer(8);
                Console.Clear();
                break;
            case "4":
                Console.WriteLine($"Breathing: {BreathingCount}");
                Console.WriteLine($"Reflection: {ReflectionCount}");
                Console.WriteLine($"Listing: {ListingCount}\n");
                break;
            case "5":
                Console.Clear();
                break;
        }
        } while(Selection!="5");
    }
}

