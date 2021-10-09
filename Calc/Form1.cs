using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        double result;
        public Form1()
        {
            InitializeComponent();
        }
        private void enterValue(string value)
        {
            int index = ExpressionLabel.Text.Count();
            
            if (checkOperation(Convert.ToString(ExpressionLabel.Text[index - 1])) && checkOperation(value))
            {
                ExpressionLabel.Text = ExpressionLabel.Text.Remove(index - 1);
                ExpressionLabel.Text += value;
                return;
            }
            if (index == 1)
            {
                if (ExpressionLabel.Text[0] == '0' && value != "." && checkOperation(value) == false)
                {
                    ExpressionLabel.Text = value;
                }
                else
                {
                    ExpressionLabel.Text += value;
                }
            }
            else
            {
                ExpressionLabel.Text += value;
            }
        }
        private bool checkOperation(string operation)
        {
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                return true;
            }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enterValue("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enterValue("2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
                enterValue("+");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enterValue("*");
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            int index = ExpressionLabel.Text.Count();
            try
            {
                if (!checkOperation(Convert.ToString(ExpressionLabel.Text[index - 1])))
                {
                    ExpressionLabel.Text = ExpressionLabel.Text.Replace(',', '.');
                    result = Convert.ToDouble(new DataTable().Compute(ExpressionLabel.Text, null));
                    if (double.IsInfinity(result) || double.IsNaN(result))
                    {
                        throw new DivideByZeroException();
                    }
                    label2.Text = "= " + result.ToString();
                }
            }
            catch (DivideByZeroException)
            {
                label2.Text = "= Деление на ноль!";
            }
            catch (Exception)
            {
                if (index > 1 && ExpressionLabel.Text[index - 1] == '.')
                   ExpressionLabel.Text = ExpressionLabel.Text.Remove(index - 1);
               // else ExpressionLabel.Text = result.ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enterValue("3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            enterValue("4");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enterValue("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            enterValue("6");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            enterValue("7");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enterValue("8");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            enterValue("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            enterValue("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            enterValue(".");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = ExpressionLabel.Text.Count();
            if (index > 1)
            {
                ExpressionLabel.Text = ExpressionLabel.Text.Remove(index - 1);
            }
            else ExpressionLabel.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            enterValue("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            enterValue("/");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            ExpressionLabel.Text = result.ToString();
            
        }
    }
}
