using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fat = 1, i =1, n;
            
            Console.Clear();
            Console.Write("Entre com um número: ");
            n = long.Parse(Console.ReadLine());

            for(; i<=n; i++)
            {
                fat *= i;
            }
            Console.WriteLine($"O fatorial de {n} = {fat}");
            Console.ReadKey();
        }
            
    }
}
