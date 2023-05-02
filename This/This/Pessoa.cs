using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    internal class Pessoa
    {
        private string nome = "Roberto";

        public Pessoa(string nome) 
        {
           Console.WriteLine(nome);
           Console.WriteLine (this.nome);//This chama a variável nome = "Roberto" 
        }
        
    }
}
