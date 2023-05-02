using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Aluno
    {
        private double nota1, nota2;

        private double media()
        {
            return (nota1 + nota2) /2;
        }

        public void mensagem()
        {
            Console.Write("Digite a Nota 1: ");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a Nota 2: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Sua média é: " + media());
        }
    }
}
