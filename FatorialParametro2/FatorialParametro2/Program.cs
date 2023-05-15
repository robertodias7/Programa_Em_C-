using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialParametro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte X;
            long R;

            Console.Title = "Programa Fatorial";
            Console.Write("Entre com uma valor númerico: ");
            X = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            R = Fatorial(X);

            Console.WriteLine("Fatorial de {0} = {1}", X, R);
            Console.WriteLine();
            Console.Write("Tecle algo para sair...");
            Console.ReadKey();
        }

        public static long Fatorial(byte N)
        {
            long FAT = 1;
            if (N == 0)
                FAT = 0;
            else
                for (int i = 1; i <= N; i++)
                    FAT *= i;
            return FAT;
        }
    }
}
