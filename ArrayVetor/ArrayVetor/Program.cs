using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];

            nome[0] = "Guto";
            nome[1] = "Carlos";
            nome[2] = "Augusto";

            // aqui é outra forma de declarar os valores 

            int[] idade = { 2, 3, 5 };

            Console.WriteLine(nome[0]);
            Console.WriteLine(idade[1]);

            Console.WriteLine("Digite um nome:");
            nome[1] = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            idade[1] = int.Parse(Console.ReadLine());

            Console.WriteLine(nome[1] + idade[1]);


            Console.ReadKey();


        }
    }
}
