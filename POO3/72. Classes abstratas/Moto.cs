using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72.Classes_abstratas
{
    internal class Moto : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Moto Acelera");
        }
        public override void Frear()
        {
            Console.WriteLine("Moto freia");
        }
    }
}
