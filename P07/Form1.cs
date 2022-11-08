using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime begin;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            begin = DateTime.Now;
            label1.Text = String.Format(" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            DateTime Stop = DateTime.Now;
            TimeSpan rozdil = Stop - begin;
            label1.Text = String.Format($"Time: {rozdil.Minutes} minutes : {rozdil.Seconds} second");

        }
    }
}
