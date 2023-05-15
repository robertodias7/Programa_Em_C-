using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arranjos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] MDG = new float[8];
            float SOMA = 0, MEDIA;
            int i;

            for(i = 0; i <= 7;i++)
            {
                Console.Write($"Média {i+1}o. aluno: ");
                MDG[i] = float.Parse(Console.ReadLine());
                SOMA+= MDG[i];
            }

            MEDIA = SOMA / 8;

            Console.WriteLine();
            Console.WriteLine("Media Geral = {0:0.00}", MEDIA);

            Console.WriteLine();
            Console.Write("Tecle algo para sair ");
            Console.ReadKey();
        }
    }
}
