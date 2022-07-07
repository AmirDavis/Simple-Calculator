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
        string operation = ""; //used so the program knows which operation to use
        string seperator = ""; //used to seperate the string into num1 and num2
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

        //adds the number 1 to tb_1
        private void Btn_1_Click(object sender, EventArgs e)
        {
            tb_1.Text += 1;
        }

        //adds the number 2 to tb_1
        private void Btn_2_Click(object sender, EventArgs e)
        {
            tb_1.Text += 2;
        }

        //adds the number 3 to tb_1
        private void Btn_3_Click(object sender, EventArgs e)
        {
            tb_1.Text += 3;
        }

        //adds the number 4 to tb_1
        private void Btn_4_Click(object sender, EventArgs e)
        {
            tb_1.Text += 4;
        }

        //adds the number 5 to tb_1
        private void Btn_5_Click(object sender, EventArgs e)
        {
            tb_1.Text += 5;
        }

        //adds the number 6 to tb_1
        private void Btn_6_Click(object sender, EventArgs e)
        {
            tb_1.Text += 6;
        }

        //adds the number 7 to tb_1
        private void Btn_7_Click(object sender, EventArgs e)
        {
            tb_1.Text += 7;
        }

        //adds the number 8 to tb_1
        private void Btn_8_Click(object sender, EventArgs e)
        {
            tb_1.Text += 8;
        }

        //adds the number 9 to tb_1
        private void Btn_9_Click(object sender, EventArgs e)
        {
            tb_1.Text += 9;
        }

        //adds ' + ' to tb_1 if the textbox is not empty 
        private void Btn_plus_Click(object sender, EventArgs e)
        {
            if(tb_1.Text != "")
            {
                num1 = double.Parse(tb_1.Text);
                tb_1.Text += " + ";
                seperator = " + ";
                operation = btn_plus.Text;
            }
        }

        //adds ' - ' to tb_1 if the textbox is not empty 
        private void Btn_minus_Click(object sender, EventArgs e)
        {
            if(tb_1.Text != "")
            {
                num1 = double.Parse(tb_1.Text);
                tb_1.Text += " - ";
                seperator = " - ";
                operation = btn_minus.Text;
            }
        }

        //adds ' / ' to tb_1 if the textbox is not empty 
        private void Btn_divide_Click(object sender, EventArgs e)
        {
            if (tb_1.Text != "")
            {
                num1 = double.Parse(tb_1.Text);
                tb_1.Text += " / ";
                seperator = " / ";
                operation = btn_divide.Text;
            }
        }

        //adds ' * ' to tb_1 if the textbox is not empty 
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

        //clears tb_1
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            tb_1.Clear();
        }

        //calculates the results of num1 and num2
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
