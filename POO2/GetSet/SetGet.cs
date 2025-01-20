using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class SetGet
    {
        private string _nome;
        public string nome
        {
            get { return _nome; } set { _nome = value; }
        }

        private int _idade;

        public int idade
        {
            get { return _idade; }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Menor de idade, não pode");
                }
                else
                {

                    _idade = value;
                    Console.WriteLine("Ok, sua idade é:" + _idade);
                }

            }
        }

    }
}
