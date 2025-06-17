using System;

public class Running : Activity
{
    private string _type;


    private double _distanceKm; // stored distance in km

    public Running(DateTime date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
        _type = "Running";
    }


    public string GetType()
    {
        return _type;
    }
    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        int _minutes = GetMinutes();
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

}