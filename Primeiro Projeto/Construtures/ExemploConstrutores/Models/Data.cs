namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mês;
        private bool mêsValido;


        public Getmês()
        {
            return this.mês;
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
                if(Value > 0 && Value <= 12)
                {
                    this.mês = Value;
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