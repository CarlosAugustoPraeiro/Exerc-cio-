using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayVetorBidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aqui ta criando um vetor com linhas e colunas, 2 linhas com 3 comlunas
            int[,] numero = new int[2, 3];
            // Aqui esta colocando os valores na linha 1
            numero[0, 0] = 10;
            numero[0, 1] = 20;
            numero[0, 2] = 30;
            // Aqui esta colocando os valores na linha 2
            numero[1, 0] = 40;
            numero[1, 1] = 50;
            numero[1, 2] = 60;

            // aqui é outra forma de declarar vetores bidimensionais, no caso 2 linhas com 4 colunas 

            int[,] idade =
                {
                { 5 , 6, 7, 8,  },
                {10 , 11, 12, 13, },

            };


        }
    }
}
