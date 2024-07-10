using System;
public class Biking : Activity
{
    private double _speed;

    public Biking(string Date, double Time, double Speed, string Type = "Biking") : base(Date, Time, Type)
    {
        _speed = Speed;
    }


    public override double CalculatePace()
    {
        return 60 / _speed;
    }
    public override double CalculateDistance()
    {
        return (_speed / 60) * _time;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

}