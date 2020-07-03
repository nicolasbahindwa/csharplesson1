using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_lesson25
{
    class Program
    {
        static void Main()
        {

          //  bool equal = Calculator.AreaEqual<int>(1, 2);

            bool equal = Calculator<int>.AreaEqual(1, 2);


            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }

    //public class Calculator
    //{
        

    //    public static bool AreaEqual<T>(T val1, T val2)
    //    {

    //        return val1.Equals(val2);
    //    }
    //}

    public class Calculator<T>
    {
        //public static bool AreaEqual(int val1, int val2)
        //{
        //    return val1 == val2;

        //}

        public static bool AreaEqual(T val1, T val2)
        {

            return val1.Equals(val2);
        }
    }
}
