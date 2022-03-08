using System;

namespace ListaExercicios5.ConsoleApp
{
    internal class CaixaRetangular
    {

        public double altura;
        public double largura;
        public double comprimento;

        public double obterVolume()
        {

            double volume = altura * largura * comprimento;
            return volume;

        }

    }
}
