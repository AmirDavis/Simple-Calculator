using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class Calculator : Form
    {
        double num1, num2;
        double result;
        string operation = "";
        string seperator = "";
        string s1;
        public Calculator()
        {
            InitializeComponent();
        }

        //adds 0 to the text box if there is already a number present
        private void Btn_0_Click(object sender, EventArgs e)
        {
            if(tb_1.Text != "")
            {
                tb_1.Text += 0;
            }
        }

        //adds 1 to the text box
        private void Btn_1_Click(object sender, EventArgs e)
        {
            tb_1.Text += 1;
        }

        //adds 2 to the text box
        private void Btn_2_Click(object sender, EventArgs e)
        {
            tb_1.Text += 2;
        }


        private void Btn_3_Click(object sender, EventArgs e)
        {
            tb_1.Text += 3;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            tb_1.Text += 4;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            tb_1.Text += 5;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            tb_1.Text += 6;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            tb_1.Text += 7;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            tb_1.Text += 8;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            tb_1.Text += 9;
        }

        private void Btn_plus_Click(object sender, EventArgs e)
        {
            if(tb_1.Text != "")
            {
                num1 = int.Parse(tb_1.Text);
                tb_1.Text += " + ";
                seperator = " + ";
                operation = btn_plus.Text;
            }
        }

        private void Btn_minus_Click(object sender, EventArgs e)
        {
            if(tb_1.Text != "")
            {
                num1 = int.Parse(tb_1.Text);
                tb_1.Text += " - ";
                seperator = " - ";
                operation = btn_minus.Text;
            }
        }

        private void Btn_divide_Click(object sender, EventArgs e)
        {
            if (tb_1.Text != "")
            {
                num1 = int.Parse(tb_1.Text);
                tb_1.Text += " / ";
                seperator = " / ";
                operation = btn_divide.Text;
            }
        }

        private void Btn_multiply_Click(object sender, EventArgs e)
        {
            if (tb_1.Text != "")
            {
                num1 = double.Parse(tb_1.Text);
                tb_1.Text += " * ";
                seperator = " * ";
                operation = btn_multiply.Text;
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            tb_1.Clear();
        }

        private void Btn_equals_Click(object sender, EventArgs e)
        {
            int seperatorIndex; 
            s1 = tb_1.Text;
            seperatorIndex = s1.IndexOf(seperator);
            num2 = int.Parse(s1.Substring(seperatorIndex + 3));

            
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    tb_1.Text = result.ToString();
                    break;
                case "-":
                    result = num1 - num2;
                    tb_1.Text = result.ToString();
                    break;
                case "/":
                    result = num1 / num2;
                    tb_1.Text = result.ToString();
                    break;
                case "*":
                    result = num1 * num2;
                    tb_1.Text = result.ToString();
                    break;
            }  
        }
    }
}
