using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosEstatico
{
    class Pessoa
    {
       public static int maioridade = 18;

        public string nome;
        public int idade;
        public int nn;
        public int ano(int num1)
        {
         nn = num1;
          return num1 - idade;

        }
            
        public void Falar()
        {
            if (idade < maioridade)
            {
                Console.WriteLine("Vc é de Menor, " + nome + ", Vc nasceu em, " + nn );

            }
            else
            {
                Console.WriteLine("Vc é de MAior, "+  nome + ", Vc nasceu em, " + nn);
            }
        }



    }
}
