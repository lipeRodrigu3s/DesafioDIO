using System;

namespace ProjetoPOO.models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} de idade ");
        }
    }
}