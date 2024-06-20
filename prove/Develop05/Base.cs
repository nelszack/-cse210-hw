using System;
using System.Diagnostics;


public class Base{

    protected int _score=0; 
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesctiption;
    protected int _pointValue;
    protected int _numberTimes;
    protected int _numberTimesCompleated;
    protected int _bonus;
    protected bool _compleated;

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
    public bool GetCompleated(){
        return _compleated;
    }
    
    public void AddList(Base some){
        _goals.Add(some);
    }
   
   public List<Base> GetList(){
    return _goals;
   }
   public int GetScore(){
    return _score;
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
        int i=1;
        foreach (var item in _goals)
        {
            string done="[ ]";
            string goalType=item._goalType;
            string goalName=item._goalName;
            string goalDesctiption=item._goalDesctiption;
            int pointValue=item._pointValue;
            if(goalType=="CheaklistGoal"){
            int numberTimes=item._numberTimes;
            int numberTimesCompleated=item._numberTimesCompleated;
            int bonus=item._bonus;
            if (numberTimes==numberTimesCompleated){done ="[X]";}
            Console.WriteLine($"{i}. {done} {goalType}: {goalName} ({goalDesctiption}) {pointValue} --compleated {numberTimesCompleated}/{numberTimes})"); 
            } else if(goalType=="SimpleGoal"){
                if(item._compleated){done="[X]";}
                Console.WriteLine($"{i}. {done} {goalType}: {goalName} ({goalDesctiption}) {pointValue}");}
            else{Console.WriteLine($"{i}.    {goalType}: {goalName} ({goalDesctiption}) {pointValue}");}
            i++;
        }

    }
    public void FromLoad(string[] strings){
        _score=int.Parse(strings[0]);
        Console.WriteLine(strings.Count());
        for (int i=1;i<strings.Count();i++){
            string[] goal=strings[i].Split(',');
            switch (goal[0])
            {
                case "SimpleGoal":
                    CreateSimple load1=new(goal[0],goal[1],goal[2],int.Parse(goal[3]),bool.Parse(goal[4]));
                    AddList(load1);
                    break;
                case "EternalGoal":
                    CreateEternal load2=new(goal[0],goal[1],goal[2],int.Parse(goal[3]));
                    AddList(load2);
                    break;
                case "CheaklistGoal":
                    CreateCheaklist load3= new(goal[0],goal[1],goal[2],int.Parse(goal[3]),int.Parse(goal[4]),int.Parse(goal[5]),int.Parse(goal[6]));
                    AddList(load3);
                    break;
            }
        }

    }
    public void Record(){
        int i =1;
        int index3=0;
        List<int> index2=new();
        foreach (var item in _goals)
        {
            if ((item._compleated!=true&&item._goalType=="SimpleGoal")||(item._numberTimes!=item._numberTimesCompleated&&item._goalType=="CheaklistGoal")||item._goalType=="EternalGoal"){
            Console.WriteLine($"{i}. {item._goalName}");
            index2.Add(index3);
            i++; 
            }
            index3++;
               
        }
        Console.Write("Which one do you want to record ");
        string choise=Console.ReadLine();
        int index=index2[int.Parse(choise)-1];
        switch (_goals[index])
        {
            case CreateSimple:
            _goals[index]._compleated=true;
            _score+=_goals[index]._pointValue;
            Console.WriteLine($"addded {_goals[index]._pointValue} to the score");
            break;
            case CreateEternal:
            _score+=_goals[index]._pointValue;
            break;
            case CreateCheaklist:
            _goals[index]._numberTimesCompleated+=1;
            if(_goals[index]._numberTimes==_goals[index]._numberTimesCompleated)
            {
             _score+= _goals[index]._pointValue+_goals[index]._bonus;
             Console.WriteLine($"addded {_goals[index]._pointValue+_goals[index]._bonus} to the score");  
            }else{
                _score+=_goals[index]._pointValue;
                Console.WriteLine($"addded {_goals[index]._pointValue} to the score");
            }
            break;
            
            default:
            break;
        } 
        
    }
}