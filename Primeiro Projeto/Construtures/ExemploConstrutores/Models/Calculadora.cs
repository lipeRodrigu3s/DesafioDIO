namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public void Somar(int X, int Y)
        {
            System.Console.WriteLine($"Adição {X} + {Y}");
        }

        public void Subtrair(int X, int Y)
        {
            System.Console.WriteLine($"Subtração {X} - {Y}");
        }

    }

}