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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double nmr1 = System.Convert.ToDouble(txt1.Text);
            if (nmr1 <= 50)
            {

                for (int i = 1; i <= nmr1; i++)
                {
                    txt2.Text += i + "\n";
                }
            }
            else
                txt2.Text = ("Somente numeros até 50");
        }
    }
}
