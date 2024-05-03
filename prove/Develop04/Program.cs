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
                Breathing b3=new Breathing();
                b3.DisplayMessage();
                b3.Timer(5);
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