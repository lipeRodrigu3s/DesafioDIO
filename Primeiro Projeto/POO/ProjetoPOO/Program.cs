using System;
using ProjetoPOO.models;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Lipe";
            p1.Idade = 21;
            p1.Apresentar();
        }
    }
}