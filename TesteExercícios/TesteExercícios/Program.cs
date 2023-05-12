using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 1, resultado;

            resultado = valor++;

            Console.WriteLine(resultado);
            Console.WriteLine(valor);
            Console.ReadKey();
        }
            
    }
}
