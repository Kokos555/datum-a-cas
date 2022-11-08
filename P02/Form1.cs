using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
            DateTime Now = DateTime.Now;
            int years = Now.Year - narozeni.Year;
            /*if (Now < narozeni.AddYears(years))
            {
                years--;
            }*/
            

            

            int months = Now.Month - narozeni.Month;

            if (Now.Day < narozeni.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            int days = (Now - narozeni.AddMonths((years * 12) + months)).Days;
            int hour = Now.Hour;
            MessageBox.Show($"Je ti {years} let {months} měsíců {days} dní a {hour} hodin");

            //30. října 2020, 22 let. 30

        }
    }
}
