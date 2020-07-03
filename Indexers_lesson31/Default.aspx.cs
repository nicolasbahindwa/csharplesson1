using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexers_lesson31
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["session1"] = "session data1";
            //Session["session2"] = "session data2";

            //Response.Write("Session 1 is = " + Session[0].ToString());
            //Response.Write("</br>");
            //Response.Write("Session 2 is = " + Session["session2"].ToString());

            company emp = new company();

            Response.Write("employee is id = 2:" + emp[2]);
            Response.Write("<br>");
            Response.Write("employee is id = 5:" + emp[5]);
            Response.Write("<br>");
            Response.Write("employee is id = 8:" + emp[8]);
            Response.Write("<br>");

            Response.Write("changing the name of 2,5,8");
            Response.Write("<br>");
            Response.Write("<br>");

            emp[2]=("2nd emp name changed");
            emp[5]=("5th emp name changed");
            emp[8]=("8nth emp name changed");

            Response.Write("employee is id = 2:" + emp[2]);
            Response.Write("<br>");
            Response.Write("employee is id = 5:" + emp[5]);
            Response.Write("<br>");
            Response.Write("employee is id = 8:" + emp[8]);
            Response.Write("<br>");
        }
    }
}