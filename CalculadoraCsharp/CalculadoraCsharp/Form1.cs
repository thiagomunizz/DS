using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double var1;
        string op;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 1;
            textBox1.Text = textBox1.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 2;
            textBox1.Text = textBox1.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 3;
            textBox1.Text = textBox1.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 4;
            textBox1.Text = textBox1.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 5;
            textBox1.Text = textBox1.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 6;
            textBox1.Text = textBox1.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 7;
            textBox1.Text = textBox1.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 8;
            textBox1.Text = textBox1.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 9;
            textBox1.Text = textBox1.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 0;
            textBox1.Text = textBox1.Text + 0;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            btnigual.PerformClick();
            textBox1.Text = textBox1.Text + "+";
            op = "+";
            textBox1.Clear();
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "-";
            btnigual.PerformClick();
            textBox1.Text = textBox1.Text + "-";
            op = "-";
            textBox1.Clear();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "*";
            btnigual.PerformClick();
            textBox1.Text = textBox1.Text + "*";
            op = "*";
            textBox1.Clear();
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "/";
            btnigual.PerformClick();
            textBox1.Text = textBox1.Text + "/";
            op = "/";
            textBox1.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                textBox1.Text = (var1 + Double.Parse(textBox1.Text)).ToString();
                break;

                case "-":
                textBox1.Text = (var1 - Double.Parse(textBox1.Text)).ToString();
                break;

                case "/":
                textBox1.Text = (var1 / Double.Parse(textBox1.Text)).ToString();
                break;

                case "*":
                textBox1.Text = (var1 * Double.Parse(textBox1.Text)).ToString();
                break;
            }

            var1 = Double.Parse(textBox1.Text);
            op = "";
        }
    }
}
