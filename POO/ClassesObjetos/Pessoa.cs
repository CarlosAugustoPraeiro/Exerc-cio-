using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Pessoa
    { 
    {
        // atributos da classe
        public string nome;
        public int idade;
        public double altura;

        public void Apresentação()
        {
            Console.WriteLine(" Oi eu sou " + nome + " e tenho" + idade + " anos!");

        }
    }
    }
