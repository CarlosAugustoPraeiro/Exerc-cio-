using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Soma:
//Um método que recebe dois números inteiros e retorna a soma.
//Um método que recebe três números inteiros e retorna a soma.
//Um método que recebe dois números decimais e retorna a soma.
//Subtração:
//Um método que recebe dois números inteiros e retorna a diferença.
//Multiplicação:
//Um método que recebe dois números inteiros e retorna o produto.
//Um método que recebe um número inteiro e um número decimal e retorna o produto.
//Divisão:
//Um método que recebe dois números inteiros e retorna o quociente inteiro.
//Um método que recebe dois números decimais e retorna o quociente decimal.
//Adicione um tratamento para divisão por zero.
namespace ExercicioConstrutor
{
    internal class Calculadora
    {
        int num1 = 0;
        int num2 = 0;
        double num3 = 0;
        double num4 = 0;

        public int Soma(int n1, int n2)
        {
            return n1 + n2;
            Console.WriteLine(n1 + n2);
        }
        public int Soma(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
            Console.WriteLine(n1 + n2 + n3);
        }
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
            Console.WriteLine(n1 + n2);
        }





    }
}
