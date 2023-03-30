using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL;

            Console.Write("Horas trabalhadas.....: ");
            HT = float.Parse(Console.ReadLine());
            Console.Write("Valor da hora.........: ");
            VH = float.Parse(Console.ReadLine());
            Console.Write("Valor do Percentual...: ");
            PD = float.Parse(Console.ReadLine());

            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;

            Console.WriteLine();
            Console.WriteLine("Salário líquido...: ");
            Console.WriteLine(SL.ToString("##, ##0.00")); // formatação de números
            Console.WriteLine();
            Console.WriteLine("Tecle <Enter> para encerrar ... ");
            Console.ReadLine();
        }
    }
}
