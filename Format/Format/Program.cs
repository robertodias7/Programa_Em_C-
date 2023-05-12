using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V1 = 123.456, V2 = 234.5, V3 = 345.0, V4 = 12345.67, V5 = 1234.5, V6 = 12345.6789;
            int V7 = 123, V8 = 12, V9 = 1;
            long x = 1234567890;
            long y = 12345678901;

            //Apresentação com duas casas decimais
            Console.WriteLine("=>> Casas decimais");
            Console.WriteLine(String.Format("{0:0.00}", V1));
            Console.WriteLine(String.Format("{0:0.00}", V2));
            Console.WriteLine(String.Format("{0:0.00}", V3));
            Console.WriteLine();

            //Apresentação com separador de milhar
            Console.WriteLine("=>> Separador de milhar");
            Console.WriteLine(String.Format("{0:0,0.00}", V4));
            Console.WriteLine(String.Format("{0:0,0.00}", V5));
            Console.WriteLine(String.Format("{0:0,0.00}", V6));
            Console.WriteLine();

            //Apresentação com alinhamento a direita - valor real
            Console.WriteLine("=>> Alinhamento a direita - valor real");
            Console.WriteLine(String.Format("{0, 15:0,0.00}", V4));
            Console.WriteLine(String.Format("{0, 15:0,0.00}", V5));
            Console.WriteLine(String.Format("{0, 15:0,0.00}", V6));
            Console.WriteLine();

            //Apresentação com zeros a direita
            Console.WriteLine("=>> Zeros a direita");
            Console.WriteLine(String.Format("{0:00000}", V7));
            Console.WriteLine(String.Format("{0:00000}", V8));
            Console.WriteLine(String.Format("{0:00000}", V9));
            Console.WriteLine();

            //Apresentação com alinhamento a direita - valor inteiro
            Console.WriteLine("=>> Alinhamento a direita - valor inteiro");
            Console.WriteLine(String.Format("{0,5}", V7));
            Console.WriteLine(String.Format("{0,5}", V8));
            Console.WriteLine(String.Format("{0,5}", V9));
            Console.WriteLine();

            //Apresentação formatação customizada
            Console.WriteLine("=>> Formatação customizada");
            Console.WriteLine(String.Format("{0: (0xx##)####-####}", x));
            Console.WriteLine(String.Format(@"{0: ###\.###\.###-###}", y));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Tecle algo para encerrar");
            Console.ReadKey();

        }
    }
}
