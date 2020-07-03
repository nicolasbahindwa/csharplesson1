using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_lesson12
{
    class Program
    {
        static void Main()
        {
            HelloFuctionDelegate del = new HelloFuctionDelegate(hello);
            del("hello world");
        }

        public static void hello(string strMessage)
        { 
        
        }
    }

    public delegate void HelloFuctionDelegate(string Message);
}
