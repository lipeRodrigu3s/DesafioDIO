using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine("1- Cadastrar novo Aluno");
            Console.WriteLine("2- Lista de Alunos");
            Console.WriteLine("3- Calcular media geral");
            Console.WriteLine("4- Sair");

            Console.WriteLine();

            string EscolhaUsuario = Console.ReadLine();

            while (EscolhaUsuario.ToUpper() != "4")
            {
                switch(EscolhaUsuario)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();            
                }
            }
        }
    }
}