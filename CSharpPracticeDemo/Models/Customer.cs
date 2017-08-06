using System;            
using CSharpPracticeDemo.Interfaces;

namespace CSharpPracticeDemo.Models
{
    public class Customer: ICustomer2
    {
        public int Id { get; set; }
        public void PrintEmployee1()
        {
            Console.WriteLine("PrintEmployee1");
        }

        public void PrintCustomer2()
        {
            Console.WriteLine("PrintEmployee2");
        }
    }
}
