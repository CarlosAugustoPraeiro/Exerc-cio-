using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int vl1 = Matematica.Diminuir(100);
            int vl2 = Matematica.Aumentar(100);

            Console.WriteLine(vl1);
            Console.WriteLine(vl2);

            
            Pessoa p1 = new Pessoa();
            p1.nome = "Guto";
            p1.idade = Pessoa.maioridade - 10;

            int maior = Pessoa.Calculo(2000);
            p1.Apresentar();

            Console.WriteLine(p1.idade);
            Console.WriteLine(maior);

            Console.ReadKey();




        }







    }
}
