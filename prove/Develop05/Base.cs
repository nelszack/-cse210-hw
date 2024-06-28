using System;
using System.Diagnostics;


public class Base{
    private List<Base> _goalsActive =new();
    private List<Base> _goalsCompleated =new();
    private int _score=0; 
    protected string _goalType, _goalName,  _goalDesctiption;
    protected int _pointValue;
    public Base(){
        
    }

    public Base(string GoalType, string GoalName, string GoalDesctription, int PointValue){
        _goalType=GoalType;
        _goalName=GoalName;
        _goalDesctiption=GoalDesctription;
        _pointValue=PointValue;
    }

    public string Menu(string menu){   
        Console.Write(menu);
        string Choice=Console.ReadLine();
        return Choice;
    }
    public void ListGoals(){
        int i=1;
        if( _goalsActive.Count!=0){
            Console.WriteLine("Active Goals:");
            foreach (var item in _goalsActive)
            {
                string done="[ ]";
                string goalType=item._goalType;
                string goalName=item._goalName;
                string goalDesctiption=item._goalDesctiption;
                int pointValue=item._pointValue;
                if(goalType=="ChecklistGoal"){
                int numberTimes=item.GetNumber();
                int numberTimesCompleated=item.GetNumberCompleated();
                int bonus=item.GetBonus();
                if (numberTimes==numberTimesCompleated){done ="[X]";}
                Console.WriteLine($"{i}. {done} {goalType}: {goalName} ({goalDesctiption}) {pointValue} --compleated {numberTimesCompleated}/{numberTimes})"); 
                } else if(goalType=="SimpleGoal"){
                    if(item.GetCompleated()){done="[X]";}
                Console.WriteLine($"{i}. {done} {goalType}: {goalName} ({goalDesctiption}) {pointValue}");}
                else{
                int numberTimesCompleated=item.GetNumberCompleated();
                Console.WriteLine($"{i}.     {goalType}: {goalName} ({goalDesctiption}) {pointValue} --compleated {numberTimesCompleated} times");}
                i++;}
        }else{Console.WriteLine("No active goals\n");}
        if (_goalsCompleated.Count()!=0){
            Console.WriteLine("Compleated Goals:");
            i=1;
            foreach (var item in _goalsCompleated)
            {
                string done="[ ]";
                string goalType=item._goalType;
                string goalName=item._goalName;
                string goalDesctiption=item._goalDesctiption;
                int pointValue=item._pointValue;
                if(goalType=="ChecklistGoal"){
                    int numberTimes=item.GetNumber();
                    int numberTimesCompleated=item.GetNumberCompleated();
                    int bonus=item.GetBonus();
                    if (numberTimes==numberTimesCompleated){done ="[X]";}
                        Console.WriteLine($"{i}. {done} {goalType}: {goalName} ({goalDesctiption}) {pointValue} --compleated {numberTimesCompleated}/{numberTimes})"); 
                    } else if(goalType=="SimpleGoal"){
                        if(item.GetCompleated()){done="[X]";}
                        Console.WriteLine($"{i}. {done} {goalType}: {goalName} ({goalDesctiption}) {pointValue}");}
                else{
                    int numberTimesCompleated=item.GetNumberCompleated();
                    Console.WriteLine($"{i}.    {goalType}: {goalName} ({goalDesctiption}) {pointValue} --compleated {numberTimesCompleated} times");}
                i++;
            }
        }else{Console.WriteLine("No compleated goals\n");}

    }
    public void Record(){
        if (_goalsActive.Count()!=0){
            int i =1;
            int index3=0;
            List<int> index2=new();
            foreach (var item in _goalsActive)
            {
                if ((item.GetCompleated()!=true&&item._goalType=="SimpleGoal")||(item.GetNumber()!=item.GetNumberCompleated()&&item._goalType=="ChecklistGoal")||item._goalType=="EternalGoal"){
                Console.WriteLine($"{i}. {item._goalName}");
                index2.Add(index3);
                i++; 
                }
                index3++;
                
            }
            Console.Write("Which one do you want to record ");
            string choise=Console.ReadLine();
            int index=index2[int.Parse(choise)-1];
            switch (_goalsActive[index])
            {
                case CreateSimple:
                    _goalsActive[index].SetCompleated(true);
                    _score+=_goalsActive[index]._pointValue;
                    AddCompleatedList(_goalsActive[index]);
                    Console.WriteLine($"addded {_goalsActive[index]._pointValue} to the score");
                    _goalsActive.RemoveAt(index);
                    break;
                case CreateEternal:
                    _score+=_goalsActive[index]._pointValue;
                    _goalsActive[index].SetNumberCompleated(1);
                    Console.WriteLine($"addded {_goalsActive[index]._pointValue} to the score");
                    break;
                case CreateChecklist:
                    _goalsActive[index].SetNumberCompleated(1);
                    if(_goalsActive[index].GetNumber()==_goalsActive[index].GetNumberCompleated())
                    {
                    _score+= _goalsActive[index]._pointValue+_goalsActive[index].GetBonus();
                    Console.WriteLine($"addded {_goalsActive[index]._pointValue+_goalsActive[index].GetBonus()} to the score");  
                    AddCompleatedList(_goalsActive[index]);
                    _goalsActive.RemoveAt(index);
                    }else{
                        _score+=_goalsActive[index]._pointValue;
                        Console.WriteLine($"addded {_goalsActive[index]._pointValue} to the score");
                    }
                    break;
            }
                
        } else{Console.WriteLine("No goals to record");}
    }
        public void FromLoad(string[] strings){
        if(strings.Count()>0){    
            _score+=int.Parse(strings[0]);
            for (int i=1;i<strings.Count();i++){
                string[] goal=strings[i].Split(',');
                switch (goal[0])
                {
                    case "SimpleGoal":
                        CreateSimple load1=new(goal[0],goal[1],goal[2],int.Parse(goal[3]),bool.Parse(goal[4]));
                        if (bool.Parse(goal[4])){
                            AddCompleatedList(load1);
                        }
                        else{
                        AddActiveList(load1);
                        }
                        break;
                    case "EternalGoal":
                        CreateEternal load2=new(goal[0],goal[1],goal[2],int.Parse(goal[3]),int.Parse(goal[4]));
                        AddActiveList(load2);
                        break;
                    case "ChecklistGoal":
                        CreateChecklist load3= new(goal[0],goal[1],goal[2],int.Parse(goal[3]),int.Parse(goal[4]),int.Parse(goal[5]),int.Parse(goal[6]));
                        if (int.Parse(goal[5])==int.Parse(goal[6])){
                            AddCompleatedList(load3);
                        }
                        else{AddActiveList(load3);}
                        break;
                }
            }
        } else
        {
            Console.WriteLine("file empty");
        }
        }

