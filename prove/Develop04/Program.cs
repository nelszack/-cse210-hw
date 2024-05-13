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
                Breathing b2= new Breathing();
                int time=b2.displayOPening();
                b2.displayActivity(5);
                // string[] List=b2.GetTimerList();
                // b2.StartTimer(time,List);
                Console.WriteLine("1");
                break;
            case "2":
                Console.WriteLine("2");
                break;
            case "3":
                Console.WriteLine("3");
                break;
            case "4":
                Console.WriteLine("4");
                break;
        }
        Console.Clear();
        } while(selection!="4");
    }
}