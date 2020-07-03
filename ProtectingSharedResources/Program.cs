using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Diagnostics;

namespace ProtectingSharedResources
{
    class Program
    {
        static int total = 0;
        static void Main()
        {

            Stopwatch watch = Stopwatch.StartNew();
            watch.Start();

            Thread t1 = new Thread(Addmillion);
            Thread t2 = new Thread(Addmillion);
            Thread t3 = new Thread(Addmillion);
            t1.Start();
            t2.Start();
            t3.Start();
            //Addmillion();
            //Addmillion();
            //Addmillion();
          
            Console.WriteLine("total =" + total);
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);


        }
        public static void Addmillion()
        {
            for (int i=0; i < 100000; i++)
            {
                //total ++;
                Interlocked.Increment(ref total);
            }
        
        }
    }
}
