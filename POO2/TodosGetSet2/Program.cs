using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosGetSet2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PEssoa p1 = new PEssoa();

            p1.Idade = 4;
           string Nome = p1.Nome;




            Console.WriteLine(p1.Idade);
            Console.WriteLine(p1.Nome);

            Console.ReadKey();
         }
    }
}
