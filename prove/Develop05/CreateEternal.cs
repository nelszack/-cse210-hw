using System;

public class CreateEternal:Base{
   
    public CreateEternal(){

   }
    public CreateEternal(string GoalType, string GoalName, string GoalDesctription, int PointValue ):base(GoalType,GoalName,GoalDesctription,PointValue){

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
    
}