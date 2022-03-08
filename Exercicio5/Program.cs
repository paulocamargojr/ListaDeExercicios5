using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            Console.WriteLine("Insira o diametro da esfera: "); 
            esfera.diametro = Convert.ToDouble(Console.ReadLine());

            esfera.obterRaio();
            Console.WriteLine("O volume da esfera é de: " + esfera.obterVolume());

            Console.ReadKey();
        }
    }
}
