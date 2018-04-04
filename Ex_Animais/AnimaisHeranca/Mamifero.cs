using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    public class Mamifero : Animal
    {
        private string corpelo;
        private string raca;

        public string getCorPelo()
        {
            return corpelo;
        }
        public void setCorPelo(string corpelo)
        {
            this.corpelo = corpelo;
        }

        public string getRaca()
        {
            return raca;
        }
        public void setRaca(string raca)
        {
            this.raca = raca;
        }

        public override string ToString()
        {
            return "\tMamífero\nPeso: \t\t" + getPeso() + "\nIdade: \t\t" + getIdade() + "\nMembros: \t" + getMembros() + "\nCor do Pelo: \t" + corpelo + "\nRaça: \t\t" + raca;
        }

        public override void locomover()
        {
            Console.WriteLine("Mamifero se locomovendo");
        }

        public override void alimentar()
        {
            Console.WriteLine("Mamifero se alimentando");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Mamifero emitindo som");
        }


    }
}
