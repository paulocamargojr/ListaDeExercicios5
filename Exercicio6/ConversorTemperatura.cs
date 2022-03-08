using System;

namespace Exercicio6
{
    internal class ConversorTemperatura
    {

        public double temperaturaF;

        public double obterC()
        {

            double c = (temperaturaF - 32) * 5/9;
            return c;

        }

    }
}
