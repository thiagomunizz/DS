using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
        }


        private double ProcessarCommando(string command)
        {
            //Cria um provedor de Código C#
            CSharpCodeProvider mCodeProvider = new CSharpCodeProvider();
            // Cria os parmaetros para a compilação origem
            CompilerParameters cp = new CompilerParameters();
            cp.GenerateExecutable = false;         //Não precisa criar um arquivo EXE
            cp.GenerateInMemory = true;            //Cria um na memória
            cp.OutputAssembly = "TempModule"; // Isso não é necessário, no entanto, se usado repetidamente, faz com que o CLR 
            //não precisa carregar uma novo assembly cada vez que a função é executada.
            // A string abaixo é basicamente a casca do programa C #, que não faz nada, mas contém um método Avaliar() para nossos propósitos. 
            //Atenção: Isso deixa a aplicação app aberto a ataques de injeção,
            //Estou fazendo apenas para demonstração .
            string TempModuleSource = "namespace ns{" +
                                      "using System;" +
                                      "class class1{" +
                                      "public static double Evaluate(){return " + command + ";}}} ";  //Calcula a expressão

            CompilerResults cr = mCodeProvider.CompileAssemblyFromSource(cp, TempModuleSource);
            if (cr.Errors.Count > 0)
            {
                //Se um erro de compilação é gerado, iremoslançar uma exceção
                //A sintaxe estava errado - novamente, isso é deixado ao implementador para verificar sintaxe antes
                //Chamando a função. O código de chamada pode prender isso em um laço try, e notificar o usuário
                //O comando não foi compreendido, por exemplo.
                throw new ArgumentException("A expressão não pode ser avaliada, utiliza uma expressão C# válida...");
            }
            else
            {
                MethodInfo Methinfo = cr.CompiledAssembly.GetType("ns.class1").GetMethod("Evaluate");
                return (double)Methinfo.Invoke(null, null);
            }
        }


        double valor1 = 0;
        String operacao = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


//numeros
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }


//operaçoes
        private void btnIgual_Click(object sender, EventArgs e)
        {
            
        
            try
            {
                textBox1.Text = ProcessarCommando(textBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a avaliar a expressão..." + ex.Message.ToString() + " Obrigado...");
            }
            //Exemplos
            //ProcessCommand("Math.PI").ToString());                       //Exibe 3.14159265358979
            //ProcessCommand("Math.Abs(-22)").ToString());             //Exibe 22
            //ProcessCommand("3-4+6+7+22/3+66*(55)").ToString()); //Exibe 3649
        
    }





            /*if (operacao == "+" || operacao == "-" || operacao == "/" || operacao == "*")
            {
                if (operacao == "+")
                {
                    valor1 += double.Parse(textBox1.Text);
                    textBox1.Text = valor1.ToString();
                }
                else if (operacao == "-")
                {
                    valor1 -= double.Parse(textBox1.Text);
                    textBox1.Text = valor1.ToString();
                }
                else if (operacao == "/")
                {
                    valor1 /= double.Parse(textBox1.Text);
                    textBox1.Text = valor1.ToString();
                }
                else if (operacao == "*")
                    valor1 *= double.Parse(textBox1.Text);
                    textBox1.Text = valor1.ToString();
            }*/
            
        

//botoes das operaçoes
        private void btnSoma_Click(object sender, EventArgs e)
        {
            //valor1=System.Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "+";
            //operacao = "+";

        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            //valor1 = System.Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "-";
            //operacao = "-";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //valor1 = System.Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "/";
            //operacao = "/";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            //valor1 = System.Convert.ToDouble(textBox1.Text);
            textBox1.Text = textBox1.Text + "*";
            //operacao = "*";
        }

        private void apaga_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

       


    }
}

