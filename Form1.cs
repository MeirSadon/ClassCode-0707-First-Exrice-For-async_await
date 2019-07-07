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

namespace WF___Class_Code_0707
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoWork()
        {
            Action a = () => { label1.Text = DateTime.Now.ToString(); };
            while (true)
            {
                Thread.Sleep(1000);
                //Solution 2.
                   //label1.BeginInvoke(a);
                //Solution 3.
                   this.BeginInvoke(a);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Solution 1.
            //while (true)
            //{
            //    label1.Text = DateTime.Now.ToString();
            //    await Task.Run(() => { Thread.Sleep(1000); });
            //}

            //Solution 2\3.
            Task.Run(() => { DoWork(); });
        }
    }
}
