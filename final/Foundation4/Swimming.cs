public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int mintues, int laps)
        : base (date, mintues)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return Minutes / distance;
    }
}