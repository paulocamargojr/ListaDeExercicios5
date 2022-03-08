using System;

namespace Exercicio5
{
    internal class Esfera
    {

        public double diametro;


        public double obterRaio()
        {

            double raio = diametro / 2;
            return raio;

        }

        public double obterVolume()
        {

            double volume = (4 * (Math.PI * Math.Pow(obterRaio(), 3)))/3;
            return volume;

        }

    }
}
