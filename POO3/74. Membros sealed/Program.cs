using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74.Membros_sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano h = new Humano();
            Crianca c = new Crianca();
            Menino m = new Menino();

            m.Andar();
            m.Nadar();

            c.Nadar();

            h.Nadar();

            Console.ReadKey();
        }
    }
}
