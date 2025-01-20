using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c.Cliente = "Carlos";

            c.Depositar(100);

            Console.WriteLine("Nome do cliente é :" + c.Cliente + " é seu saldo é: " + c.Saldo);

            Console.ReadKey();
        }
    }
}
