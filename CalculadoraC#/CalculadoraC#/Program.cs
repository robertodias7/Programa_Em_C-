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
            menu();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("_________________________________");
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine();
            Console.WriteLine("1 - Para Soma");
            Console.WriteLine("2 - Para Subtração");
            Console.WriteLine("3 - Para Multiplicação");
            Console.WriteLine("4 - Para Divisão");
            Console.WriteLine("5 - Para SAIR");
            Console.WriteLine();
            Console.Write("_________________________________");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Escolha um número: ");
            
            
            

           // Console.WriteLine();

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                
                case 1: soma(); break;
                case 2: subtracao(); break;
                case 3: multiplicacao(); break;
                case 4: divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: menu(); break;

            }
            Console.ReadKey();

        }
        static void soma()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("-------------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            resultado = valor1 + valor2;

            Console.WriteLine();
            Console.WriteLine($"O resultado é..: {resultado}");
            Console.Write("pressione <Enter> para voltar ao Menu ou [5] para sair ");
            Console.ReadKey();
            menu();
        }

        static void subtracao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("---------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = float.Parse(Console.ReadLine());

            resultado = valor1 - valor2;

            Console.WriteLine();
            Console.WriteLine($"O resultado é..: {resultado}");
            Console.Write("pressione <Enter> para voltar ou [5] para sair");

            Console.ReadKey();
            menu();
        }

        static void multiplicacao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("---------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = float.Parse(Console.ReadLine());


            try
            {
                resultado = valor1 * valor2;
                Console.WriteLine();
                Console.WriteLine($"O resultado é..: {resultado}");
            }

            catch (DivideByZeroException dbze)
            {
                Console.WriteLine();
                Console.WriteLine(dbze.Message);
            }
            Console.Write("pressione <Enter> para voltar ou [5] para sair ");

            Console.ReadKey();
            menu();
        }

        static void divisao()
        {
            Console.Clear();

            float valor1, valor2, resultado;

            Console.WriteLine("---------------------");
            Console.Write("Primeiro valor...: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor....: ");
            valor2 = float.Parse(Console.ReadLine());

            try
            {
                resultado = valor1 / valor2;
                Console.WriteLine();
                 Console.WriteLine($"O resultado é..: {resultado}");
            }

            catch(DivideByZeroException dbze)
            {
                Console.WriteLine();
                Console.WriteLine(dbze.Message);
            }

            Console.Write("pressione <Enter> para voltar ou [5] para sair ");

            Console.ReadKey();
            
        }


    }
}

