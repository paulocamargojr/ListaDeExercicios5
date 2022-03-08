using System;
namespace Exercicio4
{
    internal class ConsumoCombustivel
    {

        public double kmInicial;
        public double kmFinal;
        public double consumoFinal;

        public double obterConsumo()
        {

            double consumo = consumoFinal/(kmFinal - kmInicial);
            return consumo;

        }

    }
}
