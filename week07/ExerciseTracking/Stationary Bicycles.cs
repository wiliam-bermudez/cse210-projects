using System;


class Cycling : Activity
{
    private double _speedKph;
    private string _type;

    public Cycling(DateTime date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
        _type = "Cycling";
    }

    public override double GetDistance()
    {

        return _speedKph * (GetMinutes() / 60.0);
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {

        return 60.0 / _speedKph;
    }
    
     public string GetType()
    {
        return _type;
    }
}