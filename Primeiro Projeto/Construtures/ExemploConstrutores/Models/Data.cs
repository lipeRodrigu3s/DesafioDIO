namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int Mês;
        private bool mêsValido;


        public GetMês()
        {
            int mês1 = this.Mês;
        }

        public void SetMês(int mês)
        {
            if (mês > 0 && mês <= 12)
            {
                this.mês = mês;
                this.mêsValido = true;
            }
        }
        public int mês 
        { 
            get
            {
                return this.Mês;
            }
            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mês = value;
                    this.mêsValido = true;
                }
            } 
        }

        public void ApresentarMês()
        {
            if(this.mêsValido)
            {
                System.Console.WriteLine(this.mês);
            }
            else
            {
                System.Console.WriteLine("Mês Invalido");
            }
        }
    

    }
}