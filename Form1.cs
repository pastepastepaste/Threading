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

namespace Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" - Before starting - ");
            ThreadStart Thread = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(Thread);
            ThreadA.Start();
            ThreadA.Name = "Thread A";

            Thread ThreadB = new Thread(Thread);
            ThreadB.Start();
            ThreadB.Name = "Thread B";
            
          
            
          
            ThreadA.Join();
            ThreadB.Join();

            label.Text = "- End of Thread ";
            Console.WriteLine(label.Text.ToString());
        }
    }
}
