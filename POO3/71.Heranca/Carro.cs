using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71.Heranca
{
    // agora a class carro vai herdar tudo da class Veiculo 
    // só precida adicionar, o que não em comum a todos, por exemplo "PLACA e VelMax" que não tem em Bicicleta 

    internal class Carro : Veiculo
    {
        public int Placa { get; set; }
        public int VelMax { get; set; }
    }
}
