using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string liczba= textBox1.Text;

            Regex regex = new Regex(@"^\d{7,8}$");

            


            if (!regex.IsMatch(liczba))
            {
                label1.Text = "Blędne dane!";
            }
            else
            {
                int suma1 = 0;
                int suma2 = 0;

                for (int i = 0;i<liczba.Length;i++)
                {
                    int znak=(int)liczba[i];
                    if (i % 2 == 0)
                    {
                        suma1 += znak;
                    }
                    else
                    {
                        suma2 += znak;
                    }
                }

                if (suma1 == suma2)
                {
                    label1.Text = "TAK";
                    label2.Text = $"{suma1}";
                    label3.Text = $"{suma2}";
                }
                else
                {
                    label1.Text = "NIE";
                    label2.Text = $"{suma1}";
                    label3.Text = $"{suma2}";
                }
            }

        }
    }
}
