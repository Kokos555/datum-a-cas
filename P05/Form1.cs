using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] Jmena_a_primeni;
            DateTime Datum = DateTime.Now;
            DateTime Last;
            string nejstarsi_osoba = "";
            for(int i = 0; i < textBox1.Lines.Count(); i++)
            {
                string osoba = textBox1.Lines[i];
                Jmena_a_primeni = osoba.Split(';');
                Last = Convert.ToDateTime(Jmena_a_primeni[2]);
                if (Last < Datum)
                {
                    Datum = Last;
                    nejstarsi_osoba = Jmena_a_primeni[0] +' '+ Jmena_a_primeni[1];
                }
            }
            MessageBox.Show(string.Format($"{Datum:d} {nejstarsi_osoba}"));
        }
    }
}
