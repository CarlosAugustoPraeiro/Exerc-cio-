using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75.Modificadores_de_acesso
{
    internal class teste
    {
        public string Nome;
        public int Idade;
        private int _Senha;
        protected string _Usuario;
    }

    class teste2 : teste
    {
        
        public void Chamar()
        {
            Nome = "";
            _Usuario = "G";
            Console.WriteLine(_Usuario);

        }

    }
}

// private: Acessível somente dentro da própria classe.
//public: Acessível de qualquer lugar.
//protected: Acessível dentro da classe e em classes derivadas, as classes que herdam