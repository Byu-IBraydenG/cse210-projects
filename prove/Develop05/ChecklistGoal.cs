public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            // Award bonus points logic
            _points += _bonus;
        }
        else
        {
            // Award regular points for each completion
            _points += base._points;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailString()
    {
        return base.GetDetailString() + $"Comepleted {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}