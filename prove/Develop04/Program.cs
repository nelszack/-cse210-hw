using System;
// Zack Nelson 6/14/20024 exceeded requirements by having the program keep track of how many times an activity is done and made it so that on the reflection activity the questions don't repeat untill all of them have been asked
class Program
{
    static void Main(string[] args)
    {
        
        string Selection;
        Base B1=new Base();
        do{ 
            Selection=B1.DisplayMenu();
        switch (Selection){
            case "1":
                Console.Clear();
                Breathing B2= new Breathing("Welcome to the Breathing activity.\nThis activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
                B2.DisplayOpening();
                Console.Clear();
                B2.DisplayActivity();
                B1.SetCount("breathing");
                B2.SetCount("breathing",B1.GetCount("breathing"));
                B2.ClosingMessage();
                Console.Clear();
                break;
            case "2":
                Console.Clear();
                Reflection B3= new Reflection("Welcome to the Relection Activity.\nThis activity will help you refelcton times in your life when you have shown strength and resilience this will help you reconize the power you have and how you can use it in other aspects of your life");
                B3.DisplayOpening();
                Console.Clear();
                B3.DisplayActivity();
                B1.SetCount("reflection");
                B3.SetCount("reflection",B1.GetCount("reflection"));
                B3.ClosingMessage();
                Console.Clear();
                break;
            case "3":
                Console.Clear();
                Listing B4=new Listing("Welcome to the Listing activity.\nThis activity will help you refect on the good things in your life be having you list as many things as you can in a certain area");
                B4.DisplayOpening();
                Console.Clear();
                B4.DisplayActivity();
                B1.SetCount("listing");
                B4.SetCount("listing",B1.GetCount("listing"));
                B4.ClosingMessage();
                Console.Clear();
                break;
            case "4":
                Console.WriteLine($"Breathing: {B1.GetCount("breathing")}");
                Console.WriteLine($"Reflection: {B1.GetCount("reflection")}");
                Console.WriteLine($"Listing: {B1.GetCount("listing")}\n");
                break;
            case "5":
                Console.Clear();
                break;
        }
        } while(Selection!="5");
    }
}

