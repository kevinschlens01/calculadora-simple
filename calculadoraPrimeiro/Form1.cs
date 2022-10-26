using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraPrimeiro
{
    public partial class Form1 : Form

    {
        decimal valor1 = 0, valor2 = 0;
        string operacaco = "";
        private string operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtREsultado.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);

            if (operacaco == "SOMA") 
            {
               txtREsultado.Text = Convert.ToString(valor1 + valor2);
            } 
            else if (operacaco == "SUB")
            {
                txtREsultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacaco == "MULT")
            {
                txtREsultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacaco == "DIV")
            {
                txtREsultado.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
            txtREsultado.Text = "";
            operacaco = "SUB";
            lblOperacoes.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
            txtREsultado.Text = "";
            operacaco = "MULT";
            lblOperacoes.Text = "x";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
            txtREsultado.Text = "";
            operacaco = "DIV";
            lblOperacoes.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = "";
            lblOperacoes.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtREsultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacoes.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtREsultado.Text, CultureInfo.InvariantCulture);
            txtREsultado.Text = "";
            operacaco = "SOMA";
            lblOperacoes.Text = "+";
        }
    }
}
