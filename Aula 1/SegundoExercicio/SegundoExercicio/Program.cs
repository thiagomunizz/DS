using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegundoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, result;
            Console.Write("Digite um número e mostraremos o seu dobro:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(num*2);

            Console.ReadKey();
        }
    }
}
