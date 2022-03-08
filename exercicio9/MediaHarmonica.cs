using System;

namespace exercicio9
{
    internal class MediaHarmonica
    {

        public int numeroNotas;

        public double[] copularNotas()
        {

            double[] notas = new double[numeroNotas];

            for (int i = 0; i < numeroNotas; i++)
            {

                Console.WriteLine("Insira a nota na posição " + Convert.ToInt32(i + 1));
                notas[i] = Convert.ToDouble(Console.ReadLine());

            }

            return notas;

        }
        
        public double obterMediaHarmonica()
        {

            double[] notas = copularNotas();
            double mediaHarmonica = 0;

            for (int i = 0;i < numeroNotas; i++)
            {

                mediaHarmonica += (1/notas[i]);

            }
            
            double mediaHarmonicaFinal = Math.Round(notas.Length/mediaHarmonica, 2);

            return mediaHarmonicaFinal;

        }

    }
}
