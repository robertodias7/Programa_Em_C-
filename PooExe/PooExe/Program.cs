using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadAluno ALUNO = new CadAluno();

            Console.Write("Entre o nome ..: ");
            ALUNO.NOME = Console.ReadLine();
            Console.Write("Entre a sala ...:");
            ALUNO.SALA = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre as notas:");
            Console.WriteLine();
            for (int i = 0; i<=3; i++)
            {
                Console.Write("{0}a. nota ......: ", i + 1);
                ALUNO.NOTA[i] = float.Parse(Console.ReadLine());
            }
            ALUNO.CalMedia();
            Console.WriteLine();
            Console.WriteLine($"Nome ..........: {ALUNO.NOME}");
            Console.WriteLine();
            Console.WriteLine("Notas:");
            Console.WriteLine();

            for (int i = 0; i <= 3; i++)
            {
                Console.Write($"{i + 1}a. nota ......: ");
                Console.WriteLine("{0,5:0.00}", ALUNO.NOTA[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Média .........: {0,5:0.00}", ALUNO.CalMedia());

            Console.WriteLine();
            Console.WriteLine("Tecle algo para encerrar... ");
            Console.ReadKey();
            
        }
    }
}
