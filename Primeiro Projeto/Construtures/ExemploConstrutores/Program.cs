using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class program
    {
        public void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Fellipe", "Augusto");
            p1.Apresentar();
        }
    }
}