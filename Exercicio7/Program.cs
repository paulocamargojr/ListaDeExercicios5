using System;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.WriteLine("Insira o salário base: ");
            salario.salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o total de vendas: ");
            salario.totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o percentual para comissão: ");
            salario.percentualComissao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O salário final do funcionário será de: " + salario.obterSalario());

            Console.ReadKey();
        }
    }
}
