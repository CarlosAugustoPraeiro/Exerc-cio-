using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };

            foreach (int numero in num)
            {
                Console.WriteLine("São esses: " + numero);

                
            }
            Console.ReadKey();
        }
    }
}
