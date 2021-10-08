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
            label1.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(label1.Text[label1.Text.Count() - 1] != '+')
            label1.Text += "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text[label1.Text.Count() - 1] != '*')
                label1.Text += "*";
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (label1.Text[label1.Text.Count() - 1] != '*' && label1.Text[label1.Text.Count() - 1] != '+')
            {
                label2.Text = (new DataTable().Compute(label1.Text, null)).ToString();
            }
        }
    }
}
