using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    class Tartaruga : Reptil
    {
        public override void locomover()
        {
            Console.WriteLine("Tartaruga se locomovendo"); ;
        }
        public override void alimentar()
        {
            Console.WriteLine("Tartaruga se Alimentando!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("Tartaruga emitindo som!");
        }
        
        public override string ToString()
        {
            return "\n\tTartaruga\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros();
        }
    }
}
