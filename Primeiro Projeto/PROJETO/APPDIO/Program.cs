using system;

namespace APPDIO
{
    class program
    {
        static void Main(string[] args)
        {
            

            System.Console.WriteLine("Hello World");
        }   

        private static string ObterOpcaoCliente()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("App da Dio sempre aqui por voce!");
            System.Console.WriteLine("Informe a melhor opcao pra voce: ");

            System.Console.WriteLine("Listar Catalogo de Codigos");
            System.Console.WriteLine("1, Mostrar Codigos");
            System.Console.WriteLine("2, Inserir novo Codigo");
            System.Console.WriteLine("3, Atualizar Codigo ");
            System.Console.WriteLine("4, Excluir Codigo");
            System.Console.WriteLine("5, Visualizar Codigo");
            System.Console.WriteLine("C, Limpar Area ");
            System.Console.WriteLine("X, Ate mais! ");

            string ObterOpcaoCliente = Console.Readline().ToUpper();
            System.Console.WriteLine();
            return ObterOpcaoCliente;



        }











    }
}