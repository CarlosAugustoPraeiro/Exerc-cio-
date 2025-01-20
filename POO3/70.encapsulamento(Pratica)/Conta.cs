using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _70.encapsulamento_Pratica_
{
    internal class Conta
    {
        private string _Banco = "BBANCK";
        private string _Cliente;
        private int _Senha;
        private double _Saldo;
        

        public string Banco => _Banco;
   
        public string Cliente
        {
            get { return _Cliente; }
            set
            {
                if (value != "Carlos")
                {
                    _Cliente = "Desconhecido";
                    Saldo = 0;
                    Senha = 000;

                }
                else
                {
                    _Cliente = value;
                    _Saldo = 100;
                    _Senha = 123;
                }
            }
        }
        public double Saldo
        {
            get { return _Saldo; }
            private set { _Saldo = value; }
        }
        public int Senha
        {
            get { return _Senha; }
            private set { _Senha = value; }
        }


        public void Deposito(int Valor)
        {
            _Saldo += Valor;
        }
        public void Saque(int Valor)
        {      
            _Saldo -= Valor;
        }

        public void Acesso(int valor)
        {
            if (_Senha != valor)
            {
                Console.WriteLine("Senha Incorreta");
            }
            else
            {
                Console.WriteLine("Acesso Liberado! Seu Saldo é: " +_Saldo);
            }
        }
        
        public void Entrada()
        {
            Console.WriteLine("Bem Vindo ao banco " + _Banco+"!" +" Digite seu nome:");
        }



    }
}