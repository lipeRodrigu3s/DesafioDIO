namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Fellipe";
        private readonly string sobrenome = "Augusto";

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Clase Pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}");
        }

    }
}