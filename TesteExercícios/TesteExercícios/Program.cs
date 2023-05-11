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
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");

            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Multiplicação");
            Console.WriteLine("[4] - Divisão");
            Console.WriteLine("[0] - Sair");
            Console.Write("Digite a opção desejada: ");

            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Menu(); break;
            }

            Console.ReadKey();
        }

        public static void Soma()
        {
            double valor1, valor2, resultado;

            Console.Clear();
            Console.Write("Entre com o primeiro número....: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número.....: ");
            valor2 = double.Parse(Console.ReadLine());

            resultado = valor1 + valor2;
            Console.WriteLine();
            Console.WriteLine($"O Resultado da Soma é.....: {resultado}");
            Console.Write("Pressione <Enter> para voltar ao Menu:");
            Console.ReadKey();

           
            Menu();

           
        }
        public static void Subtracao()
        {
            double valor1, valor2, resultado;

            Console.Clear();
            Console.Write("Entre com o primeiro número....: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número.....: ");
            valor2 = double.Parse(Console.ReadLine());

            resultado = valor1 - valor2;
            Console.WriteLine();
            Console.WriteLine($"O Resultado da Subtração é.....: {resultado}");
            Console.Write("Pressione <Enter> para voltar ao Menu:");
            Console.ReadKey();


            Menu();
        }
        public static void Multiplicacao() 
        {
            double valor1, valor2, resultado;

            Console.Clear();
            Console.Write("Entre com o primeiro número....: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número.....: ");
            valor2 = double.Parse(Console.ReadLine());

            resultado = valor1 * valor2;
            Console.WriteLine();
            Console.WriteLine($"O Resultado da Multiplicação é.....: {resultado}");
            Console.Write("Pressione <Enter> para voltar ao Menu:");
            Console.ReadKey();


            Menu();
        }
        public static void Divisao()
        {
            double valor1, valor2, resultado;

            Console.Clear();
            Console.Write("Entre com o primeiro número....: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número.....: ");
            valor2 = double.Parse(Console.ReadLine());


            try
            {
                resultado = valor1 / valor2;
                Console.WriteLine();
                Console.WriteLine($"O Resultado da Divisão é.....: {resultado}");
                Console.Write("Pressione <Enter> para voltar ao Menu:");

            }

            catch (DivideByZeroException Dbze) 
            {
                Console.WriteLine();
                Console.WriteLine(Dbze.Message);
            }
            
            
            Console.ReadKey();


            Menu();
        }
        
    }
}
