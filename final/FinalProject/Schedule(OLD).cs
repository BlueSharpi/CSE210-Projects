/*public class Schedule
{
    // Attributes
    private string _scheduleData;
    private bool[] _week = new bool[7];
    private bool[] _month = new bool[31];
    private List<DateOnly> _calendar = new List<DateOnly>();

    // Constructors
    public Schedule() { }
    public Schedule(string scheduleData)
    {
        _scheduleData = scheduleData;
        string[] data = _scheduleData.Split("-");
        string weekData = data[0];
        string monthData = data[1];
        string calendarData = data[2];
        string[] dates = calendarData.Split(";");
        for (int i = 0; i < weekData.Length; i++)
        {
            if (weekData[i] == 't')
            {
                _week[i] = true;
            }
            else _week[i] = false;
        }
        for (int i = 0; i < monthData.Length; i++)
        {
            if (monthData[i] == 't')
            {
                _month[i] = true;
            }
            else _month[i] = false;
        }
        foreach (string s in dates)
        {
            if (DateOnly.TryParseExact(s, "MM/dd/yyyy", out DateOnly date))
            {
                _calendar.Add(date);
            };
        }
    }

    // Methods
    public void AddDayOfWeek(params int[] dayOfWeek)
    {
        foreach (int i in dayOfWeek)
        {
            _week[i - 1] = true;
        }
        FormatScheduleData();
    }
    public void AddDayOfMonth(params int[] dayOfMonth)
    {
        foreach (int i in dayOfMonth)
        {
            _month[i - 1] = true;
        }
        FormatScheduleData();
    }
    public void AddCalendarDate(DateOnly date)
    {
        _calendar.Add(date);
        FormatScheduleData();
    }
    public bool CheckDay(DateOnly date)
    {
        int dayOfWeek = (int)date.DayOfWeek;
        int dayOfMonth = (int)date.Day;
        Console.WriteLine("dayOfMonth: " + dayOfMonth);
        if (_week[dayOfWeek] || _month[dayOfMonth - 1] || _calendar.Contains(date))
        {
            return true;
        }
        else return false;

    }
    public void FormatScheduleData()
    {
        string weekData = "";
        string monthData = "";
        string calendarData = "";
        foreach (bool value in _week)
        {
            if (value == true)
            {
                weekData += "t";
            }
            else weekData += "f";
        }
        foreach (bool value in _month)
        {
            if (value == true)
            {
                monthData += "t";
            }
            else monthData += "f";
        }
        foreach (DateOnly date in _calendar)
        {
            calendarData += date + ";";
        }
        _scheduleData = string.Format("{0}-{1}-{2}", weekData, monthData, calendarData);
    }
    public string NextOccurence()
    {
        DateOnly next = DateOnly.MaxValue;
        if (_calendar.Count > 0)
        {
            foreach (DateOnly date in _calendar ) // Check Calendar List
                {
                    if (date < next)
                    {
                        next = date;
                    }
                }
        }
        for (int i = 0; i < _week.Length; i++) // Check Week List
            {
                if (_week[i] == true && WeekDayDate(i) < next)
                {
                    next = WeekDayDate(i);
                }
            }
        for (int i = 0; i < _month.Length; i++) // Check Month List
            {
                if (_month[i] == true && MonthDayDate(i) < next)
                {
                    next = MonthDayDate(i);
                }
            }
        if (next == DateOnly.FromDateTime(DateTime.Now)) // Today
        {
            return "Next Occurence: Today";
        } 
        else if (next == DateOnly.FromDateTime(DateTime.MaxValue)) // No Occurance
        {
            return "No Occurence Found";
        }
        else return "Next Occurance: " + next.ToLongDateString(); // Next Occurance
    }
    public static DateOnly MonthDayDate(int monthDay)
    {
        DateTime today = DateTime.Now;
        DateTime date = new DateTime(today.Year, today.Month, monthDay);
        if (date <= today)
        {
            date = date.AddMonths(1);
        }
        return DateOnly.FromDateTime(date);
    }
    public static DateOnly WeekDayDate(int weekDay)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        while ((int)today.DayOfWeek != weekDay)
        {
            today = today.AddDays(1);
        }
        return today;
    }

    // Getter
    public string GetScheduleData()
    {
        return _scheduleData;
    }
}*/
