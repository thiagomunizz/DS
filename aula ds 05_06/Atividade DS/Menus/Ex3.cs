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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double nmr1 = System.Convert.ToDouble(txt1.Text);
            double nmr2 = System.Convert.ToDouble(txt2.Text);
            double nmr3 = System.Convert.ToDouble(txt3.Text);

            if (nmr1 == nmr2 && nmr2 == nmr3)
            {
                label4.Text = ("") + "Equilátero ";
            }
            else if (nmr1 == nmr2 && nmr2 != nmr3)
            {
                label4.Text = ("") + "Isósceles ";
            }
            else if (nmr1 != nmr2 && nmr2 == nmr3)
            {
                label4.Text = ("") + "Isósceles ";
            }
            else if (nmr1 == nmr3 && nmr2 != nmr3)
            {
                label4.Text = ("") + "Isósceles ";
            }
            else if (nmr1 != nmr2 && nmr2 != nmr3)
            {
                label4.Text = ("") + "Escaleno ";
            }
        }
    }
}
