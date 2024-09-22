using TimesheetTask.Model;

namespace TimesheetTask.Services
{
    public interface IDateServices
    {
        IEnumerable<Date> GetDateService();
        void PostDateService(Date date);

        //bool UpdateDateService(Date date);
        bool DeleteDateService(int id);
    }
}
