using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69.propriedades_get_set_
{
    internal class Teste
    {
        // "private" faz com que a propriedade não possa ser acessado fora da class! tendo que fazer os metodos GET-SET para administrar o acesso
        // a forma de escrever "_nome" não é obrigatorio, mas é padrão 
        // na propriedade "sobrenome" é uma maneira de definir o GET, nesse caso o sobrenome não poderar ser alterado

        private string _Nome;
        public string sobrenome { get; set; } = "Carlos";
        private int _Idade;
        //aqui eu to criando o acesso, GET serve para acessar/ler, o SET serve parar atribuir valor. posso criar apenas o GET ou SET!
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        // aqui tem uma demostração que posso usar IF/ELSE para ter um controle maior no SET, nessse caso a pessoa não podera digitar um valor menor que 18
        public int Idade
        {
            get
            {
                return _Idade;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser menor que 18");
                }
                else
                {
                    _Idade = value;
                }
            }
        }
        
        public void Apresentar()
        { 
            if (_Nome != "")
                Console.WriteLine("bem vindo" +  _Nome);
        }
    }

}
