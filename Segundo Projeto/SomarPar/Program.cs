using System; 

namespace SomarPar
{
    class program   
    {
        static void Main()
        {   
            
            int x;
            Console.WriteLine("informe o numero: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (int n = 1; n <= 5; n++)
            {
                if (x % 2 == 0)
                {
                   do
                   {
                       x = x + 2;
                       Console.WriteLine(x);
                   } 
                   while (n <= 5);

                   
                }
            }
        }
    }
}
