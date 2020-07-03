using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int countCharacter()
        {
            int count = 0;
            using (StreamReader filereader = new StreamReader(@"C:\fileprojectTest\note.txt"))
            {
                string content = filereader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);

            }
            return count;
        }
      
        private async void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            Task<int> task = new Task<int>(countCharacter);
            task.Start();
            Thread t = new Thread(() => 
            {
                count = countCharacter();
                Action action = new Action(setLebeltext);   
                this.BeginInvoke(action);
            });
            t.Start();

            
            label1.Text = "processing file please wait";
          //  t.Join();
          //  count = await task;
          //  label1.Text = count.ToString() + " " + " characters in the folder";
        }

        int countChar = 0;
        public void setLebeltext()
        {
            label1.Text = countChar.ToString() + " " + " characters in the folder";
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int count = 0;
        //    label1.Text = "processing file please wait";
        //    count = countCharacter();
        //    label1.Text = count.ToString() + " "+ " characters in the folder"; 
        //}
    }
}
