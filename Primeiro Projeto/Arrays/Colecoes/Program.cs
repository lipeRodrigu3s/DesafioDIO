﻿using System;

namespace Colecoes
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[5];

            arrayInteiros[0] = 5;
            arrayInteiros[1] = 4;
            arrayInteiros[2] = 7;
            arrayInteiros[3] = 10;
            arrayInteiros[4] = 80;
            
            System.Console.WriteLine("Trilhando o array pelo for");

            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine(arrayInteiros[i]);
            }
            System.Console.WriteLine("Trilhando o array pelo foreach");
            foreach (int item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
