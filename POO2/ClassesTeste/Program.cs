using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
           
            p1.nome = Console.ReadLine();
            p1.sobreNome = " Guto";
            p1.idade = 31;
            int num1 = 30;
            p1.Somar(11,11);
            p1.Aumentar(11);
            p1.AumentarRef(ref num1);
            p1.AumentarRef(ref num1);

            p1.Apresentação();

            string nomeCompleto = p1.MontaNome("Monta", "Nome");
            int codigoChar = p1.CodigoChar('q');
            double numePI = p1.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(numePI);

            p1.Comparar(5, 5, 50);
          bool rees =  p1.Comparar2("Carlos", "Carlos");
            Console.WriteLine(rees);








            Console.ReadKey();
        }
    }
}
