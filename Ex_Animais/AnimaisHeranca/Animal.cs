using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    public class Animal
    {
        private float peso;
        private int idade;
        private int membros;

        public float getPeso()
        {
            return peso;
        }

        public void setPeso(float peso)
        {
            this.peso = peso;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getMembros()
        {
            return membros;
        }

        public void setMembros(int membros)
        {
            this.membros = membros;
        }

        public override string ToString()
        {
            return "\tAnimal\nPeso: \t\t" + peso + "\nIdade: \t\t" + idade + "\nMembros: \t" + membros;
        }
        
        public virtual void locomover()
        {
            Console.WriteLine("Animal se locomovendo");
        }

        public virtual void alimentar()
        {
            Console.WriteLine("Animal se alimentando");
        }

        public virtual void emitirSom()
        {
            Console.WriteLine("Animal emitindo som");
        }
    }
}
