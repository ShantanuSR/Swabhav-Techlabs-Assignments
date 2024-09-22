using Microsoft.EntityFrameworkCore;
using TimesheetTask.Model;

namespace TimesheetTask.Data
{
    public class TimesheetDBContext : DbContext
    {
        public DbSet<Date> DatesTable {  get; set; }  
        public DbSet<TimeSheet> TimeSheetsTable { get; set; }
        public TimesheetDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

    }
}
