using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMC
{
    internal class Pessoa
    {
        public double peso, altura;

        public double calculo()
        {
            return peso / (altura * altura);

        }

        public string situacao( double imc)
        {
            string retorno;

            if(imc < 18.5)
            {
                retorno = "Abaixo do Peso";
            }
            else if (imc < 25)
            {
                retorno = "Normal";
            }
            else if (imc < 30)
            {
                retorno = "Acima do Peso";
            }
            else if (imc < 35)
            {
                retorno = "Obesidade I";
            }

            else if (imc < 40)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }

            return retorno;

        }
        public void mensagem ()
        {
            double obterCalculo = calculo();
            string obterSituacao = situacao(obterCalculo);

            Console.WriteLine("O seu IMC é " + obterCalculo);
            Console.WriteLine("Sua situação é: " + obterSituacao);
        }
    }

}