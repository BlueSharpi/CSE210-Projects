public class Schedule
{
    // Attributes
    private string _scheduleData;
    private DateTime _startDate = DateTime.Now;
    private DateTime _endDate = DateTime.Now.AddYears(1);
    private List<DateOnly> _calendarDays = new List<DateOnly>();

    // Constructor
    public Schedule() { }

    // Methods
    public void AddCalendarDate(DateOnly date)
    {
        _calendarDays.Add(date);
    }
    public void AddDailyOccurence()
    {
        DateTime dateSetter = _startDate;
        while (dateSetter <= _endDate)
        {
            _calendarDays.Add(DateOnly.FromDateTime(dateSetter));
            dateSetter = dateSetter.AddDays(1);
        }
    }
    public void AddWeeklyOccurence(int dayOfWeek)
    {
        DateTime dateSetter = _startDate;
        while (dateSetter.DayOfWeek != (DayOfWeek)dayOfWeek)
        {
            dateSetter = dateSetter.AddDays(1);
        }
        while (dateSetter <= _endDate)
        {
            _calendarDays.Add(DateOnly.FromDateTime(dateSetter));
            dateSetter = dateSetter.AddDays(7);
        }
        FormatScheduleData();
    }
    public void AddMonthlyOccurence(int day)
    {
        DateTime dayOfMonth = new DateTime(_startDate.Year, _startDate.Month, day);
        while (dayOfMonth >= _startDate && dayOfMonth <= _endDate)
        {
            _calendarDays.Add(DateOnly.FromDateTime(dayOfMonth));
            dayOfMonth = dayOfMonth.AddMonths(1);
        }

        FormatScheduleData();
    }
    public string DisplayNextOccurence()
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        DateOnly tomorrow = DateOnly.FromDateTime(DateTime.Now.AddDays(1));
        DateOnly nextOccurence = DateOnly.FromDateTime(DateTime.MaxValue);
        foreach (DateOnly date in _calendarDays) // Find next occurence
        {
            if (date < nextOccurence && date >= today)
            {
                nextOccurence = date;
            }
        }
        if (nextOccurence == today)
        {
            return "Occured Today";
        }
        else if (nextOccurence == tomorrow)
        {
            return "Next Occurence: Tomorrow";
        }
        else return $"Next Occurence: {nextOccurence.ToLongDateString()}";
    }

    // Getters / Schedule Data
    public List<DateOnly> GetCalendarDays()
    {
        return _calendarDays;
    }
    public string GetScheduleData()
    {
        return _scheduleData;
    }
    public void FormatScheduleData()
    {
        string dates = "";
        foreach (DateOnly date in _calendarDays)
        {
            dates += date.ToShortDateString() + ";";
        }
        _scheduleData = string.Format("{0}-{1}-{2}", _startDate.ToShortDateString(), _endDate.ToShortDateString(), dates);
    }
}