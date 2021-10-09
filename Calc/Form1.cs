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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExpressionLabel.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExpressionLabel.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ExpressionLabel.Text[ExpressionLabel.Text.Count() - 1] != '+')
            ExpressionLabel.Text += "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ExpressionLabel.Text[ExpressionLabel.Text.Count() - 1] != '*')
                ExpressionLabel.Text += "*";
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (ExpressionLabel.Text[ExpressionLabel.Text.Count() - 1] != '*' && ExpressionLabel.Text[ExpressionLabel.Text.Count() - 1] != '+')
            {
                label2.Text = "= " + (new DataTable().Compute(ExpressionLabel.Text, null)).ToString();
            }
        }
    }
}
