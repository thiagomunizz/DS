using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    public class Reptil : Animal
    {
        private string corEscama;

        public string getCorEscama()
        {
            return corEscama;
        }
        public void setCorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }
        public override string ToString()
        {
            return "\tRéptil\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros() + "\nCor da Escama: \t" + corEscama;
        }

        public override void locomover()
        {
            Console.WriteLine("Réptil se locomovendo");
        }

        public override void alimentar()
        {
            Console.WriteLine("Réptil se alimentando");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Réptil emitindo som");
        }


    }
}
