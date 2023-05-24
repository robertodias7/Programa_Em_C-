using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercícios
{

    internal class Program
    {

        

        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Title = "Calculadora";
            Console.Clear();
            Console.WriteLine("-------CALCULADORA-------");
            Console.WriteLine();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Multiplicação");
            Console.WriteLine("[4] - Divisão");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine();
            Console.Write("Sua Opção ...: ");
            

            short res = short.Parse(Console.ReadLine());

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
            double resultado, num1, num2;

            Console.Clear();
            Console.WriteLine("SOMA");
            Console.WriteLine();
            Console.Write("Entre com o primeiro número .: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número ..: ");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine();
            Console.WriteLine($"O Resultado da operação é: {resultado}");
            Console.ReadKey();
            Menu();

        }

        public static void Subtracao()
        {
            double resultado, num1, num2;

            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine();
            Console.Write("Entre com o primeiro número .: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número ..: ");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 - num2;

            Console.WriteLine();
            Console.WriteLine($"O Resultado da operação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        public static void Multiplicacao()
        {
            double resultado, num1, num2;

            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine();
            Console.Write("Entre com o primeiro número .: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número ..: ");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine();
            Console.WriteLine($"O Resultado da operação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        public static void Divisao()
        {
            double resultado, num1, num2;

            Console.Clear();
            Console.WriteLine("DIVISÃO");
            Console.WriteLine();
            Console.Write("Entre com o primeiro número .: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo número ..: ");
            num2 = double.Parse(Console.ReadLine());

           
            resultado = num1  / num2;
            if(num2 == 0)
            {
                Console.WriteLine("ERRO! Divisão por Zero");
                Console.ReadKey ();
                Menu();
            }
            else
            Console.WriteLine();
            Console.WriteLine($"O Resultado da operação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
   
}
