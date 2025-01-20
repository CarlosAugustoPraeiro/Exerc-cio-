using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70.encapsulamento
{
    internal class Conta
    //Aqui to deixando todos as propiedades em "private" para pode controlar o acesso depois 
    {
        private string _cliente;
        private double _saldo;
        private double _taxa = 10;

        // aqui o Cliente coloca seu nome, a estruta reconhece o nome e diz o saldo dele 
        public string Cliente
        {
            get { return _cliente; }
            set
            {
                if (value != "Carlos")
                {
                    _cliente = "Visitante";
                    Saldo = 0;
                }
                else
                {
                    _cliente = value;
                    Saldo = 100;
                }
            }
        }

        // aqui o GET ta privado, se não na execução do programa , poderia ser alterado o valor facilmente
        public double Saldo
        {
            get { return _saldo; }
            private set
            {
                _saldo = value;
            }
        }

        // aqui o valor da taxa já foi definido acima,fiz o metodo de saque e deposito 
        public void Sacar(double valor)
        {
            valor += _taxa;
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }
    }
}
