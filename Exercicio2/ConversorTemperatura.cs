using System;

namespace Exercicio2
{
    internal class ConversorTemperatura
    {

        public double temperaturaEmC;

        public double obterEmFahrenheit()
        {

            double Fahrenheit = (temperaturaEmC * 9 / 5) + 32;
            return Fahrenheit;

        }

    }
}
