using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuintoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            int idd;

            Console.Write("Digite a idade: ");
            idd = int.Parse(Console.ReadLine());

            if (idd < 18)
            {
                Console.WriteLine("Menor de idade.");
            }
            else
            {

                Console.WriteLine("Maior de idade.");
            }

            Console.ReadKey();

            



        }
    }
}
