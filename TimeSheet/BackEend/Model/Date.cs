namespace TimesheetTask.Model
{
    public class Date
    {
        public int DateId { get; set; }
        public DateOnly DateInfo { get; set; }
        public bool OnLeave { get; set; }
        public List<TimeSheet> TimeSheetsList { get; set; }
    }
}
