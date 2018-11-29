using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastrarcarro(string modelo, string cor, string ano, string marca, string combustivel)
        {
            //conexão com banco
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Password=info211;Persist Security Info=True;User ID=sa;Initial Catalog=dbThiago;Data Source=LAB-01-10";

            //abrir conexão
            conexao.Open();

            //inseri texto de insert
            //string InsertCarro = string.Concat("insert into carro values (modeloCarro,corCarro,anoCarro,idMarca,idCombustivel) ( '", modelo, "','','", cor, "','", ano, "','"combomarcas.SelectedValue"',)";
            string insert = "insert into carro  (modeloCarro,corCarro,anoCarro,idMarca,idCombustivel) values ('" + txtmodelo.Text + "','" + txtcor.Text + "','" + txtano.Text + "','" + combomarcas.SelectedValue + "','" + combocombustivel.SelectedValue + "')";
            //insere texto de insert em nova consulta
            SqlCommand comandaSQL = new SqlCommand(insert, conexao);

            //Tecla F5
            comandaSQL.ExecuteNonQuery();

            //Fechando a Conexão
            conexao.Close();
        }


        private void btncad_Click(object sender, EventArgs e)
        {

            Cadastrarcarro(txtmodelo.Text, txtcor.Text, txtano.Text, combomarcas.Text, combocombustivel.Text );
            mostrarCarros();

            MessageBox.Show("Carro Cadastrado!");

            txtmodelo.Clear();
            txtcor.Clear();
            txtano.Clear();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtmodelo.Clear();
            txtcor.Clear();
            txtano.Clear();
        }

        private void mostrarCarros()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string comandoSQL = "SELECT C.modeloCarro as 'Modelo do Carro',C.corCarro as 'Cor do Carro',C.anoCarro as 'Ano do Carro',M.marca as 'Marca do Carro',CB.combustivel as 'Combustível' FROM carro C, marca M, combustivel CB WHERE (M.idMarca = C.idMarca)  AND (CB.idCombustivel = C.idCombustivel) ";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgvCarros.DataSource = dt;

            conexao.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mostrarCarros();
            carregarComboMarcas();
            carregarComboCombustivel();
        }

        private void carregarComboMarcas()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "select * from marca";
            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dtMarca = new DataTable();
            sda.Fill(dtMarca);

            combomarcas.DataSource = dtMarca;
            combomarcas.DisplayMember = "marca";
            combomarcas.ValueMember = "idMarca";
        }

        private void carregarComboCombustivel()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoDB;
            conexao.Open();

            string sqlcomando = "select * from combustivel";
            SqlCommand sqlCommand = new SqlCommand(sqlcomando, conexao);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dtCombustivel = new DataTable();
            sda.Fill(dtCombustivel);

            combocombustivel.DataSource = dtCombustivel;
            combocombustivel.DisplayMember = "combustivel";
            combocombustivel.ValueMember = "idCombustivel";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }

}