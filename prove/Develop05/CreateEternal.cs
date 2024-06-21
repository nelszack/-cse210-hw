using System;

public class CreateEternal:Base{
    private int _timesCompleated;
    public CreateEternal(){

   }
    public CreateEternal(string GoalType, string GoalName, string GoalDesctription, int PointValue,int TimesCompleated ):base(GoalType,GoalName,GoalDesctription,PointValue){
        _timesCompleated=TimesCompleated;
    }

    public override void CreateGoal(){
        _goalType="EternalGoal";
        Console.Write("What is the goal: ");
        _goalName=Console.ReadLine();
        Console.Write("Description of goal: ");
        _goalDesctiption=Console.ReadLine();
        Console.Write("Points when compleated: ");
        _pointValue=int.Parse(Console.ReadLine());
           
    }
    public override int GetNumberCompleated(){return _timesCompleated;}
    public override void SetNumberCompleated(int numb){_timesCompleated+=numb;}
}