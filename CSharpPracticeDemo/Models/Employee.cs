using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDemo.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public Employee()
        {
            FirstName = "FirstName";
            LastName = "LastName";
            Email = "Email@domian.com";
        }

        public void PrintFullName ()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public virtual void PrintEmail()
        {
            Console.WriteLine(Email);
        }

    }
}
