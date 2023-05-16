using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArranjosNomeAscendente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            int i, j;
            string x; 

            //Entrada de dados
            for(i = 0; i<= 4; i++)
            {
                Console.Write("Entre com o {0}o. nome: ", i + 1);
                nome[i] = Console.ReadLine();
            }

            // processando ordenação
            for(i = 0; i<=3; i++)
                for(j = i+1; j<=4; j++)
                    if (nome[i].CompareTo(nome[j]) > 0)
                    {
                        x = nome[i];
                        nome[i] = nome[j];
                        nome[j] = x;
                    }
            Console.WriteLine();

            //Apresentação do arranjo

            Console.WriteLine("Lista de nomes ordenada");
            Console.WriteLine();

            for(i = 0; i<=4; i++)
                Console.WriteLine(nome[i]);

            Console.WriteLine();
            Console.Write("Tecle algo para sair... ");
            Console.ReadKey();
        }
    }
}
