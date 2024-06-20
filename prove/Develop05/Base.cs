using System;


public class Base{

    protected int _score=0; 
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesctiption;
    protected int _pointValue;
    protected int _numberTimes;
    protected int _numberTimesCompleated;
    protected int _bonus;
    protected bool _compleated=false;

    protected List<Base> _goals =new();

    public Base(){
        
    }
    public Base(string GoalType, string GoalName, string GoalDesctription, int PointValue, bool Compleated){
        _goalType=GoalType;
        _goalName=GoalName;
        _goalDesctiption=GoalDesctription;
        _pointValue=PointValue;
        _compleated=Compleated;
    }
    public Base(string GoalType, string GoalName, string GoalDesctription, int PointValue){
        _goalType=GoalType;
        _goalName=GoalName;
        _goalDesctiption=GoalDesctription;
        _pointValue=PointValue;
    }
    public Base(string GoalType, string GoalName, string GoalDesctription, int PointValue,int Bonus,int NumberTimes,int TimesCompleated ){
        _goalType=GoalType;
        _goalName=GoalName;
        _goalDesctiption=GoalDesctription;
        _pointValue=PointValue;
        _numberTimes=NumberTimes;
        _bonus=Bonus;
        _numberTimesCompleated=TimesCompleated;
    }
    public string GetName(){
        return _goalName;
    }
    public string GetDescription(){
        return _goalDesctiption;
    }
    public string GetGoalType(){
        return _goalType;
    }
    public int GetPoint(){
        return _pointValue;
    }
    public int GetNumber(){
        return _numberTimes;
    }
    public int GetNumberCompleated(){
        return _numberTimesCompleated;
    }
    public int GetBonus(){
        return _bonus;
    }
    
    public void AddList(Base some){
        _goals.Add(some);
    }
   
   public List<Base> GetList(){
    return _goals;
   }

    public string Menu(){
    Console.WriteLine($"Score: {_score}\n");    
    Console.Write("1. Create new goal\n2. List goals\n3. Save goals\n4. Load goals\n5. Record\n6. Quit\nSelect a choice: ");
    string Choice=Console.ReadLine();
    return Choice;
    }

     public string CreateMenu()
    {
        Console.Write("1. Simple Goal\n2. Eternal Goal\n3. Cheaklist Goal\nWhat do you choose: ");
        string choise=Console.ReadLine();
        return choise;
    }
    public virtual void CreateGoal(){
        Console.Write("d");
    }
    public void ListGoals(){
        foreach (var item in _goals)
        {
            string goalType=item.GetGoalType();
            string goalName=item.GetName();
            string goalDesctiption=item.GetDescription();
            int pointValue=item.GetPoint();
            if(goalType=="CheaklistGoal"){
            int numberTimes=item.GetNumber();
            int numberTimesCompleated=item.GetNumberCompleated();
            int bonus=item.GetBonus();
            Console.WriteLine($"{goalType}: {goalName} ({goalDesctiption}) {pointValue} --compleated {numberTimesCompleated}/{numberTimes})"); 
            } else{Console.WriteLine($" [ ] {goalType}: {goalName} ({goalDesctiption}) {pointValue}");}
        }

    }
    public void FromLoad(string[] strings){
        _score=int.Parse(strings[0]);
        for (int i=1;i<=strings.Count();i++){
            string[] goal=strings[i].Split(',');
            switch (goal[0])
            {
                case "SimpleGoal":
                    CreateSimple load1=new(goal[0],goal[1],goal[2],int.Parse(goal[3]),bool.Parse(goal[4]));
                    AddList(load1);
                    break;
                case "EternalGoal":
                    CreateEternal load2=new(goal[0],goal[1],goal[2],int.Parse(goal[3]));
                    break;
                case "CheaklistGoal":
                    CreateCheaklist load3= new(goal[0],goal[1],goal[2],int.Parse(goal[3]),int.Parse(goal[4]),int.Parse(goal[5]),int.Parse(goal[6]));
                    break;
                default:
                break;
            }
        }

    }
}