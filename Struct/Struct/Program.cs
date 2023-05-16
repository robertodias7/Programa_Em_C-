using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        public struct CAD_ALUNO
        {
            public string NOME;
            public int SALA;
            public float MEDIA;
        }
        static void Main(string[] args)
        {
            CAD_ALUNO[] ALUNO = new CAD_ALUNO[8];
            CAD_ALUNO X;
            int I, J, LIN;

            //Rotina para a entrada dos nomes, sala e media

            for(I = 0; I <= 7; I++)
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine();
                Console.Write("Entre o {0}o. nome ...: ", I + 1);
                ALUNO[I].NOME = Console.ReadLine();
                Console.Write("Entre a sala .......: ");
                ALUNO[I].SALA = int.Parse(Console.ReadLine());
                Console.Write("Entre a média ......: ");
                ALUNO[I].MEDIA = float.Parse(Console.ReadLine());
                Console.WriteLine();

            }

            //Classificação dos dados
            for(I = 0; I <=6; I++)
                for(J = I+1; J <= 7; J++)
                    if (ALUNO[I].NOME.CompareTo(ALUNO[J].NOME) > 0)
                    {
                        X = ALUNO[I];
                        ALUNO[I] = ALUNO[J];
                        ALUNO[J] = X;
                    }
            //Apresentação da tabela nome/sala/media

            Console.Clear();
            Console.WriteLine("Relatório Geral");
            Console.WriteLine();

            Console.SetCursorPosition(0, 3);
            Console.Write("Aluno");
            Console.SetCursorPosition(41, 3);
            Console.Write("Sala");
            Console.SetCursorPosition(48, 3);
            Console.WriteLine("Media");

            LIN = 6;
            for(I = 0; I <= 7; I++)
            {
                Console.SetCursorPosition(0, LIN);
                Console.Write(ALUNO[I].NOME.ToUpper());
                Console.SetCursorPosition(41, LIN);
                Console.Write("{0, 4}", ALUNO[I].SALA);
                Console.SetCursorPosition(48, LIN);
                Console.Write("{0,5:0.00}", ALUNO[I].MEDIA);
                LIN++;
            }
            Console.SetCursorPosition(0, LIN);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
