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
    public partial class frmTeste1 : Form
    {
        public frmTeste1()
        {
            InitializeComponent();
        }


        private void frmTeste1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txt1.Text);
            double valor2 = System.Convert.ToDouble(txt2.Text);
            double soma = valor1 + valor2;
            if (soma >= 20)
            { txt3.Text += soma + 8; }
            else { txt3.Text += soma - 5; }
        }
    }
}
