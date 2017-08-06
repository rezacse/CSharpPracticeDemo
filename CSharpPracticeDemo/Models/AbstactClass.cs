

using System;

namespace CSharpPracticeDemo.Models
{
    public abstract class AbstactBaseClass
    {
        public abstract void PrintBaseAbstact();
    }

    public class DrivedClassFromAbstract : AbstactBaseClass
    {
        public void PrintDrivedAbstactClass()
        {
            
        }

        public override void PrintBaseAbstact()
        {
            Console.WriteLine("PrintBaseAbstact in DrivedClassFromAbstract");
        }
    }

    public abstract class AbstactDrivedClass : AbstactBaseClass
    {
        public abstract void PrintDrivedAbstact();
    }   

}
