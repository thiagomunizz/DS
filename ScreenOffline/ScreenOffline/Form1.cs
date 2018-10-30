using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ScreenOffline
{
    public partial class Form1 : Form
    {
        // criar uma lista para armazenar uma lista na memoria
        private List<Funcionario> listaMemoria = new List<Funcionario>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // estancia um obj funcionario
            Funcionario func = new Funcionario();
            // pega os dados do input nome
            func.nmFuncionario = txtNome.Text;
            func.nmCidade = txtCidade.Text;
            func.salario = float.Parse(txtSalario.Text);
            // adiciona o obj a list
            listaMemoria.Add(func);
            // atualiza o grid com os dados do input
            dgvFuncionario.DataSource = null;
            dgvFuncionario.DataSource = listaMemoria;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Program.conexao;
            conn.Open();

            foreach (Funcionario item in listaMemoria)
            {
                string query = string.Concat("INSERT INTO aluno VALUES ('",item.nmFuncionario,"','",item.nmCidade,"','",item.salario,"')");
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
            }

            MessageBox.Show("Dados inseridos no banco de dados");

            conn.Close();

            listaMemoria = new List<Funcionario>();

            dgvFuncionario.DataSource = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = Program.conexao;
            conn.Open();

            SqlDataReader reader;
            string query = string.Concat("SELECT * FROM aluno");
            SqlCommand sqlcommand = new SqlCommand(query, conn);

            reader = sqlcommand.ExecuteReader();
            DataTable dt = new DataTable();
            // DataTable dc = new DataTable();
            dt.Columns.Add("nmFuncionario", typeof(string));
            dt.Columns.Add("cidade", typeof(string));
            dt.Load(reader);
            cbFunc.ValueMember = "nmFuncionario";
            cbCidade.ValueMember = "cidade";
            cbFunc.DataSource = dt;
            cbCidade.DataSource = dt;

            conn.Close();
        }
    }
}
