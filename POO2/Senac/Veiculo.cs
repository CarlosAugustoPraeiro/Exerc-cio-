using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac
{
    abstract class Veiculo
    {
        public string cor;
        public string marca;



    }

    class Carro : Veiculo
    {
        Carro c = new Carro();

        c.cor = "rosa";
    }
}
