using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDemo.Interfaces
{
    public class ExplicitInterface : IA, IB
    {
        public void A()
        {
            Console.WriteLine("IA.A");
        }

        void IB.A()
        {
            Console.WriteLine("IB.A");
        }
        
    }

    public interface IA
    {
        void A();
    }

    public interface IB
    {
        void A();
    }
}
