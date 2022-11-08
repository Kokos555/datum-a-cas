using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static public bool Dny(DateTime prodej, int roky, out int pocet_dnu)
        {
            pocet_dnu = 0;
            DateTime ted = DateTime.Today;
            DateTime prodej2 = prodej.AddYears(roky);
            if (prodej2 > ted)
            {
                TimeSpan zaruka = prodej2 - ted;
                pocet_dnu = zaruka.Days;
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime prodej = dateTimePicker1.Value;
            int roky = Convert.ToInt32(textBox1.Text);
            if (Dny(prodej, roky,out int pocet_dnu))
            {
                MessageBox.Show(string.Format($"Zboží je ještě v záruce, a to {pocet_dnu}"));
            }
            else
            {
                MessageBox.Show(string.Format("Zboží už v záruce není"));
            }

        }
    }
}
