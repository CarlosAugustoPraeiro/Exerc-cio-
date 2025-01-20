using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar acessar = new Acessar();

            Console.WriteLine("Digite sua senha: ");
           string senhaDigitada = Console.ReadLine();

            if (acessar.Login(senhaDigitada))
            {
                Console.WriteLine("Acesso Autorizado");
            }
            else
            {
                Console.WriteLine("Acesso Negado");
            }
            Console.ReadKey();


        }
    }
}
