using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoInterativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, I, R;
            string RESP;

            RESP = "S";
            while (RESP.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA - TABUADA");
                Console.WriteLine();
                Console.Write("Informe uma valor: ");
                N = int.Parse(Console.ReadLine());
                for (I = 1; I <= 10; I++)
                {
                    R = N * I;
                    Console.WriteLine("{0,2} X {1,2} = {2,3}", N, I, R);
                }
                Console.WriteLine();
                Console.WriteLine("Deseja continuar ?");
                Console.Write("[S] para SIM ou [N] para NÃO: ");
                RESP = Console.ReadLine();
                Console.WriteLine();

            }
        }
    }
}
