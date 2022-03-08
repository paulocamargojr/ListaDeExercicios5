using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            Console.WriteLine("Insira a area da base do cilindro: ");
            cilindro.areaBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a altura do cilindro: ");
            cilindro.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O volume do cilindro é: " + cilindro.obterVolume());
            Console.ReadKey();
        }
    }
}
