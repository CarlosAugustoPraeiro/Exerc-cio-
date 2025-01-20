using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosEstatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Pessoa.maioridade = 8;

            p1.nome = "Guto";
            p1.idade = 10;
            int nn = p1.ano(1993);

            p1.Falar();
            Console.WriteLine(nn);

            Console.ReadLine();

        }
    }
}
