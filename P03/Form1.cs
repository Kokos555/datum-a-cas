using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeDatum(string datum, out DateTime narozen, out string zprava)
        {
            zprava = string.Format("Správné datum narození");
            narozen = new DateTime();
            if (!maskedTextBox1.MaskCompleted)
            {
                zprava = string.Format("Datum narození není vyplněno");
                return false;
            }
            string den = datum.Substring(0, 2);
            string mesic = datum.Substring(3, 2);
            string rok = datum.Substring(6, 4);
            int rokc = Int32.Parse(rok);
            int mesc = Int32.Parse(mesic);
            int denc = Int32.Parse(den);
            if (mesc <1 || mesc > 12)
            {
                zprava = String.Format("Špatný měsíc");
                return false;
            }
            int pocetdni = DateTime.DaysInMonth(rokc, mesc);
            if (denc < 1 || denc > pocetdni)
            {
                zprava = String.Format("Špatný den!");
                return false;
            }
            narozen = Convert.ToDateTime(datum);
            return true;

        }

        private int Vek(DateTime narozeni, out int pocet_dny)
        {
            DateTime Now = DateTime.Now;
            int years = Now.Year - narozeni.Year;
            if (Now < narozeni.AddYears(years))
            {
                years--;
            }
            TimeSpan rozdil = Now - narozeni;
            pocet_dny = rozdil.Days;
            return years;
            

        }

        private bool JeRodneCislo(string datum, out DateTime narozen, out string zprava)
        {
            zprava = string.Format("Správné rodné číslo");
            narozen = new DateTime();
            if (!maskedTextBox1.MaskCompleted)
            {
                zprava = string.Format("Rodné číslo není vyplněno");
                return false;
            }
            string rok = datum.Substring(0, 2);
            string mesic = datum.Substring(2, 2);
            string den = datum.Substring(4, 2);
            datum = datum.Remove(6,1);
            long cislo = Int64.Parse(datum);
            if (cislo % 11 != 0)
            {
                zprava = string.Format("Toto není rodné číslo, protože není dělitelné číslem 11");
                return false;
            }
            int rokc = Int32.Parse(rok);
            int mesc = Int32.Parse(mesic);
            int denc = Int32.Parse(den);

            return true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "90/90/0000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "000000\\/0009";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datum = maskedTextBox1.Text;
            if (radioButton1.Checked)
            {
                if(JeDatum(datum, out DateTime narozen, out string zprava))
                {
                   MessageBox.Show(string.Format($"{zprava}"));
                    label1.Text = String.Format($"Věk: {Vek(narozen, out int pocet_dny)}");
                    label2.Text = String.Format($"Dnů: {pocet_dny}");
                    

                }
                else
                {
                    MessageBox.Show(string.Format($"{zprava}"));
                }
            }else
            {

            }
        }
    }
}
