using System;

class Program
{   
    static string Menu(){
    Console.Write("1. Create new goal\n2. List goals\n3. Save goals\n4. Load goals\n5. Record\n6. Quit\nSelect a choice: ");
    string Choice=Console.ReadLine();
    return Choice;
    }

    static void Main(string[] args)
    {
        string Choise;
        do
        {
            
            Choise= Menu();

            switch (Choise)
            {   case "1":
                    Console.WriteLine("new goal");
                    break;
               case "2":
                    Console.WriteLine("list goal");
                    break;
               case "3":
                    Console.WriteLine("save goal");
                    break;
               case "4":
                    Console.WriteLine("load goal");
                    break;
               case "5":
                    Console.WriteLine("record ");
                    break;
               case "6":
                    Console.WriteLine("quit");
                    break;
            }
        } while (Choise!="6");

            
        
    }
}