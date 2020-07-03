using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace partialClass_l3esson30
{
    public partial class partialCustomer
    {
        public string GetFullName()
        {
            return Fname + " " + lname;
        }
    }
}
