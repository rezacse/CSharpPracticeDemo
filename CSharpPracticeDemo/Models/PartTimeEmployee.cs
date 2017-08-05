using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDemo.Models
{
    public class PartTimeEmployee:Employee
    {
        public float HourlyRate { get; set; }
        public override void PrintEmail()
        {
            Console.WriteLine(Email + " - PartTime");
        }
    }
}
