using System;

class Program
{   
//     Zack Nelson 6/28/24 made it so that there is an option to remove avtive goal from list and made it so that when displayng goals to record/ remove that it dosnt show goals that are compleated 
    static void Main(string[] args)
    {
          string Choice;
          Base open=new();
        do
        {
          Console.WriteLine($"Score: {open.GetScore()}\n"); 
          Choice= open.Menu("1. Create new goal\n2. List goals\n3. Save goals\n4. Load goals\n5. Record\n6. Remove active goal \n7. Quit\nSelect a choice: ");
          System.Diagnostics.Process.Start("powershell.exe","cls");
            switch (Choice)
            {   case "1":
                    
                    do{
                    Choice=open.Menu("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhat do you choose: ");
                    switch (Choice){
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
                              CreateChecklist createc=new();
                              createc.CreateGoal();
                              open.AddActiveList(createc);
                              break;
                         default:
                              Console.WriteLine("not a valid choice");
                              break;
                    }
                    } while(!new [] {"1","2","3"}.Contains(Choice));
                    
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
                    Console.WriteLine("not a valid choice");
                    break;
            }
        } while (Choice!="7");
    
    }
}