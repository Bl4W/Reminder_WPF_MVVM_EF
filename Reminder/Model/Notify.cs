using System;
using System.ComponentModel.DataAnnotations;

namespace Reminder
{
    public class Notify
    {
        [Key]
        public int ID { get; set; }             //primary key
        [Required]
        public string Info { get; set; }        //require info about notify
        public int Interval { get; set; }       //default 0
        public DateTime DateTime { get; set; }  //default actual time
        public int Repeats { get; set; }        //default 0

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
