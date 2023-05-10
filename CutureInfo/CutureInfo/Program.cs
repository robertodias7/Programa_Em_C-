using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutureInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var en = new CultureInfo("en-US");
            var br = new CultureInfo("pt-BR");
            var de = new CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString("D", en));
            //Console.WriteLine(string.Format("{0:d}", DateTime.Now));

            Console.ReadLine();
        }
    }
}