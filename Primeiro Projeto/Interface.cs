namespace Interface
{
    interface IAnimal
    {
        void nome (String nome);
        void Dono(String nomeDono);
        Void Especie(String Especie);
    }
          class Animal : IAnimal
          {
                public String Nome { get; set; } 
                public string NomeDono { get; set; } 
                public String Especie { get; set; }

                void IAnimal.nome(string Nome)
                {
                    this.Nome = Nome;
                }
                void IAnimal.Dono(string nomeDono)
                {
                    this.NomeDono = nomeDono;
                }    
                void IAnimal.Especie(string Especie)
                {
                    this.Especie = Especie; 
                }
          }  
}