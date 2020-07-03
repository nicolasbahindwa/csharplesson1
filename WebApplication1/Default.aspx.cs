using partialClass_l3esson30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.firstname = "Nicolas";
            c.lastname = "bahindwa";

            string fullname = c.GetFullName();

            Response.Write("fullname is " + c.GetFullName() + "</br>");


            partialCustomer cp = new partialCustomer();
            cp.firstname = "chrspin";
            cp.lastname = "bahindwa";

            string fullname2 = cp.GetFullName();

            Response.Write("fullname is " + fullname2+"</br>");
        }
    }
}