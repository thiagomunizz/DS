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
    public partial class frmTeste2 : Form
    {
        public frmTeste2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double nmr = System.Convert.ToDouble(txt1.Text);

            if (nmr % 10 == 0 && nmr % 5 == 0 && nmr % 2 == 0)
            {
                label2.Text = nmr.ToString() + " é divisivel por 10, 5 e 2.";
            }
            else if (nmr % 10 == 0)
            {
                label2.Text = nmr.ToString() + " é divisivel por 10.";
            }
            else if (nmr % 5 == 0)
            {
                label2.Text = nmr.ToString() + " é divisivel por 5.";
            }
            else if (nmr % 2 == 0)
            {
                label2.Text = nmr.ToString() + " é divisivel por 2.";
            }
            else
            {
                label2.Text = nmr.ToString() + " nao é divisivel por 10, 5 ou 2.";
            }

        }
    }
}
