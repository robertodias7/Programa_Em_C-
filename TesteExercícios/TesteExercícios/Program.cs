using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercícios
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arranjo";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            float[] MDG = new float[8];
            float soma = 0, media;

            for(int i = 0; i <=7; i++)
            {
                Console.Write($"Média {i +1}o aluno: ");
                MDG[i] = float.Parse( Console.ReadLine() );
                soma += MDG[i];
            }

            media = soma / 8;
            Console.WriteLine();
            Console.Write("A média geral é de: {0:0.00}", media);
            Console.WriteLine();
            Console.WriteLine("pressione algo para sair...");
            Console.ReadKey();
        }
    }
}
