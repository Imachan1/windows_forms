using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{13,15}$");
            long c = long.Parse(textBox1.Text);

            if (regex.IsMatch(textBox1.Text))
            {
                if (Sprawdzenie(c))
                    label1.Text = $"Liczba {c} jest podzielna przez 3 i 11";
                else
                    label1.Text = $"Liczba {c} nie jest podzielna przez 3 i 11";
            }
            else
                label1.Text = "Blędne dane";

        }

        private static bool Sprawdzenie(long liczba)
        {
            long wynik = 0;
            int i = 1;
            long cyfra;
            while (liczba > 0)
            {
                cyfra = liczba % 10;
                liczba /= 10;
                if (i % 2 == 0)
                    wynik += cyfra;
                else
                    wynik -= cyfra;
                i++;
            }

            if (wynik % 3 == 0 && wynik % 11 == 0)
                return true;
            return false;
        }
    }
}
