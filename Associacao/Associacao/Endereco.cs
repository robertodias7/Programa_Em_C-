using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associacao
{
    internal class Endereco
    {
        public string Logradouro;
        public int Numero;
        public string Cidade;
    }

    class Pessoa
    {
        public string Nome;
        public Endereco Residencia;
    }
}
