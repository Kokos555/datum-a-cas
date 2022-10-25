using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime narozeni = dateTimePicker1.Value;
            DateTime dnesni_datum = DateTime.Now;
            int rok = dnesni_datum.Year - narozeni.Year;
            narozeni.AddYears(rok);
            if (narozeni.Day > dnesni_datum.Day)
            {
                rok--;
            }
            MessageBox.Show(String.Format($"{rok}"));
            
            //30. října 2020, 22 let. 30

        }
    }
}
