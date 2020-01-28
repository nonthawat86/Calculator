using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string num1, num2, sum;
        Double resultValue = 0;
        String operatonPerformed = "";
        bool isOperatonPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperatonPerformed))
            {
                textBox1.Clear();
            }
            isOperatonPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }

        }
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                //btEqual_Click.PerformClick();
                operatonPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                operatonPerformed = button.Text;
                label1.Text = resultValue + " " + operatonPerformed;
                isOperatonPerformed = true;
            
            }
            else
            {
                operatonPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                operatonPerformed = button.Text;
                label1.Text = resultValue + " " + operatonPerformed;
                isOperatonPerformed = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            label1.Text = "";
            label5.Text = "";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            //label1.Text = "";
            //label5.Text = "";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            label5.Text = Double.Parse(textBox1.Text).ToString();
            num1 = label1.Text;
            num2 = label5.Text;
            switch (operatonPerformed)
            {
                case "+":

                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    sum = textBox1.Text;
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    sum = textBox1.Text;
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    sum = textBox1.Text;
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    sum = textBox1.Text;
                    break;
                default:
                    break;
            }
            textBox2.AppendText(num1 + "  " + num2 + " = " + "\r\n");
            textBox2.AppendText(sum + "\r\n\n");
        }
    }
}
