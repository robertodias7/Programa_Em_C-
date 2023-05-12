using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, r, n;
            string resp = "S";


            while (resp.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA - TABUADA");
                Console.WriteLine();
                Console.Write("Entre com um valor: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();


                for (i = 1; i <= 10; i++)
                {
                    r = n * i;
                    Console.WriteLine($"{n,2} x {i,2} = {r,3}");
                }
                Console.WriteLine();
                Console.WriteLine("Deseja continuar?");
                Console.Write("[S] para SIM ou [N] para NÂO: ");
                resp = Console.ReadLine();

            }
        }
    }
}
