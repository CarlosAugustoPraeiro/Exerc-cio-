using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TodosGetSet2
{
    internal class PEssoa
    {
        private int _idade;

        private string _nome = "BANCO";

        public string Nome
        {
            get { return _nome; }
        }


        public int Idade
        {
            get { return _idade; }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser menor que 18");
                }
                else
                {
                    _idade = value;
                }
            }
        }






    }
}
