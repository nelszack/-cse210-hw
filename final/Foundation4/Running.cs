using System;
public class Running:Activity {
    private double _distance;

    public Running(string Date,double Time,double Distance, string Type ="Running"):base(Date,Time,Type) {
        _distance=Distance;
    }

    public override double CalculateSpeed() {
        return _distance/_time *60;
    }
    public override double CalculatePace() {
        return _time/_distance; 
    }
    public override double CalculateDistance() {
        return _distance;
    }
}