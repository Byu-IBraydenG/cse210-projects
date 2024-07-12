public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

        public int Points { get; internal set; }

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailString()
    {
        return $"[{(IsComplete() ? 'X' : "")}] {_shortName}: {_description}";
    }

}