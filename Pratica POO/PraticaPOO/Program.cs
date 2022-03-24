using System;
using PraticaPOO.Models;

namespace PraticaPOO
{
    class Program
    {
        static void Main()
        {
            // instanciado a Conta
            Conta conta1 = new Conta("Bando do Brasil, 007", 7000);

            // Alterando o Valor do saldo da conta 
            //conta1.Depositar(5000);
        

            bool Sacar = conta1.Sacar(6000);

            if(Sacar)
            {
                Double Saldo = conta1.Extrato();

                Console.WriteLine(@"Agencia: " + conta1.Agencia + 
                " Meu saldo é: " + Saldo);
            }

            

            
        
        
        }
        
    }
}






