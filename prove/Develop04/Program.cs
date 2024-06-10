using System;

class Program
{
    static void Main(string[] args)
    {
        Base b1=new Base();
        string selection;
        do{
            selection=b1.DisplayMenu();
        switch (selection){
            case "1":
                Console.Clear();
                Breathing b2= new Breathing("Welcome to the Breathing activity.\nThis activity will help you relax by walking you through breathing in and out slowly. clear your mind and focus on your breathing.");
                b2.DisplayOpening();
                Console.Clear();
                b2.displayActivity();
                b2.ClosingMessage();
                break;
            case "2":
                Console.Clear();
                Reflection b3= new Reflection("Welcom to the Relection Activity.\nThis activity will help you refelcton times in your life when you have shown strength and resilience this will help you reconize the power you have and how you can use it in other aspects of your life");
                b3.DisplayOpening();
                Console.Clear();
                b3.DisplayActivity();
                b3.ClosingMessage();
                break;
            case "3":
                Console.Clear();
                Listing b4=new Listing("Welcom to the Listing activity.\nThis activity will help you refect on the good things in your life be having you list as many things as you can in a certain area");
                b4.DisplayOpening();
                Console.Clear();
                b4.DisplayActivity();
                b4.ClosingMessage();
                break;
            case "4":
                Console.Clear();
                break;
        }
        } while(selection!="4");
    }
}