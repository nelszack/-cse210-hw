using System;

public class Save{

    public Save(){}
    public void SaveGoals(List<Base> goals,int score,List<Base> cgoals){
        Console.Write("where do you want to save the goals ");
        string FileName=Console.ReadLine();
        using (System.IO.StreamWriter output=new StreamWriter(FileName))
        {
            int i=0;
            foreach (Base goal in goals){
                if (i==0){
                    output.WriteLine(score);
                    i++;
                }
            string goalType=goal.GetGoalType();
            string goalName=goal.GetName();
            string goalDesctiption=goal.GetDescription();
            int pointValue=goal.GetPoint();
            if(goalType=="ChecklistGoal"){
                int numberTimes=goal.GetNumber();
                int numberTimesCompleated=goal.GetNumberCompleated();
                int bonus=goal.GetBonus();
                output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{bonus},{numberTimes},{numberTimesCompleated}"); 
            } else if (goalType=="SimpleGoal"){
            bool compleated=goal.GetCompleated();
            output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{compleated}");
            }
            else{
                int numberTimesCompleated=goal.GetNumberCompleated();
                output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{numberTimesCompleated}");
            }
        }
            foreach (Base goal in cgoals){
                if (i==0){
                    output.WriteLine(score);
                    i++;}
                    string goalType=goal.GetGoalType();
                    string goalName=goal.GetName();
                    string goalDesctiption=goal.GetDescription();
                    int pointValue=goal.GetPoint();
                    if(goalType=="ChecklistGoal"){
                    int numberTimes=goal.GetNumber();
                    int numberTimesCompleated=goal.GetNumberCompleated();
                    int bonus=goal.GetBonus();
                    output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{bonus},{numberTimes},{numberTimesCompleated}"); 
                    } else if (goalType=="SimpleGoal"){
                    bool compleated=goal.GetCompleated();
                    output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{compleated}");
                    }
                    else{
                        int numberTimesCompleated=goal.GetNumberCompleated();
                        output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{numberTimesCompleated}");
                }
        }
    }
    }
    public string[] Load(){
        Console.Write("where do you want to load from ");
        string FileName=Console.ReadLine();
        string[] strings=System.IO.File.ReadAllLines(FileName);
        return strings;

    }

}