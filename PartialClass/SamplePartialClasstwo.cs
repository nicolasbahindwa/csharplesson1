using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod()
        {
            Console.WriteLine("partial method invoked");
        }
    }
}
