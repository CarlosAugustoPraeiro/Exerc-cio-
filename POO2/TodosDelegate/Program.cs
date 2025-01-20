using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosDelegate
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);
        delegate void Test(int num1);


        static void Main(string[] args)
        {
            Matematica exemplo = new Matematica();

            Operacao conta = null;

            conta += exemplo.Multiplicar;
            conta += exemplo.Soma;

            conta(33, 80);

            Matematica tt = new Matematica();
            Test res = null;

            res += tt.Teste;

            res(5);





            Console.ReadKey();




        }
    }
}
