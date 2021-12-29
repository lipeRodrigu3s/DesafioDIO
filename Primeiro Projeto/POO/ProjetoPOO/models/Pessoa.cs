using System;

namespace ProjetoPOO.models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome e: {Nome} e tenho {Idade} de idade ");
        }
    }
}