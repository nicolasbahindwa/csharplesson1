using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributes_lesson20
{
    class Program
    {
     public   static void Main()
        {
          //  Calculator.add(10, 20);
            Calculator.add(new List<int>(){ 10,20,30});
        }
    }

    public class Calculator
    {
        [Obsolete("this method is obsolute",true)]
        public static int add(int x, int y)
        {
           return  x + y;
        }
        public static int add(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
    
    }


}
