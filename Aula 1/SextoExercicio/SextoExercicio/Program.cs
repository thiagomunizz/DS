using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SextoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            double reais, ctcdolar, dolar;

            Console.Write("Digite o valor em reais a ser convertido em dólar: ");
              reais = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da cotação do dólar: ");
              ctcdolar = double.Parse(Console.ReadLine());

              dolar = reais / ctcdolar;

            Console.WriteLine("Valor da conversão de reais em dólares : US${0:N2}", dolar);
            Console.ReadKey();

        }
    }
}
