using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Olá, qual é o  seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("E qual é a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} Você tem {1} anos de idade", nome, idade);
            Console.ReadKey();
        }
    }
}
