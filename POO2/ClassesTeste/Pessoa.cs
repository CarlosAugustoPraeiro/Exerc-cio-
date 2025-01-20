using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTeste
{
    class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int idade;
        public void Apresentação()
        {
            Console.WriteLine("Oi, Meu nome é " + nome + " " + sobreNome + " e tenho " + idade + " anos");
        }
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Aumentar(int valor)
        {
            valor += 10;
            Console.WriteLine("O valor é: " + valor);
        }
        public void AumentarRef(ref int valor)
        {
            valor += 23;
            Console.WriteLine("O valor é: " + valor);
        }

        public string MontaNome(string nome, string sobre)
        {
            string NomeCompleto = nome + sobre;
            return nome + sobre;
        }

        public int CodigoChar(char caractere)
        {
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }

        public void Comparar(int num1, int num2)
        {
            string mensagem = num1 < num2 ? "Primeiro numero menos" : "Primeiro numero menor";
            Console.WriteLine(mensagem);
        }

        public void Comparar(int num1, int num2, int num3)
        {
            string mensagem = num1 + num2 < num3 ? "numero 3 é foda" : "numero 3 perdeu";
            Console.WriteLine(mensagem);
        }

        public bool Comparar2(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar2(string txt1, string txt2)
        {
            return txt1 == txt2;

        }
        public bool Comparar2(int num1, int num2, int num3)
        {
            return num1 + num2 < num3;
        }
    }
}
