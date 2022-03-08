using System;

namespace exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MediaHarmonica mediaHarmonica = new MediaHarmonica();
            
            Console.WriteLine("Insira quantas notas irão ser calculadas: ");
            mediaHarmonica.numeroNotas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média harmonica é: " + mediaHarmonica.obterMediaHarmonica());

            Console.ReadKey();
        }
    }
}
