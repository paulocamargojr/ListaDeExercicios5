using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConversorTemperatura temperatura = new ConversorTemperatura();

            Console.WriteLine("Insira a temperatura em F: ");
            temperatura.temperaturaF = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A temperatura em C° é: " + temperatura.obterC());

            Console.ReadKey();

        }
    }
}
