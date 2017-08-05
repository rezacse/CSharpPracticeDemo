using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDemo.Models
{
    public class FullTimeEmployee :Employee
    {
        public float YearlyRate { get; set; }

        public override void PrintEmail()
        {
            Console.WriteLine(Email + " - FullTime");
        }
    }
}
