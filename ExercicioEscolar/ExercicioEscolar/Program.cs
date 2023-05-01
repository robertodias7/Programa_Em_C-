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
            a.nome = "Denis";
            a.nota1 = 5;
            a.nota2 = 4;
            a.mensagem();

            Console.ReadLine();



        }
    }
}
