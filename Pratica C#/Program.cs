using System;
using Pratica_C.Models;

namespace Pratica
{
    class Program
    {
        static void MudarNome(Pessoa p1, string NewName)
        {
            p1.Name = NewName;
        }

        
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            
            p1.Name = "Fellipe";
            p1.Age = 22;
            p1.Document = "709";

            MudarNome(p1, "Arthur");

            Console.WriteLine($"O nono usuario é: {p1.Name}");

            
            
            
            
        }
    }
}