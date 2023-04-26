using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Gerente
    {
        public String nome;
        public double salario;
        public void AumentaSalaraio()
        {
            this.AumentaSalario(0.1);
        }
        public void AumentaSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.salario = 1000;
            Console.WriteLine("Salário: " + g.salario);
            Console.WriteLine();

            g.AumentaSalaraio();
            Console.WriteLine("Salario: " + g.salario);
            Console.WriteLine("Aumentando o  salário em 30% ");
            g.AumentaSalario(0.3);
            Console.WriteLine("Salário: " + g.salario);
        }
    }
}
