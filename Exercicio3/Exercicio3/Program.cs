using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c;

      
            c = b;
            b = a;
            a = c;


            
            Console.WriteLine("a valia 5 e agora a = {0} e b valia 3 e agora b = {1}", a, b);
            Console.ReadLine();
        }
    }
}
