namespace PraticaPOO.Models
{
    public class Conta
    {
        public Conta(string Agencia, Double Saldo)
        {
            this.Agencia = Agencia;
            this.Saldo = Saldo;
        }



        private Double Saldo { get; set; }
        public Double Credito{ get; set; }
        public Double Poupança{ get; set; }
        public string Agencia { get; private set; }

        public double Extrato()
        {
            return this.Saldo += this.Poupança;
        }

        public void Depositar(Double Valor)
        {
            this.Saldo += Valor;
        }

        public bool Sacar(Double Valor)
        {
            Double saldoDisponivel = this.Extrato();

            if(Valor > saldoDisponivel)
            {
                Console.WriteLine("Saque indisponivel");
                return false;
            }
               
            this.Saldo -= Valor;
            return true;
        }
    }
}