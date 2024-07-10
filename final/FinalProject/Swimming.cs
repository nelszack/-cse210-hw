using System;
public class Swimming : Activity
{
    private double _laps;

    public Swimming(string Date, double Time, double Laps, string Type = "Swimming") : base(Date, Time, Type)
    {
        _laps = Laps;
    }

    public override double CalculateDistance()
    {
        return _laps * 50 / 1000 * .62;
    }
    public override double CalculateSpeed()
    {
        return CalculateDistance() / _time * 60;
    }
    public override double CalculatePace()
    {
        return _time / CalculateDistance();
    }
}