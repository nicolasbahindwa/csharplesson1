 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadJoinThreadalive
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("main thread has started");

            Thread T1 = new Thread(Program.thread1);
            T1.Start();

            Thread T2 = new Thread(Program.thread2);
            T2.Start();

            if (T1.Join(1000))
            {
                Console.WriteLine("thread 1 has completed");
            }
            else
            {
                Console.WriteLine("thread one has not yet completed wait 1sec");
            }

            T2.Join();
            Console.WriteLine("thread 2 has completed");
            if (T1.IsAlive)
            {
                Console.WriteLine("thread one still processing...");
            }
            else
            {
                Console.WriteLine("thread one completed");
            }

         
            Console.WriteLine("main thread has completed");
        }

        public static void thread1()
        {
            Console.WriteLine("thread one invoked");
            Thread.Sleep(5000);
            Console.WriteLine("thread one is about to resume");
        }
        public static void thread2()
        {
            Console.WriteLine("thread two invoked");
        }
    }

}
