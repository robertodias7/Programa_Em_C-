using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatoriedade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NR, PEDIDO;
            Random RANDOMICO = new Random();//Random(); Função geradora de números aleatórios
            NR = RANDOMICO.Next(1, 6);// NR vai receber uma número de 1 a 5

            Console.Write("Entre um número entre 1 e 5: ");
            PEDIDO = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (PEDIDO == NR)
                Console.WriteLine("Acertou - Foi sorteado: {0}. ", NR);
            else
                Console.WriteLine("Errou - Foi sorteado {0}. ", NR);

            Console.WriteLine();
            Console.WriteLine("Tecle <Enter> para encerrar... ");
            Console.ReadLine();
        }
    }
}
