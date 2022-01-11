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
                this.mêsValido = True;
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