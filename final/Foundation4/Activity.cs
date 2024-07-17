using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date
    {
        get {return _date;}
        set {_date = value;}
    }

    public int Minutes
    {
        get {return _minutes;}
        set {_minutes = value;}
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} Activity ({_minutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}