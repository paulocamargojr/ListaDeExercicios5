using System;

namespace Exercicio7
{
    internal class Salario
    {

        public double salarioBase;
        public double totalVendas;
        public double percentualComissao;


        

        public double obterSalario()
        {

            double salario = salarioBase + (totalVendas * (percentualComissao/100));
            return salario;

        }

    }
}
