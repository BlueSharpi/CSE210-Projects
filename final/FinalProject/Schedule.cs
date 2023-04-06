public class Schedule
{
    // Attributes
    private bool[] _week = new bool[7];
    private bool[] _month = new bool[31];
    private DateOnly[] _calendar = new DateOnly[365];

    // Methods
    public void AddDayOfWeek(int dayOfWeek)
    {
        _week[dayOfWeek - 1] = true;
    }
    public void AddDayOfMonth(int dayOfMonth)
    {
        _month[dayOfMonth - 1] = true;
    }
    public void AddCalendarDate(DateOnly date)
    {
        _calendar[date.DayOfYear - 1] = date;
    }
    public string[] GetScheduledDays()
    {   
        return new string[0];
    }
}
