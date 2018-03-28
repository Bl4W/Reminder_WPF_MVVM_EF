using System;

namespace Reminder
{
    public class Notify
    {
        public int ID { get; set; }
        public string Info { get; set; }
        public int Interval { get; set; }
        public DateTime DateTime { get; set; }
        public int Repeats { get; set; }

        public Notify(int id, string info, int interval, DateTime dateTime, int repeats)
        {
            ID = id;
            Info = info;
            Interval = interval;
            DateTime = dateTime;
            Repeats = repeats;
        }
    }
}
