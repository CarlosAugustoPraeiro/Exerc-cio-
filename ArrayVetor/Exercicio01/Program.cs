using Exercicio01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Crie um programa que declare um array de 5 elementos do tipo int.
O programa deve solicitar ao usuário que insira 5 números inteiros e armazená-los no array.
Em seguida, calcule a soma de todos os números armazenados e a média.
Exiba a soma e a média no console.*/
namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            Console.WriteLine("Digite 5 numeros");

            Console.WriteLine("Numero #1:");
            num[0] = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Numero #2:");
            num[1] = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Numero #3:");
            num[2] = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Numero #4:");
            num[3] = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Numero #5:");
            num[4] = int.Parse(Console.ReadLine());
            Console.Clear();

            double soma = num[0] + num[1] + num[2] + num[3] + num[4];
            double media = soma / 4;

            Console.WriteLine("A soma dos numeros é: " + soma);
            Console.WriteLine("A media dos numeros é: " + media);

            Console.ReadKey();

        }
    }
}
