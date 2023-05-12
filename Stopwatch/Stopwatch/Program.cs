using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("[S] - Segundos => 10s");
            Console.WriteLine("[M] - Minutos => 1m");
            Console.WriteLine("[0] - Para sair");
            Console.Write("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();// Para colocar letras em forma minúsculas
            char type = char.Parse(data.Substring(data.Length - 1, 1));// Para pegar o último caractere que o usuário digitou
            int time = int.Parse(data.Substring(0, data.Length - 1)); //Para pegar o tempo, a quantidade de  números
            int multilier = 1;
    

            if (type == 'm')
                multilier = 60-1;

             if(type == 0)
                System.Environment.Exit(0);

                Console.ReadKey();

            PreStart(time * multilier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
            Console.ReadKey();
                
        }

        static void Start(int time = 6, int currentTime = 0)
        {

            while(currentTime != time) 
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);// Constagem do tempo
            }
            Console.Clear() ;
            Console.WriteLine("Tempo Finalizado!");
            Thread.Sleep(2500);
            Menu();

        }
    }
}
