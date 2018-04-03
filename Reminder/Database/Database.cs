using System.Data.Entity;

namespace Reminder.Database
{
    public class Database : DbContext
    {
        public Database() : base() { }

        public DbSet<Notify> NotifyData { get; set; }
    }
}
