using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    public class Ave : Animal
    {
        private string corPena;

        public string getCorPena()
        {
            return corPena;
        }
        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }

        public virtual void fazerNinho()
        {
            Console.WriteLine("Ave fazendo ninho!");
        }

        public override string ToString()
        {
            return "\tAve\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros() + "\nCor da Pena: \t" + corPena;
        }

        public override void locomover()
        {
            Console.WriteLine("Ave se locomovendo");
        }

        public override void alimentar()
        {
            Console.WriteLine("Ave se alimentando");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Ave emitindo som");
        }


    }
}
