using Microsoft.EntityFrameworkCore;
using TimesheetTask.Data;
using TimesheetTask.Model;

namespace TimesheetTask.Repository
{
    public class DateRepo : IDateRepo
    {
        private readonly TimesheetDBContext _dbContext;

        public DateRepo(TimesheetDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Date> Get()
        {
            return _dbContext.DatesTable.Include(d => d.TimeSheetsList).ToList();
        }

        public void Post(Date date)
        {
            _dbContext.DatesTable.Add(date);
            _dbContext.SaveChanges();
        }

        //public bool Update(Date date)
        //{
        //    var existingDate = _dbContext.DatesTable.Find(date.DateId);
        //    if (existingDate == null) return false;

        //    existingDate.DateInfo = date.DateInfo;
        //    existingDate.OnLeave = date.OnLeave;
        //    existingDate.TimeSheetsList = date.TimeSheetsList; // Handle accordingly if needed

        //    _dbContext.SaveChanges();
        //    return true;
        //}

        //public bool Delete(int id)
        //{
        //    // Find the Date entry to be deleted
        //    var existingDate = _dbContext.DatesTable.Find(id);
        //    if (existingDate == null) return false; // Not found

        //    // Check if there are related TimeSheet entries with the same DateId
        //    var relatedTimeSheets = _dbContext.TimeSheetsTable
        //                                       .Where(ts => ts.DateId == id)
        //                                       .ToList();

        //    if (relatedTimeSheets.Any())
        //    {
        //        // Prevent deletion if related TimeSheets exist
        //        return false; // Indicates that deletion is not allowed due to existing TimeSheets
        //    }

        //    // Proceed with deletion if no related TimeSheet entries exist
        //    _dbContext.DatesTable.Remove(existingDate);
        //    _dbContext.SaveChanges();
        //    return true; // Successfully deleted
        //}

        public Date GetById(int id)
        {
            return _dbContext.DatesTable.Include(x=>x.TimeSheetsList).FirstOrDefault(d => d.DateId == id);
        }

        public bool Delete(Date date)
        {
            _dbContext.DatesTable.Remove(date);
            _dbContext.SaveChanges();
            return true;
        }


    }
}
