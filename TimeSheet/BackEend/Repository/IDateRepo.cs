using TimesheetTask.Model;

namespace TimesheetTask.Repository
{
    public interface IDateRepo
    {
        IEnumerable<Date> Get();
        void Post(Date date);
        //bool Update(Date date);
        Date GetById(int id);
        bool Delete(Date id);
    }
}
