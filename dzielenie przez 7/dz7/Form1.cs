using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string input = inputField.Text;

            if (int.TryParse(input, out int number))
            {
                if (number % 7 == 0)
                {
                    outputLabel.Text = "tak";
                }
                else
                {
                    outputLabel.Text = "nie";
                }
            }
            else
            {
                outputLabel.Text = "wpisz liczbe!";
            }
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = "";
        }
        private void outputLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nie kliknieto");
        }

    }

}

