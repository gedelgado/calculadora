using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        String c;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textBox1.Text);
            c = "/";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textBox1.Text);
            c = "*";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textBox1.Text);
            c = "-";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textBox1.Text);
            c = "+";
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.textBox1.Text);
            switch (c)
            {
                case "+":
                    this.textBox1.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.textBox1.Text = Convert.ToString(a - b);
                    break;

                case "*":
                    this.textBox1.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.textBox1.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Contains('.') == false)
            {
                this.textBox1.Text = this.textBox1.Text + ".";
            }
        }
    }
}