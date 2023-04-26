using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FartorialFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FAT = 1, N, I;
            Console.Write("Entre com um número: ");
            N = int.Parse(Console.ReadLine());

            for ( I = 1; I <= N; I++)
                FAT *= I;

            Console.WriteLine();
            Console.WriteLine("O Fatorial de {0} = {1} ", N, FAT);
            Console.ReadKey();
        }
    }
}
