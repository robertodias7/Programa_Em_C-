using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidade, distancia, tempo, litros_usados;
            //float l = 1;

            
            Console.Write("Qual foi o tempo gasto em minutos: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("Qual a Velocidade: ");
            velocidade = double.Parse(Console.ReadLine());

            distancia = tempo * velocidade;
            litros_usados = distancia / 12;
            Console.WriteLine();

            Console.WriteLine("A velocidade média é de: {0}KM", velocidade);
            Console.WriteLine("O tempo gasto na viagem foi de: {0}Min", tempo);
            Console.WriteLine("A diastância percorrida foi de: {0}", distancia.ToString(""));
            Console.WriteLine("A quantidade de litros utilizada é de: {0}", litros_usados.ToString("f0"));
            Console.ReadLine();

        }
    }
}
