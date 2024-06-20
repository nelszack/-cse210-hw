using System;

public class CreateCheaklist:Base{
   protected int _numberTimes,_numberTimesCompleated, _bonus;
    
   public CreateCheaklist(){

   }
   public CreateCheaklist(string GoalType, string GoalName, string GoalDesctription, int PointValue,int Bonus,int NumberTimes,int TimesCompleated ):base(GoalType,GoalName,GoalDesctription,PointValue){
      _numberTimes=NumberTimes;
      _numberTimesCompleated=TimesCompleated;
      _bonus=Bonus;
   }
   public override void CreateGoal(){
         _goalType="CheaklistGoal";
        Console.Write("What is the goal: ");
        _goalName=Console.ReadLine();
        Console.Write("Description of goal: ");
        _goalDesctiption=Console.ReadLine();
        Console.Write("Points when compleated: ");
        _pointValue=int.Parse(Console.ReadLine());   
         Console.Write("How many times until bonus: ");
        _numberTimes=int.Parse(Console.ReadLine());
        Console.Write("What is the bonus: ");
        _bonus=int.Parse(Console.ReadLine()); 
    }
   public override int GetNumber(){return _numberTimes;}
   public override int GetNumberCompleated(){return _numberTimesCompleated;}
   public override void SetNumberCompleated(int numb){_numberTimesCompleated+=numb;}
   
   public override int GetBonus(){return _bonus;}
}