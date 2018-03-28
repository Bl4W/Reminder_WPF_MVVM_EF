using System;
using System.Collections.ObjectModel;

namespace Reminder.Database
{
    public class DatabaseLogic
    {
        Database database = new Database();

        public ObservableCollection<Notify> LoadNotify()
        {
            var notify = database.NotifyData;
            ObservableCollection<Notify> toReturn = new ObservableCollection<Notify>(notify);
            return toReturn;
        }

        public void SaveNotify(int id, string info, int interval, DateTime date, int repeats)
        {
            Notify notify = new Notify(id, info, interval, date, repeats);

            database.NotifyData.Add(notify);
            database.SaveChanges();
        }
    }
}
