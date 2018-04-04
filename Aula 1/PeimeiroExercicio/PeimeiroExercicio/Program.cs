using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int idd;
            Console.Write("Digite seu nome: ");
            name = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idd = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} tem {1} anos de idade.", name, idd);

            Console.ReadKey(); 
        }
    }
}
