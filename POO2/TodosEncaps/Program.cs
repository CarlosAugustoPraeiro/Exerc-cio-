using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosEncaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco p1 = new Banco();

            p1.nome = "Guto";
            p1.saldo = 100;

            double saque = 33;

            p1.sacar(saque);

            Console.WriteLine(p1.saldo);

            Console.ReadLine();


        }
    }
}
