using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long FAT = 1, N, I;

            Console.Write("Entre com um número: ");
            N = long.Parse(Console.ReadLine());

            I = 1;
            while (I <= N)
            {
                FAT *= I;
                I++;
            }
            Console.WriteLine();
            Console.WriteLine("Fatorial de {0} = {1}.", N, FAT);

            Console.WriteLine();
            Console.WriteLine("Tecle algo para encerrar ...");
            Console.ReadKey();
        }
    }
}
