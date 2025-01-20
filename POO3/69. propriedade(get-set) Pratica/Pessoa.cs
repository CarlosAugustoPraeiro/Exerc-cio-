using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _69.propriedade_get_set__Pratica
{
    internal class Pessoa
    {
        private string _Nome;
        private int _Idade;
        private string _Empresa = "ROCK";

        public string Empresa
        {
            get { return _Empresa; } private set { }
        }
        public string Nome
        {
            get { return _Nome; }
            set
            {
                if (value != "Carlos")
                {
                    Console.WriteLine("Nome incorreto");
                }
                else
                {
                    _Nome = value;
                }
            }
        }
        public int Idade
        {
            get { return _Idade; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Valor não pode ser menor que 18");
                }
                else
                {
                    _Idade = value;
                }


            }
        }
            public void Apresentar()
        {
            if (_Nome != "Carlos" || _Idade < 18)
            {
                Console.WriteLine("Nome ou Idade não batem");
            }
            else
            {
                Console.WriteLine(" Ola " + _Nome + "VocÊ tem  " + _Idade + " " + _Empresa);
            }
            
        }
        
    }
}
