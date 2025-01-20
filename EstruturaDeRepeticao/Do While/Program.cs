using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    internal class Program
    {
        // a diferença do while e do while, nesse caso é que se fosse colocar apenas while não executaria o Console.Write, 
        //pois o nummero já seria maior que 5 !
        static void Main(string[] args)
        {
            int numero = 15;

            do
            {
                Console.WriteLine("O valor é:" + numero);
                numero++;
            }
            while (numero < 5);

            Console.ReadKey();
        }
    }
}
