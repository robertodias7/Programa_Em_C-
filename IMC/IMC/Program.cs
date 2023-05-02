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
           Pessoa p = new Pessoa();
            p.peso = 80;
            p.altura = 1.80;
            p.mensagem();

            Console.ReadLine();
        }
    }
}
