using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosGetSet
{
    internal class Carro
    {
        private string modelo = "4x4";
        private int velMax = 300;
        public string nome;
        public string cor;

        public string md { get { return modelo; } set { modelo = value; } }

        public int vm
        {
            get { return velMax; }
            set
            {
                if (value <= 0) { velMax = 0; }
                else if (value > 300) { velMax = 300; }
                else { velMax = value; }

            }
        }
    }
}
