using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string operation;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void display(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void B2(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }

        }

        private void B1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void OPERATER(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void Equ(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
    }
}
