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
                b2.displayOPening();
                b2.displayActivity();
                break;
            case "2":
                Console.Clear();
                Reflection b3= new Reflection("this is something cool");
                b3.displayOPening();
                b3.displayActivity();
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("3");
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("4");
                break;
        }
        } while(selection!="4");
    }
}