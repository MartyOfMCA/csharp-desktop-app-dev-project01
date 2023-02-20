using System;

namespace Project01
{
    internal class Event
    {
        DateTime date;
        string title;

        public Event(DateTime date, string title)
        {
            this.date = date;
            this.title = title;
        }

        public int CalculateDaysLeftToEvent()
        {
            int daysLeftToEvent;

            daysLeftToEvent = date.Subtract(DateTime.Now).Days;

            return daysLeftToEvent;
        }

        public override string ToString()
        {
            return $"{title} is happening on {date.DayOfWeek}, {date.Month} {date.Day} {date.Year}";
        }
    }
}
