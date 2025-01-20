using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
   class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int idade;

        public void Falar()
        {
            Console.WriteLine("Ola");
        }

        public void Soma(int n1, int n2)
        {
            Console.WriteLine("A soma é :" + (n1 + n2));
        }
        
    }
}
