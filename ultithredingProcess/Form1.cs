using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ultithredingProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;

            Thread workThread = new Thread(DotimeConsumingWork);
            workThread.Start();

           // DotimeConsumingWork();

            button1.Enabled = true;
            button2.Enabled = true;


        }

        public void DotimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int a=1; a <= 10; a++)
            {
                listBox1.Items.Add(a);
            }
        }
    }
}
