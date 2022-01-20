namespace APPDIO
{
    public class codigo : BaseID
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Sinapse { get; set; }
        private int Data { get; set; }
        private bool Excluido { get; set; }

        public codigo(int ID, Genero Genero, string Titulo, string Sinapse, int Data)
        {
            this.ID = ID;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Sinapse = Sinapse;
            this.Data = Data;
            this.Excluido = false;
        }
        public override string ToString()
            {
                string retorno = "";
                retorno += "Genero: " + this.Genero + Enviroment.NewLine;
                retorno += "Titulo: " + this.Titulo + Enviroment.NewLine;
                retorno += "Sinapse: " + this.Sinapse + Enviroment.NewLine;
                retorno += "Data: " + this.Data + Enviroment.NewLine;
                return retorno;
            }
            public string retornaTitulo()
            {
                return this.Titulo;
            }

            public string retornaID()
            {
                return this.ID;
            }

            public void Excluir()
            {
                this.Excluido = true;
            }
    }
}