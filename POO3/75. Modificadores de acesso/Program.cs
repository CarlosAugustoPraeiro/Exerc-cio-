using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75.Modificadores_de_acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            teste t = new teste();

            t.Nome = "";

            teste2 t2 = new teste2();

            t2.Chamar();

          
            Console.ReadKey();
        }
        
    }
}
