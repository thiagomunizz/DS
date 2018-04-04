using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimaisHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal      a1 = new Animal();
            Mamifero    a2 = new Mamifero();
            Reptil      a3 = new Reptil();
            Ave         a4 = new Ave();
            Canguru     a5 = new Canguru();
            Cachorro    cachorro = new Cachorro();
            Tartaruga   a7 = new Tartaruga();
            Tucano      a8 = new Tucano();

            a1.setIdade(10);
            a1.setMembros(2);
            a1.setPeso(50);

            a2.setIdade(30);
            a2.setMembros(4);
            a2.setPeso(60);
            a2.setCorPelo("Amarelo");
            a2.setRaca("Felino");

            a3.setIdade(5);
            a3.setMembros(0);
            a3.setPeso(15);
            a3.setCorEscama("Azul");

            a4.setIdade(7);
            a4.setMembros(2);
            a4.setPeso(15);
            a4.setCorPena("Cinza");

            a5.setIdade(3);
            a5.setMembros(4);
            a5.setPeso(80);
            a5.setCorPelo("Vermelho");
            a5.ToString();

            cachorro.setIdade(5);
            cachorro.setMembros(4);
            cachorro.setPeso(23);
            cachorro.setCorPelo("Branco");
            cachorro.setRaca("Husky");
            

            a7.setIdade(8);
            a7.setMembros(4);
            a7.setPeso(9);
      
            a8.setIdade(3);
            a8.setMembros(2);
            a8.setPeso(0.7f);
            a8.setCorPena("Azul");
            
            Console.WriteLine(a1.ToString());
            Console.WriteLine();
            a1.locomover();
            a1.alimentar();
            a1.emitirSom();

            Console.WriteLine("\n" + a2.ToString());
            Console.WriteLine();
            a2.locomover();
            a2.alimentar();
            a2.emitirSom();
            
            Console.WriteLine("\n" + a3.ToString());
            Console.WriteLine();
            a3.locomover();
            a3.alimentar();
            a3.emitirSom();
            
            Console.WriteLine("\n" + a4.ToString());
            Console.WriteLine();
            a4.locomover();
            a4.alimentar();
            a4.emitirSom();
            a4.fazerNinho();

            Console.WriteLine("\n" + a5.ToString());
            Console.WriteLine();
            a5.locomover();
            a5.alimentar();
            a5.emitirSom();
            a5.usarBolsa();

            Console.WriteLine("\n" + cachorro.ToString());
            Console.WriteLine();
            cachorro.locomover();
            cachorro.alimentar();
            cachorro.emitirSom();
            cachorro.enterrarOsso();
            cachorro.abanarRabo();
            cachorro.reagir("acariciar");
            cachorro.reagir(11);
            cachorro.reagir(true);

            Console.WriteLine("\n" + a7.ToString());
            Console.WriteLine();
            a7.locomover();
            a7.alimentar();
            a7.emitirSom();

            Console.WriteLine("\n" + a8.ToString());
            Console.WriteLine();
            a8.locomover();
            a8.alimentar();
            a8.emitirSom();
            a8.fazerNinho();

            Console.ReadKey();
        }
    }
}
