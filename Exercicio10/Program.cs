using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada media = new MediaPonderada();

            Console.WriteLine("Insira o resultado do aluno na prova 1: ");
            media.resultadoProva1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o peso da prova 1: ");
            media.pesoProva1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o resultado do aluno na prova 2: ");
            media.resultadoProva2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o peso da prova 2: ");
            media.pesoProva2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A média final é: " + media.obterMediaPonderada());

            Console.ReadKey();

        }
    }
}
