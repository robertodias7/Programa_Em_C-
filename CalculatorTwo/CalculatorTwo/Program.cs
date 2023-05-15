using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TesteExercícios
{

    internal class Program
    {
        public static float R, A, B;
        public static string MSG = "Tecle algo para continuar...";
        static void Main(string[] args)
        {
            string OPCAO = "0";

            while (OPCAO != "5")
            {
                Console.Title = "Calculadora";
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("--------------");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");
                OPCAO = Console.ReadLine();

                if (OPCAO != "5")
                {
                    switch (OPCAO)
                    {
                        case "1": RotSoma(); break;
                        case "2": RotSubtracao(); break;
                        case "3": RotMultiplicacao(); break;
                        case "4": RotDivisao(); break;
                        default:
                            Console.WriteLine("Opção inválida");
                            Console.Write(MSG);
                            Console.ReadKey(); break;

                    }
                }
            }
        }
        public static float Calculo(float X, float Y, string OPERADOR)
        {
            float Z = 0;
            switch (OPERADOR)
            {
                case "+": Z = X + Y; break;
                case "-": Z = X - Y; break;
                case "*": Z = X * Y; break;
                case "/": Z = X / Y; break;

            }
            return Z;
        }


        private static void Entrada()
        {
            Console.Write("Entre com um valor A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Entre com um valor B: ");
            B = float.Parse(Console.ReadLine());
        }

        private static void Saida()
        {
            Console.WriteLine();
            Console.Write("O resultado entre A e B = {0:0.00}", R);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(MSG);
            Console.ReadKey();
        }

        private static void RotSoma()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Rotina Soma");
            Console.WriteLine("-----------");
            Console.WriteLine();
            Entrada();
            R = Calculo(A, B, "+");
            Saida();
        }

        private static void RotSubtracao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Rotina Subtração");
            Console.WriteLine("-----------");
            Console.WriteLine();
            Entrada();
            R = Calculo(A, B, "-");
            Saida();
        }

        private static void RotMultiplicacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rotina Multiplicação");
            Console.WriteLine("-----------");
            Console.WriteLine();
            Entrada();
            R = Calculo(A, B, "*");
            Saida();
        }

        public static void RotDivisao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Rotina Divisão");
            Console.WriteLine("-----------");
            Console.WriteLine();
            Entrada();

            if (B == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Erro!");
                Console.WriteLine();
                Console.WriteLine(MSG);
                Console.ReadKey();
            }
            else
            {
                R = Calculo(A, B, "/");
                Saida();
            }
        }

    }
}