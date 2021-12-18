using System;

namespace contador
{
    class program
    {
        static void contadorif(string[] args)
        {
            Console.ReadLine();
            
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("temos um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }

        }
    }
}    
