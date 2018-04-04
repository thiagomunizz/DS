using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    class Tucano : Ave
    {
        public override void fazerNinho()
        {
            Console.WriteLine("Tucano fazendo ninho!");
        }
        public override void locomover()
        {
            Console.WriteLine("Tucano voando"); ;
        }
        public override void alimentar()
        {
            Console.WriteLine("Tucano se Alimentando!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("Tucano emitindo som!");
        }

        public override string ToString()
        {
            return "\n\tTucano\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros() + "\nCor da Pena: \t" +getCorPena();
        }
    }
}
