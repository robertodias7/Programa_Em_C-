using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooEncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadAluno ALUNO = new CadAluno();
            float MEDIA;

            Console.WriteLine();
            Console.Write("Entre nome .....: ");
            ALUNO.NOME = Console.ReadLine();
            Console.Write("Entre Sala .: ");
            ALUNO.SALA = Console.ReadLine();
            Console.Write("Entre a nota 1 .: ");
            ALUNO.N1 = float.Parse(Console.ReadLine());
            Console.Write("Entre a nota 2 .: ");
            ALUNO.N2 = float.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Nome ...........: " + ALUNO.NOME);
            Console.WriteLine("Sala ...........: " + ALUNO.SALA);
            MEDIA = ALUNO.CalcMedia(ALUNO.N1, ALUNO.N2);
            Console.Write("Situação .......: ");

            if (CadAluno.CondAluno(ALUNO.CalcMedia(ALUNO.N1, ALUNO.N2), 5.0))
                Console.WriteLine("APROVADO!");
            else
                Console.WriteLine("REPROVADO!");

            Console.WriteLine();
            Console.Write("Telce algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
