using System;

namespace Reminder
{
    public class NotifyData
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public int Interval { get; set; }
        public DateTime DateTime { get; set; }
        public int Repeats { get; set; }

        public NotifyData(int id, string info, int interval, DateTime dateTime, int repeats)
        {
            Id = id;
            Info = info;
            Interval = interval;
            DateTime = dateTime;
            Repeats = repeats;
        }

        
    }
}
