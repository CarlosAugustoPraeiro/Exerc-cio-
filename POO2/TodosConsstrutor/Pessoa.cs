using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TodosConsstrutor
{
    internal class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int idade;
        public int anocerto;

        public Pessoa()
        {
            nome = "S/N";
            sobreNome = "Falta";
            idade = 0;
        }

        public void Apresentar()
        {
            Console.WriteLine("Oi, " + nome + " sua idade é " + idade);

        }

        public Pessoa(string nome, string sobreNome, int idade)
        {
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.idade = idade;
            anocerto = ano();
        }

        private int ano()
        {
            return 2024 - idade;

        }
        public void Falar()
        {
            Console.WriteLine("Oi, " + nome + " sua idade é " + idade + anocerto);

        }
    }
}
