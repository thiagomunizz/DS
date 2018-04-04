using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            Console.WriteLine("Exemplo - Operadores Relacionais");
            Console.WriteLine("********************************* \n\n");

            Console.Write("Digite um número: ");        a = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");     b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} é igual a {1}?           Resposta: {2}", a, b, (a == b));
            Console.WriteLine("{0} é diferente de {1}?      Resposta: {2}", a, b, (a != b));
            Console.WriteLine("{0} é maior que {1}?         Resposta: {2}", a, b, (a > b));
            Console.WriteLine("{0} é menor que {1}?         Resposta: {2}", a, b, (a < b));
            Console.WriteLine("{0} é maior ou igual a {1}?  Resposta: {2}", a, b, (a >= b));
            Console.WriteLine("{0} é menor ou igual a {1}?  Resposta: {2}", a, b, (a <= b));

            Console.ReadKey();
        } 
    }
}
