using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace partialClass_l3esson30
{
    public partial class partialCustomer
    {
        private string Fname;
        private string lname;

        public string firstname { get { return Fname; } set { Fname = value; } }
        public string lastname { get { return lname; } set { lname = value; } }
    }
}
