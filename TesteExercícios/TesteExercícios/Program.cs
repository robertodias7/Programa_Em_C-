using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercícios
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Média do aluno{0}", A[i]);

                if (A[i] % 2 == 0)
                {
                    B[i] = A[i];
                    B[i] *= B[i];
                }
                else
                {
                    B[i] = A[i];
                    B[i] += B[i];
                }
            }        
        }
    }
}
