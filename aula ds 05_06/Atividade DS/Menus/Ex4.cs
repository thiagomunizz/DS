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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double nmr = System.Convert.ToDouble(txt1.Text);

            if (nmr == 1)
            {
                label1.Text = ("O mês é Janeiro") ;
            }
            else if (nmr ==2)
            {
                label1.Text = ("O mês é Fevereiro");
            }
            else if (nmr == 3)
            {
                label1.Text = ("O mês é Março");
            }
            else if (nmr == 4)
            {
                label1.Text = ("O mês é Abril");
            }
            else if (nmr ==5)
            {
                label1.Text = ("O mês é Maio");
            }
            else if (nmr == 6)
            {
                label1.Text = ("O mês é Junho");
            }
            else if (nmr == 7)
            {
                label1.Text = ("O mês é Julho");
            }
            else if (nmr == 8)
            {
                label1.Text = ("O mês é Agosto");
            }
            else if (nmr == 9)
            {
                label1.Text = ("O mês é Setembro");
            }
            else if (nmr == 10)
            {
                label1.Text = ("O mês é Outubro");
            }
            else if (nmr == 11)
            {
                label1.Text = ("O mês é Novembro");
            }
            else if (nmr == 12)
            {
                label1.Text = ("O mês é Dezembro");
            }
            else
            {
                label1.Text = ("Este número não corresponde aos meses!");
            }

        }
    }
}
