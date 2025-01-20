using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    internal class Program
    {
        // while é parecido com if, porém so tem uma instrução, sem precisar o else.
        static void Main(string[] args)
        {
            int valor = 0;

            while (valor < 5)
            {
                Console.WriteLine("Valor é :" + valor);
                valor++;           
            }
            Console.ReadKey();
        }
    }
}
