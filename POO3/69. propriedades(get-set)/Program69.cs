using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.propriedades_get_set_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();

            t.Idade = 19;
            t.Nome = "Guto";
            t.sobrenome = "Augusto";

            
            Console.WriteLine(t.Nome + " tem " + t.Idade + " idade" + t.sobrenome);
            


            Console.ReadKey();


        }
    }
}
