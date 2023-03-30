using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float R, A , B;
            int OPCAO;

            Console.Write("Informe o 1o. valor: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Informe o 2o. valor: ");
            B = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("[1]............Adição");
            Console.WriteLine("[2]............Subtração");
            Console.WriteLine("[3]............Multiplicação");
            Console.WriteLine("[4]............Divisão");

            Console.WriteLine();
            Console.WriteLine("Escolha uma opção ---> ");
            OPCAO = int.Parse(Console.ReadLine());

            if (OPCAO == 1) 
            {
                R = A + B;
                Console.WriteLine("Resultado = " + R);
            }
            if (OPCAO == 2) 
            {
                R = A - B;
                Console.WriteLine("Resultado = " + R);
            }

            if (OPCAO == 3)
            {
                R = A * B;
                Console.WriteLine("Resultado = " + R);
            }
            if (OPCAO == 4)
                if (B == 0)
                    Console.WriteLine("ERRO - Divisão por zero!");
                else
                {
                    R = A / B;
                    Console.WriteLine("Resultado = " + R);
                }
            Console.WriteLine();
            Console.WriteLine("Tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
