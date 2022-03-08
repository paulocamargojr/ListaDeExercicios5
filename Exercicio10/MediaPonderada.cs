using System;

namespace Exercicio10
{
    internal class MediaPonderada
    {

        public double resultadoProva1;
        public double pesoProva1;
        public double resultadoProva2;
        public double pesoProva2;

        public double obterMediaPonderada()
        {

            double mediaPonderada = (resultadoProva1*pesoProva1 + resultadoProva2*pesoProva2)
                                                /(pesoProva1+pesoProva2);
            return mediaPonderada;

        }

    }
}
