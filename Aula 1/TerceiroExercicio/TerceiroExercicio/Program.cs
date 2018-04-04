using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TerceiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double result;
            Console.WriteLine("Digite um número e mostraremos o seu quadrado:"); 
            num = double.Parse(Console.ReadLine());
            result = Math.Pow(num, 2);
            Console.WriteLine("O quadrado deste número é: {0}", result);
            Console.ReadKey ();


        }
    }
}
