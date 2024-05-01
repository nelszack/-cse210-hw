using System;
using System.IO;
// Zack Nelson,5/1/24, journal entery keeping system that stores the date prompt and responce to a file
// I made it so that it can be saved to a .txt ot a .csv file and have it load and display correctly
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
        Write WritePromptzn=new Write();
        do
        {
            string Znchoise=Menu();
            Choisezn=int.Parse(Znchoise);
            if (Choisezn>=6||Choisezn<=0){
                Console.WriteLine("Not a valid option try again");
            }
            switch(Choisezn)
            {
                case 1:
                    Console.WriteLine(WritePromptzn.GetPrompt());
                    string promptResponce=Console.ReadLine();
                    WritePromptzn.GetResponce(promptResponce);
                    WritePromptzn.StoreEntry();
                    break;
                case 2:
                    WritePromptzn.Display();
                    break;
                case 3:
                    Load LoadFilezn=new Load();
                    LoadFilezn.LoadEnteries(WritePromptzn._entries);
                    break;
                case 4:
                    Load SaveEnterieszn= new Load();
                    SaveEnterieszn.SaveEnteries(WritePromptzn._entries);
                    break;
                case 5:
                    Console.Write("Are you sure, any unsaved entries will be lost ");
                    string Responcezn=Console.ReadLine();
                    if (Responcezn.ToLower()=="yes"||Responcezn.ToLower()=="y"){
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