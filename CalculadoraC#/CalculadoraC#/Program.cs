using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("_________________________________");
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine();
            Console.WriteLine("1 - Para Soma");
            Console.WriteLine("2 - Para Subtração");
            Console.WriteLine("3 - Para Multiplicação");
            Console.WriteLine("4 - Para Divisão");
            Console.WriteLine("0 - Para SAIR");
            Console.WriteLine();
            Console.Write("_________________________________");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Escolha um número: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                
                default: Menu(); break;

            }
            Console.ReadKey();

        }
        static void Soma()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("-------------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------"); ;
            

            resultado = valor1 + valor2;

            Console.WriteLine();
            Console.WriteLine($"O resultado é..: {resultado}");
            Console.Write("pressione <Enter> para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("---------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            

            resultado = valor1 - valor2;

            Console.WriteLine();
            Console.WriteLine($"O resultado é..: {resultado}");
            Console.Write("pressione <Enter> para voltar ao Menu");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("---------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            resultado = valor1 * valor2;

            Console.WriteLine($"O resultado é..: {resultado}");
            Console.Write("pressione <Enter> para voltar ao Menu");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            double valor1, valor2, resultado;

            Console.WriteLine("---------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            try
            {
                resultado = valor1 / valor2;
                Console.WriteLine();
                Console.WriteLine($"O resultado é..: {resultado}");
                Console.Write("pressione <Enter> para voltar ao Menu");
            }

            catch(DivideByZeroException dbze)
            {
                Console.WriteLine();
                Console.WriteLine(dbze.Message);
            }

            Console.ReadKey();
            Menu(); 
            
        }


    }
}

