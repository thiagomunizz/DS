using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastrarEmpresa.cs
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
        }
        public void cadEmpresa(int fk_IdEstado, string NmUsuario, string CnpjEmpresa, string DsEndereco, string NmEmpresa, string FoneEmpresa, string Razao)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=dbEmpresa;Data Source=LAB-06-11";
            conn.Open();


            String insert = String.Concat("insert into Empresa(fk_IdEstados,NmUsuario,CnpjEmpresa , DsEndereco, NmEmpresa, FoneEmpresa, Razao) values ('", fk_IdEstado, "','", NmUsuario, "','", CnpjEmpresa, "','", DsEndereco, "','", NmEmpresa, "','", FoneEmpresa, "','", Razao, "')");
            SqlCommand comandaSQL = new SqlCommand(insert, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();
        }

        public void retornarEmpresas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbEmpresa;Data Source=LAB-06-11";
            conexao.Open();

            //idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
            string comandoSQL = "SELECT IdEmpresa 'Código Empresa', NmEmpresa 'Nome', NmUsuario 'Nome de Usuário', DsEndereco 'Endereço', CnpjEmpresa 'CNPJ', foneEmpresa 'Telefone', Razao 'Razão Social' FROM Empresa";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvEmpresa.DataSource = dt;

            conexao.Close();
        }

        public void retornarEstados()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dbEmpresa;Data Source=LAB-06-11";
            conexao.Open();

            //idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
            string comandoSQL = "SELECT * from tbEstados";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            cbxEstados.DataSource = dt;
            cbxEstados.DisplayMember = "Estado";
            cbxEstados.ValueMember = "IdEstados";

            

            conexao.Close();
        }


        public void buscarEmpresa()
        {
            DataSet ds = new DataSet();
            SqlConnection conexao = null;

            try
            {
                conexao = new SqlConnection("Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=dbEmpresa;Data Source=LAB-06-11");
                conexao.Open();
                SqlCommand cmd = new SqlCommand("sp_RetornarEmpresa", conexao);
                cmd.CommandType = CommandType.StoredProcedure;

                if (txtBuscarEmpresa.Text != "")
                {
                    cmd.Parameters.AddWithValue("@NmEmpresa", txtBuscarEmpresa.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                dgvEmpresa.DataSource = ds.Tables[0];

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha na conexão!", "Erro!");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void limparCampos()
        {

            txtUsuario.Text = "";
            txtCnpj.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtRazao.Text = "";
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            cadEmpresa(int.Parse( cbxEstados.SelectedValue.ToString()) , txtUsuario.Text, txtCnpj.Text, txtEndereco.Text, txtNome.Text, txtTelefone.Text, txtRazao.Text);
            limparCampos();
            MessageBox.Show("Registro cadastrado", "Cadastrado");
            retornarEmpresas();
            buscarEmpresa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            retornarEmpresas();
            retornarEstados();
            buscarEmpresa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarEmpresa();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
       
        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEmpresa.Text = dgvEmpresa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNome.Text = dgvEmpresa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtUsuario.Text = dgvEmpresa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = dgvEmpresa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCnpj.Text = dgvEmpresa.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTelefone.Text = dgvEmpresa.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtRazao.Text = dgvEmpresa.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbxEstados.Text = dgvEmpresa.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}



/*
 public void cadAluno(int idAluno, string rgAluno, string cpfAluno, string dsEndereco, string nmAluno, string foneAluno, string curso)
        {
 * 55
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Program.nomeConexao;          
            conn.Open();


            string query = "";

            if (idAluno == 0)
            {
                query = String.Concat("insert into aluno(rgAluno,cpfAluno , dsEndereco, nmAluno, foneAluno, curso) values ('", rgAluno, "','", cpfAluno, "','", dsEndereco, "','", nmAluno, "','", foneAluno, "','", curso, "')");
            }
            else
            {
                query = String.Concat("update aluno set"); 
            }
            SqlCommand comandaSQL = new SqlCommand(query, conn);
            comandaSQL.ExecuteNonQuery();
            conn.Close();
        }
            private void limparCampos()
            {
                txtRg.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCurso.Text = "";
            }

            private void btnCadastrar_Click_1(object sender, EventArgs e)
            {
                cadAluno(int.Parse(txtIdAluno.Text), txtRg.Text, txtCpf.Text, txtEndereco.Text, txtNome.Text, txtTelefone.Text, txtCurso.Text);
                limparCampos();
                MessageBox.Show("Registro cadastrado", "Cadastrado");
                retornarAlunos();
            }

            private void btnLimpar_Click_1(object sender, EventArgs e)
            {
                txtRg.Text = "";
                txtCpf.Text = "";
                txtEndereco.Text = "";
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtCurso.Text = "";
            }

            public void retornarAlunos()
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Program.nomeConexao;
                conexao.Open();

                //idAluno, rgAluno, cpfAluno, dsEndereco, nmAluno, foneAluno, curso
                string comandoSQL = "SELECT idAluno 'Código Aluno', nmAluno 'Nome', cpfAluno 'CPF Aluno', dsEndereco 'Endereço', rgAluno 'RG', foneAluno 'Telefone', curso 'Curso' FROM Aluno";

                SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgvAluno.DataSource = dt;

                conexao.Close();
            }
 
            public void buscarAluno() {
                DataSet ds = new DataSet();
                SqlConnection conexao = null;

                try
                {
                    conexao = new SqlConnection(Program.nomeConexao);
                    conexao.Open();
                    SqlCommand cmd = new SqlCommand("sp_RetornarAluno", conexao);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (txtBuscarAluno.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@nmAluno", txtBuscarAluno.Text);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    dgvAluno.DataSource = ds.Tables[0];

                }
                catch (Exception e)
                {
                    MessageBox.Show("Falha na conexão! Caso o erro persista, contate o administrador.", "Erro!");
                }
                finally
                {
                    conexao.Close();
                }
            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                buscarAluno();
            }

            private void verAluno_Load(object sender, EventArgs e)
            {
                retornarAlunos();
            }


            private void dgvAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                txtIdAluno.Text = dgvAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCpf.Text = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEndereco.Text = dgvAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRg.Text = dgvAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTelefone.Text = dgvAluno.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCurso.Text = dgvAluno.Rows[e.RowIndex].Cells[6].Value.ToString();
            }



            

        
    }
}

 
 
 */