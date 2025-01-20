using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
     class Pessoa
    {
        public static int maioridade = 18;

        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine("Oi, meu nome é " + nome);
        }

        public static int Calculo(int anoNasc)
        {
            return DateTime.Now.Year - anoNasc;
        }

    }
}
