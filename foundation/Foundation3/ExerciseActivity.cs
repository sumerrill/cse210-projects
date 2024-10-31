abstract class ExerciseActivity
{
    private string _date;
    private int _durationMinutes;

    public ExerciseActivity(string date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public string Date => _date;
    public int DurationMinutes => _durationMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date}: Duration {_durationMinutes} min";
    }
}