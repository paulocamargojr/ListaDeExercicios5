using System;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataDeOleo lata = new LataDeOleo();

            Console.WriteLine("Insira a area da base da lata: ");
            lata.areaBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a altura da  lata: ");
            lata.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O volume da lata é: " + lata.obterVolumeLata());
            Console.ReadKey();
        }
    }
}
