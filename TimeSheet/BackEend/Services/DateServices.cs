using TimesheetTask.Model;
using TimesheetTask.Repository;

namespace TimesheetTask.Services
{
    public class DateServices : IDateServices
    {
        private readonly IDateRepo _dateRepository;

        public DateServices(IDateRepo dateRepository)
        {
            _dateRepository = dateRepository;
        }
        public IEnumerable<Date> GetDateService()
        {
            return _dateRepository.Get();
        }

        public void PostDateService(Date date)
        {
            _dateRepository.Post(date);
        }

        public bool DeleteDateService(int id)
        {
            var dateData = _dateRepository.GetById(id);
            if (dateData != null)
            {
                _dateRepository.Delete(dateData);
                return true;
            }
            return false;
        }
    }
}
