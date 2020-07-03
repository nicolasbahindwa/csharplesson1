using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Reflection_less0n23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typeName = textBox1.Text;

            Type T = Type.GetType(typeName);

            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo mth in methods)
            {
                listBox1.Items.Add(mth.ReturnType +" "+ mth.Name);
            }

            PropertyInfo[] prop = T.GetProperties();
            foreach (PropertyInfo pr in prop)
            {
                listBox2.Items.Add(pr.PropertyType.Name + " " + pr.Name);
            }

            ConstructorInfo[] constr = T.GetConstructors();
            foreach (ConstructorInfo c in constr)
            {
                listBox3.Items.Add(c.Name);
            }

        }
    }
}
