using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FAT = 1, I, N;
            Console.Write("Entre um número: ");
            N = int.Parse(Console.ReadLine());

            I = 1;
            
            do 
            {
                FAT *= I;
                I++;
            } while (I <= N);

            Console.WriteLine();
            Console.WriteLine("O fatorial de {0} = {1}", N, FAT);
            Console.ReadKey();
        }
    }
}
