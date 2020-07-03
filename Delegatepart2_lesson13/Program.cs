using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatepart2_lesson13
{

    public delegate void sampleDelegate();
    class Program
    {
        static void Main()
        {
            //sampleDelegate del = new sampleDelegate(sampleMethodOne);
            // del();

            //sampleDelegate dl1, dl2, dl3, dl4;
            //dl1 = new sampleDelegate(sampleMethodOne);
            //dl2 = new sampleDelegate(sampleMethodtwo);
            //dl3 = new sampleDelegate(sampleMethodthree);

            //dl4 = dl1 + dl2 + dl3 - dl1;
            //dl4();

            sampleDelegate del = new sampleDelegate(sampleMethodOne);
            del += sampleMethodtwo;
            del += sampleMethodthree;
            del();

        }

        public static void sampleMethodOne()
        {
            Console.WriteLine("method one");
        
        }
        public static void sampleMethodtwo()
        {
            Console.WriteLine("method two");

        }
        public static void sampleMethodthree()
        {
            Console.WriteLine("method three");

        }
    }
}
