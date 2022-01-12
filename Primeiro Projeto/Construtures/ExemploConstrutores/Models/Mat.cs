namespace ExemploConstrutores.Models
{
    public class Mat
    {
        public int x { get; set; }
        public int y { get; set; }


        public Mat(int X, int Y)
        {
            X = x;
            Y = y;
            Calculadora.EventoCalculadora += EventHandler;
        }

        internal void Somar()
        {
            throw new NotImplementedException();
        }

        public  void Somar(int X, int Y)
        {
            Calculadora.Somar(X, Y);
        }



        public void EventHandler()
        {
            System.Console.WriteLine("Feito");
        }
    }
    
}