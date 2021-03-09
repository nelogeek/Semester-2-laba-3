using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //Криво, но работает..
        private double value1  = 0.0;
        private byte m_opearation = 0;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
        }

        private void digit1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text += "1";

        }

        private void digit2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
        }

        private void digit3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
        }

        private void digit4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
        }

        private void digit5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
        }

        private void digit6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
        }

        private void digit7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text += "7";
        }

        private void digit8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text += "8";
        }

        private void digit9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text += "9";
        }

        private void digit0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";
        }

        private void operatorcomma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.LastIndexOf(',') < 0)
                textBox1.Text = textBox1.Text + ",";
        }

        private void operatorsign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back && textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
            else if (e.KeyCode == Keys.Escape)
            {
                textBox1.Text = "0";
                value1 = 0.0;
                m_opearation = 0;
            }
        }

        private void operatorequal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
                return;

            double value2 = Convert.ToDouble(textBox1.Text);
            double result = 0.0;

            double value1 = this.value1;
            switch (m_opearation)
            {
                case 1:
                    result = value1 + value2;
                    break;
                case 2:
                    result = value1 - value2;
                    break;
                case 3:
                    result = value1 * value2;
                    break;
                case 4:
                    result = value1 / value2;
                    break;
            }

            textBox1.Text = result.ToString();
            value1 = 0.0;
            m_opearation = 0;
        }

        private void operatorplus_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            m_opearation = 1;
            textBox1.Text = "0";
        }

        private void operatorminus_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            m_opearation = 2;
            textBox1.Text = "0";
        }

        private void operatormul_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            m_opearation = 3;
            textBox1.Text = "0";
        }

        private void operatordiv_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(textBox1.Text);
            m_opearation = 4;
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }









        //Дебажить:С плюсом происходит кривое сложение, может посчитать произведение только двух чисел,
        //и другие мелочи...
    }
}
