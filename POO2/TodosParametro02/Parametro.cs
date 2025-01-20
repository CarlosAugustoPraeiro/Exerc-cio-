using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosParametro02
{
    internal class Parametro
    {
        public double ValorPI()
        {
            return 3.1415;
        }
        public string NomeTodo(string n1, string n2)
        {
            return n1 + n2;
        }
        public void NomeCompleto(string nome, string sobreNome)
        {
            string nomeTodo = nome + " " + sobreNome;
            Console.WriteLine(nomeTodo);
        }
        public void NomeCompleto(string nome, string sobreNome, int idade)
        {
            int ano = 2024 - idade;
            string nomeTodo = nome + " " + sobreNome;
            Console.WriteLine(nomeTodo + "NAsci em " + ano );
        }
        public void ValorAlmentado(int num)
        {
            num += 33;

            Console.WriteLine(num);
        }
        public void ValorAlmentadoRef(ref int num)
        {
            num += 50;

            Console.WriteLine(num);
        }
    }
}
