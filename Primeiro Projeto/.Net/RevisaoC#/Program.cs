using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = obteropcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        aluno.nota = Console.ReadLine();
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
        private static string obteropcaoUsuario()
        {
            Console.WriteLine("Escolha uma das opções abaixo");
            Console.WriteLine("1- Cadastrar novo Aluno");
            Console.WriteLine("2- Lista de Alunos");
            Console.WriteLine("3- Calcular media geral");
            Console.WriteLine("4- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
            

        }
    }
}

