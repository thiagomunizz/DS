using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuartoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            float a, b, c;
            double result;

            Console.Write("Digite um valor para letra a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Digite um valor para letra b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Digite um valor para letra c: ");
            c = float.Parse(Console.ReadLine());

            result = a * a * 5 - c / (b - a % 4);

            Console.Write("O resultado é: " + result);

            Console.ReadKey();


        }
    }
}
