using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialParamentro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte X;

            Console.Title = "Programa Fatorial1";
            Console.Write("Entre um valor numérico: ");
            X = byte.Parse(Console.ReadLine());
            Console.WriteLine();

            Fatorial(X);

            Console.WriteLine();
            Console.WriteLine("Tecle algo para sair");
            Console.ReadKey();

        }

        public static void Fatorial(byte N)
        {
            long FAT = 1;
            if (N == 0)
                FAT = 0;
            else
                for (int i = 1; i <= N; i++)
                    FAT *= i;
            Console.WriteLine("Fatorial de {0} = {1}", N, FAT);
        }
    }
}
