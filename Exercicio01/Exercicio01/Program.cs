using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, s1, s2, s3 ,s4, s5, s6, mult1, mult2, mult3, mult4, mult5, mult6;
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());
            Console.WriteLine();

            s1 = A + B;
            s2 = A + C;
            s3 = A + D;
            s4 = B + C;
            s5 = B + D;
            s6 = C + D;

            Console.WriteLine("________________SOMA_______________________");
            Console.WriteLine("A Soma de A + B = {0}", s1);
            Console.WriteLine("A Soma de A + C = {0}", s2);
            Console.WriteLine("A Soma de A + D = {0}", s3);
            Console.WriteLine("A Soma de B + C = {0}", s4);
            Console.WriteLine("A Soma de B + D = {0}", s5);
            Console.WriteLine("A Soma de C + D = {0}", s6);
            Console.WriteLine("___________________________________________");
            Console.WriteLine();

            mult1 = A * B;
            mult2 = A * C;
            mult3 = A * D;
            mult4 = B * C;
            mult5 = B * D;
            mult6 = C * D;

            Console.WriteLine("______________Multiplicação________________");
            Console.WriteLine("A Multiplicação de A * B = {0}", mult1);
            Console.WriteLine("A Multiplicação de A * C = {0}", mult2);
            Console.WriteLine("A Multiplicação de A * D = {0}", mult3);
            Console.WriteLine("A Multiplicação de B * C = {0}", mult4);
            Console.WriteLine("A Multiplicação de B * D = {0}", mult5);
            Console.WriteLine("A Multiplicação de C * D = {0}", mult6);
            Console.WriteLine("___________________________________________");

            Console.ReadLine();
        }
    }
}
