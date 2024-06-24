using System;

class Program
{   
    

    static void Main(string[] args)
    {
          string Choise;
          Base open=new();
        do
        {
           Console.WriteLine($"Score: {open.GetScore()}\n"); 
            Choise= open.Menu("1. Create new goal\n2. List goals\n3. Save goals\n4. Load goals\n5. Record\n6. Remove active goal \n7. Quit\nSelect a choice: ");
            switch (Choise)
            {   case "1":
                    
                    do{
                    Choise=open.Menu("1. Simple Goal\n2. Eternal Goal\n3. Cheaklist Goal\nWhat do you choose: ");
                    switch (Choise){
                         case "1":
                              CreateSimple creates=new();
                              creates.CreateGoal();
                              open.AddActiveList(creates);
                              break;
                         case "2":
                              CreateEternal createe=new();
                              createe.CreateGoal();
                              open.AddActiveList(createe);
                              break;
                         case "3":
                              CreateCheaklist createc=new();
                              createc.CreateGoal();
                              open.AddActiveList(createc);
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
                    save.SaveGoals(open.GetActiveList(),open.GetScore(),open.GetCompleatedList());
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
                    open.RemoveActive();
                    break;
               case "7":
                    Console.WriteLine("quit");
                    break;
               default:
                    Console.WriteLine("not a valid choise");
                    break;
            }
          //   Console.Clear();
        } while (Choise!="7");
    
    }
}