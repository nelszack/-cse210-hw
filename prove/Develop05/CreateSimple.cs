using System;

public class CreateSimple:Base{
    private bool _compleated;
    public CreateSimple(){

    }
   
    public CreateSimple(string GoalType, string GoalName, string GoalDesctription, int PointValue,bool Compleated ):base(GoalType,GoalName,GoalDesctription,PointValue){
        _compleated=Compleated;
    }

   
    public override void CreateGoal(){
        _goalType="SimpleGoal";
        Console.Write("What is the goal: ");
        _goalName=Console.ReadLine();
        Console.Write("Description of goal: ");
        _goalDesctiption=Console.ReadLine();
        Console.Write("Points when compleated: ");
        _pointValue=int.Parse(Console.ReadLine()); 
        _compleated=false;   
    }
    
    public override bool GetCompleated(){return _compleated;}
    public override void SetCompleated(bool value){_compleated=value;}
}