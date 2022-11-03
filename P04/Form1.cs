using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            string den = Convert.ToString(datum.DayOfWeek);
            switch (den)
            {
                case "Monday": MessageBox.Show(string.Format($"{den} je první pracovní den v týdnu")); break;
                case "Tuesday": 
                case "Wednesday":
                case "Thursday": MessageBox.Show(string.Format($"{den} není první ani poslední pracovní den")); break;
                case "Friday": MessageBox.Show(String.Format($"{den} je poslední pracovní den v týdnu"));break;
                case "Saturday":
                case "Sunday": MessageBox.Show(String.Format($"{den} je víkend"));break;
            }
        }
    }
}
