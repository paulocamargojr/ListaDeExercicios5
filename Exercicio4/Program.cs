using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoCombustivel consumo = new ConsumoCombustivel();

            Console.WriteLine("Insira a quilometragem inicial do veículo: ");
            consumo.kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quilometragem final do veículo: ");
            consumo.kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o consumo final do veículo: ");
            consumo.consumoFinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O consumo por Km é igual a: " + consumo.obterConsumo());

            Console.ReadKey();
        }
    }
}
