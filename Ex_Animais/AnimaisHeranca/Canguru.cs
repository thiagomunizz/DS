using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    class Canguru : Mamifero
    {
        public override void locomover()
        {
            Console.WriteLine("Canguru pulando"); ;
        }
        public override void alimentar()
        {
            Console.WriteLine("Canguru se Alimentando!");
        }
        public override void emitirSom()
        {
            Console.WriteLine("Canguru emitindo som!");
        }

        public void usarBolsa()
        {
            Console.WriteLine("Canguru usando a bolsa!");
        }

        public override string ToString()
        {
            return "\n\tCanguru\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros()+"\nCor do pelo: \t"+getCorPelo();
        }

    }
}
