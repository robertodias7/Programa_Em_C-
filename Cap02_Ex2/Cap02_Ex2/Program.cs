using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aplicação com Valor Inteiro

            int A, B, R;
            Console.Write("Enter with 1o number: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Enter with 2o number: ");
            B = int.Parse(Console.ReadLine());

            R = A + B;

            Console.WriteLine();
            Console.WriteLine("The sum of the two number is: "+ R);
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit");
            Console.ReadLine();
        }
    }
}
