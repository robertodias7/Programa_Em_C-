﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R, A, B1 = 0, B2 = 0;

            Console.Write("Entre o valor para a variável <A>: ");
            A = int.Parse(Console.ReadLine());
            R = A + B1++;
            Console.WriteLine();
            Console.WriteLine("R = {0}", R);
            R = A + B1++;
            Console.WriteLine();
            Console.WriteLine("R = {0}", R);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Entre o valor para a variável <A>: ");
            A = int.Parse(Console.ReadLine());
            R = A + ++B2;
            Console.WriteLine();
            Console.WriteLine("R = {0}", R);
            R = A + ++B2;
            Console.WriteLine();
            Console.WriteLine("R = {0}", R);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Tecle algo para Sair...");
            Console.ReadKey();

        }
    }
}
