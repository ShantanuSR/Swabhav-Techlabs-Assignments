using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENumDemo.cs
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,Tuesday, Wednesday, Thursday, Friday,Saturday,Sunday
        }
        static void Main(string[] args)
        {
            WeekDays weekdays = new WeekDays();
            Console.WriteLine((int)WeekDays.Sunday);
        }
    }
}
