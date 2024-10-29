public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Progress recorded for '{_shortName}'. You earned {_points} points.");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never fully complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}