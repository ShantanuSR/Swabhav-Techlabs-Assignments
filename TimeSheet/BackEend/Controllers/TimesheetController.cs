using Microsoft.AspNetCore.Mvc;
using TimesheetTask.Model;
using TimesheetTask.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TimesheetTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {
        private readonly IDateServices _dateService;
        public TimesheetController(IDateServices dateService)
        {
            _dateService = dateService;
        }

        // GET: api/<TimesheetController>
        [HttpGet]
        public IEnumerable<Date> Get()
        {
            return _dateService.GetDateService();
        }



        // POST api/<TimesheetController>
        [HttpPost]
        public IActionResult Post([FromBody] Date date)
        {
            _dateService.PostDateService(date);
            return Ok(new { message = "Timesheet successfully created" });
        }

        //// PUT api/<TimesheetController>/5
        //[HttpPut("{id}")]
        //public IActionResult Put(int id, [FromBody] Date date)
        //{
        //    if (id != date.DateId)
        //    {
        //        return BadRequest(new { message = "Date ID mismatch" });
        //    }

        //    var updated = _dateService.UpdateDateService(date);
        //    if (updated)
        //    {
        //        return Ok(new { message = "Timesheet successfully updated" });
        //    }
        //    else
        //    {
        //        return NotFound(new { message = "Timesheet not found" });
        //    }
        //}

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = _dateService.DeleteDateService(id);
            if (!result)
            {
                return NotFound(new { message = "Entry not found" });
            }
            return Ok(new { message = "Entry deleted successfully" });
        }

   
    }
}
