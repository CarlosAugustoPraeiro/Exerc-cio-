using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74.Membros_sealed
{
    class Pessoa
    {
        // Quando usado o virtual antes do void, é permito que outras classes herdem podendo modificalas 
        public virtual void Falar()
        { Console.WriteLine("Pessoa.Falando"); }
        public virtual void Andar()
        { Console.WriteLine("Pessoa.Andando"); }
    }
    class Humano : Pessoa
    {
        public override void Falar()
        { Console.WriteLine("Humano.Falando"); }
        public override void Andar()
        { Console.WriteLine("Humano.Andando"); }
        public virtual void Nadar()
        { Console.WriteLine("Humano.Nadando"); }

    }
    // aqui teve uma herança multiplica, Crianca herdou de humano que por sua vez herdou de Pessoa
    class Crianca : Humano
    {
        public override void Falar()
        { Console.WriteLine("Crianca.Falando"); }
        public override void Andar()
        { Console.WriteLine("Crianca.Andando"); }
        // aqui foi usado o "SEALED" no metodo, isso significa que as proximas classes que herdarem , não podera modificar 
        public sealed override void Nadar()
        { Console.WriteLine("Crianca.Nadando"); }
    }
    // aqui foi usado o "SEALED" na class, isso significa que a class não podera ser herdada 
  sealed  class Menino : Crianca
    {
        public override void Falar()
        { Console.WriteLine("Menino.Falando"); }
        public override void Andar()
        { Console.WriteLine("Menino.Andando"); }
       
    }

    class Menina : Menino
    {

    }
}
