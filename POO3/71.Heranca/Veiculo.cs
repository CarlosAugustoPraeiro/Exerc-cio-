using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71.Heranca
{
    internal class Veiculo
    // a herança é simples, é o aproveitamento dos atributos e metodos de uma classe
    //No caso após criar a class veiculo, depois se eu quiser criar uma classe "carro, moto, onibus"
    // é só botar carro : veiculo , moto : veiculo
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
      

        public void Acelerar()
        {
            Console.WriteLine("Acelerou");
        }
        public void Frear()
        {
            Console.WriteLine("Parar");
        }



    }
}
