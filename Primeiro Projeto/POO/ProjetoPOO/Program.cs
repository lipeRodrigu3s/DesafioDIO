using System;

namespace ProjetoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.nome = "Lipe";
            p1.idade = 21;
            p1.apresentar();
        }
    }
}