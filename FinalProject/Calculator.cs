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

namespace FinalProject
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operators.Text = "-";
            if (label1.Text != "")
            {
                label3.Text = label1.Text;

            }

            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            operators.Text = "";
            label3.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operators.Text = "+";

            if (label1.Text != "")
            {
                label3.Text = label1.Text;

            }

            label1.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            operators.Text = "X";
            if (label1.Text != "")
            {
                label3.Text = label1.Text;

            }

            label1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operators.Text = "/";
            if (label1.Text != "")
            {
                label3.Text = label1.Text;

            }

            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
          label1.Text = label1.Text + ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            double fn;
            double sn;
            double result = 0;

            fn = Convert.ToDouble(label3.Text);
            sn = Convert.ToDouble(label1.Text);

            if (operators.Text == "+")
            {
                result = fn + sn;
            }
            if (operators.Text == "-")
            {
                result = fn - sn;
            }
            if (operators.Text == "X")
            {
                result = fn * sn;
            }
            if (operators.Text == "/")
            {
                result = fn / sn;
            }

            label1.Text = result.ToString();

            operators.ResetText();
            label3.ResetText();

        }
    }
}
