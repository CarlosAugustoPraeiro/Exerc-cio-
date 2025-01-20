using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosEncaps
{
    internal class Banco
    {
        public double saldo;
        public string nome;
        private int taxa = 10;


        public void Add(double num1)
        {
           
            saldo += num1;
        }
        public void sacar(double num1)
        {
            num1 += taxa;
            saldo -= num1;
        }
    }
}
