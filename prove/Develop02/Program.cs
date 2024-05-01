using System;
using System.IO;

class Program
{
    static string Menu(){

        Console.WriteLine("Select one of the options");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What do you chose? ");
        string answerzn=Console.ReadLine();
        return answerzn;
    }
    static void Main(string[] args)
    {   int choisezn=0;
        Write write=new Write();
        do
        {
            string znchoise=Menu();
            choisezn=int.Parse(znchoise);
            if (choisezn>=6||choisezn<=0){
                Console.WriteLine("not a valid option try again");
            }
            switch(choisezn)
            {
                case 1:
                    Console.WriteLine(write.GetPrompt());
                    string promptResponce=Console.ReadLine();
                    write.GetResponce(promptResponce);
                    write.StoreEntry();
                    break;
                case 2:
                    write.Display();
                    break;
                case 3:
                    Console.WriteLine("file loaded");
                    break;
                case 4:
                    Console.WriteLine("file saved");
                    break;
                case 5:
                    Console.Write("are you sure, any unsaved entries will be lost ");
                    string responce=Console.ReadLine();
                    if (responce.ToLower()=="yes"||responce.ToLower()=="y"){
                        choisezn=5;
                        }
                    else{
                        choisezn=0;
                        }
                    break;
            } 
        } while (choisezn!=5);

    }
}