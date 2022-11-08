using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public bool MinTrvanlivostDny(DateTime prodej, int dny, out int pocet_dnu)
        {
            pocet_dnu = 0;
            DateTime ted = DateTime.Today;
            DateTime prodej2 = prodej.AddDays(dny);
            TimeSpan zaruka = prodej2 - ted;
            pocet_dnu = zaruka.Days;
            if (prodej2 > ted)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime prodej = dateTimePicker1.Value;
            int pocet_dnu_trvanlivosti = Convert.ToInt32(textBox1.Text);
            double cena = Convert.ToInt32(textBox2.Text);
            if (MinTrvanlivostDny(prodej, pocet_dnu_trvanlivosti, out int pocet_dnu))
            {
                if (pocet_dnu <= 3)
                {
                    cena -= cena * 0.25;
                    MessageBox.Show(String.Format($"Do konce minální trvanlivosti zbývá {pocet_dnu} dny, proto jsme zlevnili produkt o 25%, nová cena je {cena}"));
                }

            }
            else
            {
                if (pocet_dnu <= -10)
                {
                    MessageBox.Show(string.Format("Zboží už je neprodejné"));
                }
                else
                {
                    cena -= cena * 0.5;
                    MessageBox.Show(String.Format($"Minimální trvanlivost byla překročena o {Math.Abs(pocet_dnu)} dny, proto jsme zlevnili produkt o 50%, nová cena je {cena}"));
                }
            }
        }
    }
}
