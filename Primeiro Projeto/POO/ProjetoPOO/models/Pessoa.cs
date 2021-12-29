using System;

namespace ProjetoPOO.models
{
    public class Pessoa
    {
        public string nome { get; set; }

        public int idade { get; set; }

        public void apresentar()
        {
            Console.WriteLine($"Meu nome e: {nome} e tenho {idade} de idade ");
        }
    }
}