using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    static class Matematica
    {
        private static int taxa = 10;

        public static int Aumentar(int valor)
        {
            return taxa + valor;
        }
        public static int Diminuir(int valor)
        {
            return taxa - valor;
        }

    }
}
