using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 10.25m;
            Console.WriteLine(
                valor.ToString(
                    "C",
                    CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.ReadKey();
        }
    }
}
// "C" é o padrão
// "F" só separa uma casa
// "P" para porcentagem
// "N" só para números