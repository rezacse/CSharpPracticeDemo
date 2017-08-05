using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDemo.Models
{
    public class ArgumentPassing
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void Add(ArgumentPassing ap)
        {
            ap.Id = 2;
            ap.Name = "B";
        }
    }
}
