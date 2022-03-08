using System;

namespace ListaExercicios5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixaRetangular = new CaixaRetangular();

            Console.WriteLine("Insira a altura da caixa: ");
            caixaRetangular.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o comprimento da caixa: ");
            caixaRetangular.comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a largura da caixa: ");
            caixaRetangular.largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O volume da caixa é de: " + caixaRetangular.obterVolume());

            Console.ReadKey();
        }
    }
}
