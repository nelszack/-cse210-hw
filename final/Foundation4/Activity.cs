using System;

public class Activity
{
    protected string _date;
    protected string _type;
    protected double _time;


    private List<Activity> _activities = new();

    public Activity()
    {

    }
    public Activity(string Date, double Time, string Type)
    {
        _date = Date;
        _time = Time;
        _type = Type;
    }
    public void GetSummary()
    {
        foreach (var item in _activities)
        {
            Console.WriteLine($"{item._date} {item._type} ({item._time} min) -Distance {item.CalculateDistance()} miles Speed {item.CalculateSpeed()} mph Pace {item.CalculatePace()} min per mile");

        }
    }

    public virtual double CalculateDistance()
    {
        return 100 * 50 / 1000 * .62;
    }
    public virtual double CalculateSpeed()
    {
        return 100 / _time * 60;
    }
    public virtual double CalculatePace()
    {
        return _time / 100;
    }

    public void AddList(Activity activity)
    {

        _activities.Add(activity);
    }
}