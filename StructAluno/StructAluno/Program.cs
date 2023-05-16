using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAluno
{
    internal class Program
    {   
        public struct CAD_ALUNO
        {
            public string NOME;
            public int SALA;
            public float[] NT;
            public float MEDIA;
        };
        static void Main(string[] args)
        {
            CAD_ALUNO[] ALUNO = new CAD_ALUNO[4];
            CAD_ALUNO X;
            int I, J, LIN;
            float SOMA;

            //Rotina para a entrada dos nomes, sala e media

            for (I = 0; I <= 3; I++)
            {
                SOMA = 0;
                ALUNO[I].NT = new float[4];
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine();
                Console.Write("Entre o {0}o. nome ...: ", I + 1);
                ALUNO[I].NOME = Console.ReadLine();
                Console.Write("Entre a sala .......: ");
                ALUNO[I].SALA = int.Parse(Console.ReadLine());

                for(J = 0; J <= 3; J++)
                {
                    Console.Write("Entre com a nota {0} .....: ", J + 1);
                    ALUNO[I].NT[J] = float.Parse(Console.ReadLine());
                    SOMA += ALUNO[I].NT[J];
                }
                ALUNO[I].MEDIA = SOMA / 4;
                Console.WriteLine();

            }

            //Classificação dos dados
            for (I = 0; I <= 2; I++)
                for (J = I + 1; J <= 3; J++)
                    if (ALUNO[I].NOME.CompareTo(ALUNO[J].NOME) > 0)
                    {
                        X = ALUNO[I];
                        ALUNO[I] = ALUNO[J];
                        ALUNO[J] = X;
                    }
            //Apresentação da tabela nome/nota/media

            Console.Clear();
            Console.WriteLine("Relatório Geral");
            Console.WriteLine();

            Console.SetCursorPosition(0, 3);
            Console.Write("Aluno");
            Console.SetCursorPosition(41, 3);
            Console.Write("Sala");
            Console.SetCursorPosition(48, 3);
            Console.WriteLine("Media");

            LIN = 2;
            for (I = 0; I <= 3; I++)
            {
                Console.SetCursorPosition(0, LIN);
                Console.Write(ALUNO[I].NOME.ToUpper());
                Console.SetCursorPosition(41, LIN);
                Console.Write("{0,4}", ALUNO[I].SALA);
                Console.SetCursorPosition(48, LIN);
                Console.Write("{0,2:0.0}", ALUNO[I].MEDIA);
                LIN++;
            }

            Console.SetCursorPosition(0, LIN);
            Console.WriteLine();
            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
    
}
