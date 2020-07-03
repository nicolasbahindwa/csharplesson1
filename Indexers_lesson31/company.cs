using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indexers_lesson31
{
    public class company
    {
        private List<employee> emplist;
        public company()
        {
            emplist = new List<employee>();
            emplist.Add(new employee() { empID = 1, name = "nicolas", gender = "male" });
            emplist.Add(new employee() { empID = 2, name = "crisoin", gender = "male" });
            emplist.Add(new employee() { empID = 5, name = "james", gender = "male" });
            emplist.Add(new employee() { empID = 8, name = "lucas", gender = "male" });
        }

        public string this[int empid]
        {
            get 
            {
                return emplist.FirstOrDefault(emp => emp.empID == empid).name; 
            }
            set 
            {
                emplist.FirstOrDefault(emp => emp.empID == empid).name = value;
            }
        }
    }

    public class employee
    {
        public int empID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

    }


}