    public void RemoveActive(){
        if (_goalsActive.Count()!=0){
            int i =1;
            int index3=0;
            List<int> index2=new();
            foreach (var item in _goalsActive)
            {
                if ((item.GetCompleated()!=true&&item._goalType=="SimpleGoal")||(item.GetNumber()!=item.GetNumberCompleated()&&item._goalType=="ChecklistGoal")||item._goalType=="EternalGoal"){
                Console.WriteLine($"{i}. {item._goalName}");
                index2.Add(index3);
                i++; 
                }
                index3++;

            }
            Console.Write("Which one do you want to remove ");
            string choise=Console.ReadLine();
            int index=index2[int.Parse(choise)-1];
            Console.WriteLine("Are you sure this cant be undone and any awarded points will be removed (yes/no)");
            string answer= Console.ReadLine();
            if (answer.ToLower()=="yes"||answer.ToLower()=="y"){    
                if( _goalsActive[index]._goalType=="EternalGoal"||_goalsActive[index]._goalType=="ChecklistGoal"){
                _score-=_goalsActive[index]._pointValue*_goalsActive[index].GetNumberCompleated();
                Console.WriteLine($"{_goalsActive[index]._pointValue*_goalsActive[index].GetNumberCompleated()} points removed from the goal");
                }
                _goalsActive.RemoveAt(index);
                Console.WriteLine("goal removed");
            }

        }
        else{Console.WriteLine("No goal to remove");}
    }
    public string GetName(){return _goalName;}
    public string GetDescription(){return _goalDesctiption;}
    public string GetGoalType(){return _goalType;}
    public int GetPoint(){return _pointValue;}
    public void AddActiveList(Base some){_goalsActive.Add(some);}
   
    public List<Base> GetActiveList(){return _goalsActive;}
    public void AddCompleatedList(Base some){_goalsCompleated.Add(some);}
   
    public List<Base> GetCompleatedList(){return _goalsCompleated;}
    public int GetScore(){return _score;} 

    public virtual void CreateGoal(){}
    public virtual bool GetCompleated(){return true;}
    public virtual int GetNumber(){return 1;}
    public virtual int GetNumberCompleated(){return 1;}
    public virtual void SetNumberCompleated(int numb){}
    public virtual void SetCompleated(bool value){}
    public virtual int GetBonus(){return 1;}
    
}