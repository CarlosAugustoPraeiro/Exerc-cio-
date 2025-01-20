using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //Aqui estou criando novos objetos/estanciar a partir da classe que criei na linha 20
            MinhaClasse mClasse = new MinhaClasse();
            MinhaClasse m2 = new MinhaClasse();

            // aqui eu só crio um objeto sem colocar nenhum valor a ele 
            MinhaClasse m3 = null;

            // aqui crei um novo objeto a partir da classe criada no outro arquivo 
            OutraClasse oClasse = new OutraClasse();
            #endregion

            // aqui estou criando objetos a partir da classe pessoa 
            Pessoa p1 = new Pessoa();
            p1.nome = " Carlos";
            p1.altura = 1.83;
            p1.idade = 31;
            p1.Apresentação();

            Pessoa p2 = new Pessoa();
            p2.nome = "Guto";
            p2.altura = 1.63;
            p2.idade = 18;



            Console.WriteLine("O nome da pessoa 1 é:" + p1.nome);
            p1.Apresentação();

        }
    }
    //aqui criei uma nova classe dentro do escorpo namespace
    class MinhaClasse
    {

    }    
}
