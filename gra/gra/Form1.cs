using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random losuj = new Random();
            List<TextBox> textBoxes = new List<TextBox>
                { 
                    textBox1,textBox2,textBox3,
                    textBox4,textBox5,textBox6,
                    textBox7,textBox8,textBox9
                };

            bool Mazero = textBoxes.Any(b => b.Text == "0");
            if (!Mazero) 
            {
                MessageBox.Show("wpisz zero!");
                return;
            }

            var puste = textBoxes.Where(b=>string.IsNullOrWhiteSpace(b.Text)).ToList();

            int indeks =losuj.Next(puste.Count);
            puste[indeks].Text = "X";

            var liczba = puste.Count;

            
            if(textBox1.Text == "X" && textBox2.Text=="X" && textBox3.Text=="X")
            {
                label1.Text = "X wygrał";
            }
            else if (textBox4.Text == "X" && textBox5.Text == "X" && textBox6.Text == "X")
            {
                label1.Text = "X wygrał";
            }
            else if (textBox7.Text == "X" && textBox8.Text == "X" && textBox9.Text == "X")
            {
                label1.Text = "X wygrał";
            }


            else if (textBox1.Text == "X" && textBox4.Text == "X" && textBox7.Text == "X")
            {
                label1.Text = "X wygrał";
            }
            else if (textBox2.Text == "X" && textBox5.Text == "X" && textBox8.Text == "X")
            {
                label1.Text = "X wygrał";
            }
            else if (textBox3.Text == "X" && textBox6.Text == "X" && textBox9.Text == "X")
            {
                label1.Text = "X wygrał";
            }


            else if (textBox1.Text == "X" && textBox5.Text == "X" && textBox9.Text == "X")
            {
                label1.Text = "X wygrał";
            }
            else if (textBox3.Text == "X" && textBox5.Text == "X" && textBox7.Text == "X")
            {
                label1.Text = "X wygrał";
            }
            else
            {
                label1.Text = "0 wygrał";
            }



        }
    }
}
