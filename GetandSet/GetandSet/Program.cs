using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetandSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Roberto Dias";

            Console.WriteLine(pessoa.Nome);

            Console.ReadLine();
        }
    }
}
