using System;

public class Save:Base{

    public Save(){}
    public void SaveGoals(List<Base> goals){
        Console.Write("where do you want to save the goals ");
        string FileName=Console.ReadLine();
        using (System.IO.StreamWriter output=new StreamWriter(FileName))
        {
            output.WriteLine(_score);
            foreach (Base goal in goals)
            {
            string goalType=goal.GetGoalType();
            string goalName=goal.GetName();
            string goalDesctiption=goal.GetDescription();
            int pointValue=goal.GetPoint();
            if(goalType=="CheaklistGoal"){
            int numberTimes=goal.GetNumber();
            int numberTimesCompleated=goal.GetNumberCompleated();
            int bonus=goal.GetBonus();
            output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{bonus},{numberTimesCompleated},{numberTimes}"); 
            } else if (goalType=="SimpleGoal")
            {bool compleated=_compleated;
            output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue},{compleated}");
            }
            else{
                output.WriteLine($"{goalType},{goalName},{goalDesctiption},{pointValue}");
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