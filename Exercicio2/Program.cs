using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorTemperatura temperatura = new ConversorTemperatura();

            Console.WriteLine("Insira a temperatura em C°: ");
            temperatura.temperaturaEmC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A temperatura em F é: " + temperatura.obterEmFahrenheit());

            Console.ReadKey();
        }
    }
}
