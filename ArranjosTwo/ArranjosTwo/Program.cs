using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArranjosTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];

            //Entrada de dados
            for(int i = 0; i<=9; i++)
            {
                Console.Write("Média {0,2}o. aluno: ", i+1);
                A[i] = int.Parse(Console.ReadLine());
            }

            // Processando par ou ímpar

            for(int i = 0; i<=9; i++)
                if (i % 2 == 0)
                    B[i] = A[i] * 5;
                else
                    B[i] = A[i] + 5;
                Console.WriteLine();

            // Apresentação dos arranjos

            for(int i = 0;i<=9; i++)
            {
                Console.Write("A[{0}] = {1,4} / ",i, A[i]);
                Console.Write("B[{0}] = {1,4}",
                    i, B[i]);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Tecle algo para sair...");
            Console.ReadKey();
        }
    }
}
