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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste1 tst1 = new frmTeste1(); //criando uma instância do formulário Teste1
            tst1.MdiParent = this; //esta linha define que a instância do formulário criado é "filho" do formulário principal
            tst1.Show(); //esta linha exibe o formúlário Teste1
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeste2 tst2 = new frmTeste2(); //criando uma instância do formulário Teste1
            tst2.MdiParent = this; //esta linha define que a instância do formulário criado é "filho" do formulário principal
            tst2.Show(); //esta linha exibe o formúlário Teste1
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void aquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex3 exercicio3 = new Ex3(); //criando uma instância do formulário Ex3
            exercicio3.MdiParent = this; //esta linha define que a instância do formulário criado é "filho" do formulário principal
            exercicio3.Show(); //esta linha exibe o formúlário Ex3
        }

        private void ex4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex4 exercicio4 = new Ex4(); //criando uma instância do formulário Ex4
            exercicio4.MdiParent = this; //esta linha define que a instância do formulário criado é "filho" do formulário principal
            exercicio4.Show(); //esta linha exibe o formúlário Ex4
        }

        private void ex5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex5 exercicio5 = new Ex5(); //criando uma instância do formulário Ex5
            exercicio5.MdiParent = this; //esta linha define que a instância do formulário criado é "filho" do formulário principal
            exercicio5.Show(); //esta linha exibe o formúlário Ex5
        }

        private void ex6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex6 exercicio6 = new Ex6(); //criando uma instância do formulário Ex6
            exercicio6.MdiParent = this; //esta linha define que a instância do formulário criado é "filho" do formulário principal
            exercicio6.Show(); //esta linha exibe o formúlário Ex6
        }

        private void ex7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ex7 exercicio7 = new Ex7(); //criando uma instância do formulário Ex7
            exercicio7.MdiParent = this; //esta linha define que a instância do formulário criado é "filho" do formulário principal
            exercicio7.Show(); //esta linha exibe o formúlário Ex7




        }
    }
}
