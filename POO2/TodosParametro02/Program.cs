using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodosParametro02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parametro Pessoa = new Parametro();

            double pi = Pessoa.ValorPI();
            Console.WriteLine(pi);

            string nmTodo = Pessoa.NomeTodo("Guto" , "Augusto");
            Console.WriteLine(nmTodo);

            int num = 10;
            Pessoa.NomeCompleto("Carlos", "Augusto");
            Pessoa.NomeCompleto("Carlos", "Guto", 31);
            Pessoa.ValorAlmentado(1);
            Pessoa.ValorAlmentadoRef(ref num);
            Pessoa.ValorAlmentadoRef(ref num);

            Console.ReadLine();
           
        }
    }
}
