using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            string currentText = textBox1.Text;

            if (!currentText.EndsWith(".") && !CheckIfLastCharMO(currentText))
            {
                textBox1.Text += ".";
            }
        }

        private bool CheckIfLastCharMO(string text)
        {
            if (text.Length > 0)
            {
                char lastChar = text[text.Length - 1];
                return (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/');
            }
            return false;
        }
        private void OperationButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Tag.ToString();
        }
        private void EqualsButtonClick(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(textBox1.Text, " ");
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Błąd";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                double result = Math.Pow(number, 2);
                textBox1.Text = result.ToString();
            }
            else
            {
                textBox1.Text = "Błąd";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                if (number >= 0)
                {
                    double result = Math.Sqrt(number);
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Błąd- liczba nie może być ujemna";
                }
            }
            else
            {
                textBox1.Text = "Błąd";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}