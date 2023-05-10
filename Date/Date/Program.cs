using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;

            var fortmatado = string.Format("{0:dd/MM/yyyy}", date);
            Console.WriteLine(fortmatado);

            Console.ReadKey();
        }
    }
}
