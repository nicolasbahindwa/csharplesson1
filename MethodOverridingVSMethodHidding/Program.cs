using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingVSMethodHidding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("i'm a base class method");
        }
    }
    public class DerrivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("i'm a derrived class method");
        }
    }
    public class Program
    {
       public static void Main()
        {
            BaseClass A = new DerrivedClass();
            A.Print();

        }
    }
}
