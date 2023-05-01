using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscolar
{
    internal class Aluno
    {
        public string nome;
        public double nota1, nota2;

        public double media()
        {
            return (nota1 + nota2) / 2;
        }

        public string situacao(double media)
        {
            return media >= 7 ? "Aprovado!" : "Reprovado!";
    
    }

        public void mensagem()
        {
            double obterMedia = media();
            string obterSituacao = situacao(obterMedia);

            Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
        }
    }
}
