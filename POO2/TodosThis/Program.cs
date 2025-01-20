using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Senha teste = new Senha();

            Console.WriteLine("Digite sua senha:");
            string num1 = Console.ReadLine();
            teste.Zenha(num1);

            if (teste.Zenha(num1))
            {
                Console.WriteLine("Correta");
            }
            else
            {
                Console.WriteLine("Incorreta");
             
            }
       
        }
    }
}
