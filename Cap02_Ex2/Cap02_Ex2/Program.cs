using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aplicação com Valor Inteiro

            int a, b, r;
            Console.Write("Entre o 1o. Valor: ");
            a = int.Parse(Console.ReadLine());
            //Converte o número para inteiro. Entrada de dado capturado pelo ReadLine()

            Console.Write("Entre o 2o. Valor: ");
            b = int.Parse(Console.ReadLine());

            r = a + b;

            Console.WriteLine();
            Console.WriteLine("Resultado = " + r);

            Console.WriteLine();
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
