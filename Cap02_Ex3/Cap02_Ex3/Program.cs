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
            float WH, HV, DP, GS, TH, NS;

            Console.Write("Worked hours: ");
            WH = float.Parse(Console.ReadLine());
            Console.Write("Hour value: ");
            HV = float.Parse(Console.ReadLine());
            Console.Write("Discount percentage value: ");
            DP = float.Parse(Console.ReadLine());

            GS = WH * HV; // Salário Bruto
            TH = (DP / 100) * GS; // Total de Horas
            NS = GS - TH; // Salário Líquido

            Console.WriteLine();
            Console.WriteLine("Net Salary: "); Console.WriteLine(NS.ToString("##,##0.00"));
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to exit");
            Console.ReadLine();
        }
    }
}
