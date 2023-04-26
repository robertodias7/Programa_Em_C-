using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividendoDivisor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DIVIDENDO, DIVISOR, QUOCIENTE;

            Console.Write("Entre o valor do dividendo...: ");
            DIVIDENDO = int.Parse(Console.ReadLine());
            Console.Write("Entre com o valor divisor....: ");
            DIVISOR = int.Parse(Console.ReadLine());

            try
            {
                QUOCIENTE = DIVIDENDO / DIVISOR;

                Console.WriteLine();
                Console.WriteLine("Resultado = {0}", QUOCIENTE);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine();
                Console.WriteLine(dbze.Message);
                //Mostra a mensagem de erro
            }
            Console.WriteLine();
            Console.WriteLine("Tecle <Enter> para encerrar...");
            Console.ReadLine();
        }
    }
}
