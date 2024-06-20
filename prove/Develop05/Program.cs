using System;

class Program
{   
    

    static void Main(string[] args)
    {
          string Choise;
          Base open=new();
        do
        {
            Choise= open.Menu();
            switch (Choise)
            {   case "1":
                    
                    do{
                    Choise=open.CreateMenu();
                    switch (Choise){
                         case "1":
                              CreateSimple creates=new();
                              creates.CreateGoal();
                              open.AddList(creates);
                              break;
                         case "2":
                              CreateEternal createe=new();
                              createe.CreateGoal();
                              open.AddList(createe);
                              break;
                         case "3":
                              CreateCheaklist createc=new();
                              createc.CreateGoal();
                              open.AddList(createc);
                              break;
                         default:
                              Console.WriteLine("not a valid choice");
                              break;
                    }
                    } while(!new [] {"1","2","3"}.Contains(Choise));
                    
                    break;
               case "2":
                   open.ListGoals();
                    break;
               case "3":
                    Save save=new();
                    save.SaveGoals(open.GetList(),open.GetScore());
                    break;
               case "4":
                    Save load =new();
                    string[] goals=load.Load();
                    open.FromLoad(goals);
                    break;
               case "5":
                    open.Record();
                    break;
               case "6":
                    Console.WriteLine("quit");
                    break;
            }
          //   Console.Clear();
        } while (Choise!="6");

            
        
    }
}