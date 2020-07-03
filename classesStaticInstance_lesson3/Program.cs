using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesStaticInstance_lesson3
{
    class Program
    {
        static void Main()
        {
            Circle c1 = new Circle(5);
            float Area = c1.calculateArea();
            Console.WriteLine("area is = {0}", Area);

        }
    }

    public class Circle
    {
       static float _PI;
        int _Raduis;

        static Circle()
        {
            _PI = 3.141F;
        }
        public Circle(int Raduis)
        {
            this._Raduis = Raduis;
        }

        public float calculateArea()
        {
            return Circle._PI * this._Raduis * this._Raduis;
        }
    }
}
