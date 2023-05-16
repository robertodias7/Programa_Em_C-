using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArranjosOrdemCrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int i, j, x;

            // Entrada de dados

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Entre com um valor para A[{0}]: ", i);
                A[i] = int.Parse(Console.ReadLine());
            }

            //Processamento de dados

            for(i = 0; i <= 3; i++)
                for(j = i+1; j <=4; j++)
                    if (A[i] > A[j])
                    {
                        x = A[i];
                        A[i] = A[j];
                        A[j] = x;   
                    }
                Console.WriteLine();

                //Apresentação de dados

                for (i = 0; i <= 4; i++)
                    Console.WriteLine("A[{0}] = {1,2}", i, A[i]);

                Console.WriteLine();
                Console.Write("Tecle algo para encerrar... ");
                Console.ReadKey();
            
        }
    }
}
