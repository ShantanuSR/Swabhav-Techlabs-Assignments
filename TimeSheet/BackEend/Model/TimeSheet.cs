using System.ComponentModel.DataAnnotations.Schema;

namespace TimesheetTask.Model
{
    public class TimeSheet
    {
        public int TimeSheetId {  get; set; }
        //public bool OnLeave { get; set; }
        public string Project {  get; set; }
        public string SubProject {  get; set; }
        public string Batch {  get; set; }
        public int Hours {get; set; }
        public string Activity {  get; set; }

        [ForeignKey(nameof(Activity))]
        public int DateId { get; set; }
    }
}
