using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosGetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1.vm = 200;
            c1.md = "bla";
            Console.WriteLine(c1.md);
            Console.WriteLine(c1.vm);
            Console.ReadLine();
            int n = c1.vm;


            Console.WriteLine(" oi " + c1.vm + n + c1.md);
            Console.ReadLine();
        }
    }
}
