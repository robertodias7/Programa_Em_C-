﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.mensagem();

            Console.ReadLine();
        }
    }
}
