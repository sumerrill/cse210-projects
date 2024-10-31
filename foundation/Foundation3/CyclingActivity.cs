class CyclingActivity : ExerciseActivity
{
    private double _speedMph;

    public CyclingActivity(string date, int durationMinutes, double speedMph) : base(date, durationMinutes)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance()
    {
        return (_speedMph * DurationMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling: Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";
    }
}