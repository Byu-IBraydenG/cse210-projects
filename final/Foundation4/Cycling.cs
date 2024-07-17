public class Cycling : Activity
{
    private double _speed; // kilometers per hour

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Minutes) / 60; // distance in kilometers
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; // pace in min per km
    }
}
