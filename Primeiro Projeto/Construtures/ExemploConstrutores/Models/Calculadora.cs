namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int X, int Y)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição {X} + {Y}");
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum resultado");
            }

            
        }

        public static void Subtrair(int X, int Y)
        {
            System.Console.WriteLine($"Subtração {X} - {Y}");
        }

    }

}