using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscolar{
    internal class Program
    {
        static void Main(string[] args)
        {
          
         Aluno a = new Aluno();
            a.nome = "Roberto";
            a.nota1 = 9;
            a.nota2 = 8;
            a.mensagem();

            Console.ReadKey();
        }
    }
}
