class SwimmingActivity : ExerciseActivity
{
    private int _laps;

    public SwimmingActivity(string date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / DurationMinutes) * 60;
    }

    public override double GetPace()
    {
        return DurationMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming: Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";
    }
}