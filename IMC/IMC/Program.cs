using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.peso = 80;
            pessoa.altura = 1.80;
            pessoa.mensangem();

            Console.ReadKey();
        }
    }
}
