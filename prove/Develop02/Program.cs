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
        string AnswerZn=Console.ReadLine();
        return AnswerZn;
    }
    static void Main(string[] args)
    {   int Choisezn=0;
        Write WritePrompt=new Write();
        do
        {
            string Znchoise=Menu();
            Choisezn=int.Parse(Znchoise);
            if (Choisezn>=6||Choisezn<=0){
                Console.WriteLine("not a valid option try again");
            }
            switch(Choisezn)
            {
                case 1:
                    Console.WriteLine(WritePrompt.GetPrompt());
                    string promptResponce=Console.ReadLine();
                    WritePrompt.GetResponce(promptResponce);
                    WritePrompt.StoreEntry();
                    break;
                case 2:
                    WritePrompt.Display();
                    break;
                case 3:
                    Load LoadFile=new Load();
                    LoadFile.LoadEnteries(WritePrompt._entries);
                    break;
                case 4:
                    Load SaveEnteries= new Load();
                    SaveEnteries.SaveEnteries(WritePrompt._entries);
                    break;
                case 5:
                    Console.Write("are you sure, any unsaved entries will be lost ");
                    string Responce=Console.ReadLine();
                    if (Responce.ToLower()=="yes"||Responce.ToLower()=="y"){
                        Choisezn=5;
                        }
                    else{
                        Choisezn=0;
                        }
                    break;
            } 
        } while (Choisezn!=5);

    }
}