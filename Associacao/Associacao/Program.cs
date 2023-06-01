using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa cliente = new Pessoa();
            cliente.Nome = "Roberto";

            Endereco casa = new Endereco();
            casa.Logradouro = "Q 41 lt 11 JdA";
            casa.Numero = 1;
            casa.Cidade = "SAD";

            cliente.Residencia = casa;
            Console.WriteLine(cliente.Residencia);
            Console.ReadKey();
        }
    }
}
