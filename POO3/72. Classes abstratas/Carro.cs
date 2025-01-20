using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72.Classes_abstratas
{
    // es´ta com erro por causa da explicação do metodo voar da classe Veiculo
    internal class Carro : Veiculo
    {
      
        // quando implementar na herança, vai substituir sbstract para override! 
        public override void Acelerar()
        {
            Console.WriteLine("Carro Acelera");
        }
        public override void Frear()
        {
            Console.WriteLine("Carro freia");
        }
    }
}
