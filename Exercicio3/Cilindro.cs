using System;

namespace Exercicio3
{
    internal class Cilindro
    {

        public double areaBase;
        public double altura;

        public double obterVolume()
        {

            double volume = areaBase * altura;
            return volume;

        }

    }
}
