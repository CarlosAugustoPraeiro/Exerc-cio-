using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.encapsulamento_Pratica_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Entrada();
            c.Cliente = Console.ReadLine();
            Console.WriteLine("Quanto deseja depositar?");
            c.Deposito(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite Sua Senha");
            c.Acesso(int.Parse(Console.ReadLine()));





            Console.ReadKey();



        }
    }
}
