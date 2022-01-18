using System;
using Colecoes.helper;
using System.Linq;

namespace Colecoes
{
    class program
    {
        static void Main(string[] args)
        {   
            int[] arrayNumeros = new int[6] {2, 9, 8, 7, 10, 50};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo {maximo}");
            System.Console.WriteLine($"Medio: {Medio}");





            // var NumerosParesQuery = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num 
            //     select num;

            // var NumerosParesMetodo = arrayNumeros.where(x => x % 2 == 0).orderby(x => x).ToList();       

            // System.Console.WriteLine("Numeros pares query:" + string.Join("," , NumerosParesQuery));
            // System.Console.WriteLine("Numeros pares metodo: " + string.Join(", " ,NumerosParesMetodo));



            // list<string> estados = new list<string>();
            // estados.Add("PE");
            // estados.Add("SP");
            // estados.Add("PA"); 

            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] {8, 3, 5, 1, 9 };
            // int[] arrayCopia = new int[20];  

            //System.Console.WriteLine("Array original: ");

            //op.ImprimirArray(array);

            //op.OrdenarBubbleSort(array);
            //op.Ordenar(ref array);

            //System.Console.WriteLine("Array Ordenado: ");
            //op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da copia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array depois da copia: ");
            // op.ImprimirArray(arrayCopia);

            // int[,]Matrix = new int [3, 2]
            // {
            //     {8, 9},
            //     {8, 8},
            //     {0, 5}
            // };

            // for (int i = 0; i < Matrix.GetLength(0); i++)
            // {
            //     for (int c = 0; c < Matrix.GetLength(1); c++)
            //     {
            //         System.Console.WriteLine(Matrix[i, c]);
            //     }
            // }

            // Matrix[0, 0] = 5;
            // Matrix[0, 1] = 6;

            // int[] arrayInteiros = new int[5];

            // arrayInteiros[0] = 5;
            // arrayInteiros[1] = 4;
            // arrayInteiros[2] = 7;
            // arrayInteiros[3] = 10;
            // arrayInteiros[4] = 80;
            
            // System.Console.WriteLine("Trilhando o array pelo for");

            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }
            // System.Console.WriteLine("Trilhando o array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
