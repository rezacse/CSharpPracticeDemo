using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpPracticeDemo.Models;

namespace CSharpPracticeDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            #region updateArgument

            //var apObj = new ArgumentPassing
            //{
            //    Id = 1,
            //    Name = "A"
            //};
            //Console.WriteLine($"Value after initialization:\nId = {apObj.Id}, Name = {apObj.Name}");

            //p.UpdateParamValue(apObj);
            //Console.WriteLine($"\nValue after argument update:\nId = {apObj.Id}, Name = {apObj.Name}");

            //p.UpdateReference(apObj);
            //Console.WriteLine($"\nValue after reference update from other function:\nId = {apObj.Id}, Name = {apObj.Name}");

            #endregion


            #region paramsForArray

            //p.PassParams(0);
            //p.PassParams(0, 1, 2, 3, 4);
            //p.PassParams(0, 1, 2); 

            #endregion


            #region polymorphism

            var employees = new Employee[3];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();

            foreach (var employee in employees)
            {
                employee.PrintEmail();
            }
                               
            #endregion


            Console.ReadLine();
        }

        #region params

        private void PassParams(int a, params int[] numbers)
        {
            Console.WriteLine("Length of array: " + numbers.Length);
        } 

        #endregion

        #region updateArgument

        public void UpdateParamValue(ArgumentPassing ap)
        {
            ap.Id = 2;
            ap.Name = "B";
        }
        public void UpdateReference(ArgumentPassing ap)
        {
            ap = new ArgumentPassing
            {
                Id = 3,
                Name = "C"
            };
        } 

        #endregion

    }
}
