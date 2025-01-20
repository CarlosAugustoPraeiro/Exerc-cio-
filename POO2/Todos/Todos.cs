using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos
{
    internal class Todos
    {
        public string nome;
        public string cidade;
        public int idade;

        public void Apresentação()
        {
            Console.WriteLine("Ola, meu nome é " + nome + ", moro em" + cidade + ", Tenho " + idade + " anos!");
        }
    }
}
