using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDetails
{
    public class Professor
    {
    public int ProfId {  get; set; }

    public string ProfName { get; set; }

    

    public Professor(int profId, string profName)
        {
            ProfId = profId;
            ProfName = profName;
        }

    }
}
