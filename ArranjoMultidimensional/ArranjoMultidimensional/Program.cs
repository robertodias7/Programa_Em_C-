using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArranjoMultidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3];
            int i, j, lin = 7, col = 0;

            Console.SetCursorPosition(0, 0);
            Console.Write("Entre com um valor na coordenada: ");
            Console.SetCursorPosition(0, 2);
            Console.Write("Linha ...: ");
            Console.SetCursorPosition(0, 3);
            Console.Write("Coluna ..: ");

            for(i = 0; i <= 2; i++)
            {
                for(j = 0; j <= 2; j++)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.Write("{0}", i + 1);
                    Console.SetCursorPosition(11, 3);
                    Console.Write("{0}", j + 1);
                    Console.SetCursorPosition(0, 5);
                    Console.Write("--> ");
                    A[i, j] = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(4, 5);
                    Console.Write("    ");
                    Console.SetCursorPosition(col, lin);
                    Console.Write("{0,4}", A[i, j]);
                    col += 6;
                }
                lin += 2;
                col -= 18;
            }

            Console.SetCursorPosition(0, 13);
            Console.Write("Saída - Diagonal Principal");
            Console.SetCursorPosition(0, 15);

            for(i = 0; i<= 2;i++)
            {
                for(j = 0; j <=2; j++)
                {
                    if(i == j)
                    {
                        Console.Write("A[{0},{1}]", i + 1, j + 1);
                        Console.WriteLine(" = {0,4}", A[i,j]);
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
