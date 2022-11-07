using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public int PocetDni(int year, DateTime datum_narozeni)
        {
            datum_narozeni = datum_narozeni.AddYears(year);
            DateTime dnesni_datum = DateTime.Now;
            int vysledek = (dnesni_datum - datum_narozeni).Days;
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            int cislo = PocetDni(65, datum);
            if (cislo>=65) { 
                MessageBox.Show(String.Format($"Osoba dosáhla důchodového věku, a v dúchodu strávila {cislo} dní"));
            }
            else
            {
                MessageBox.Show(String.Format($"Osoba nedosáhla důchodového věku a do důchodu chybí {Math.Abs(cislo)} dnů"));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime datum = dateTimePicker1.Value;
            int cislo = PocetDni(0, datum);
            if (cislo > 0)
            {
                MessageBox.Show(String.Format($"Od narození dané osoby uplinulo {cislo} dní"));
            }
            else
            {
                MessageBox.Show(string.Format("Daná osoba se ještě nenarodila"));
            }
        }
    }
}
