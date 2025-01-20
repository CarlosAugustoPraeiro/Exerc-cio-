using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
     class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

        //aqui to criando a estrutura, nao prcisa do "void" 
        public Pessoa()
        {
            nome = "Desconhecido";
            sobrenome = "Desconhecido";
            idade = 0;
        }
        public Pessoa(string nome)
        {
            this.nome = nome;
           
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            idade = 0;
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = 2024 - idade;


        }
        private int Ano()
        {
            return 2024 - idade;



        }

    }
}
