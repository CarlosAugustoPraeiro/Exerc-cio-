﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int idade;

        public void Falar();
    {
        Console.WriteLine("Olá");
    }
   
    }
}
}
