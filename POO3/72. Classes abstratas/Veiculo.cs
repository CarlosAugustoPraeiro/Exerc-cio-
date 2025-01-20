using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// tem a mesma logica da herança, porém com alguns detalhes importantes, a primeira é que antes da "Class Veiculo" vai colocar 
// Abstract, com isso a classe VEiculo não poderar entancia ela mesma, só como herança 
namespace _72.Classes_abstratas
{
    abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Cor { get; set; }

        // outra forma de deixar abstrato são os metodos, é só colocar abstract antes do tipo void, dessa forma as heranças serao
        // obrigadas a impletar , porem cada um do seu jeito 
        public abstract void Acelerar();

        public abstract void Frear();

        // aqui deu erro, pois quando o metodo ta abstrado, não se coloca a implementação as{}, pois cada gerança vai implemntar a sua
       
        public abstract void Voar()
        {
            Console.WriteLine("Subindo");
        }



    }
}


