using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77.Interfaces
{
    internal class Conta : IUsuario
    {
        public string Nome { get ; set; }

        public void Despositar()
        {
            
        }

        public void Sacar()
        {
            
        }

        public void Saldo()
        {
            
        }
    }
    // o Interface obriga as classes que herdam ele à inplementar todos os parametros, uma especie de contrato.
    // mesma função do abstract , porem é obrigado o herdae todos os campos sem precisa por anstract
    // por isso nao tem os modificadores de acesso " public, private, virtual e etc"
    interface IUsuario
    {
        string Nome { get; set; }

        void Despositar();
        void Sacar();
        void Saldo();


    }
}
