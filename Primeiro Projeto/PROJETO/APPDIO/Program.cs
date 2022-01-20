using system;

namespace APPDIO
{
    class program
    {
        static void Main(string[] args)
        {
            string ObterOpcaoCliente = ObterOpcaoCliente();

            while (ObterOpcaoCliente.ToUpper() != "X")
            {
                 switch (ObterOpcaoCliente)
                 {
                    case "1":
                        listarCodigo();
                        break;  

                    case "2":
                        InserirCodigo();
                        break;

                    case "3":
                        AtualizarCodigo();
                        break;

                    case "4":   
                        ExcluirCodigo();
                        break;

                    case "5":
                        VisualizarCodigo();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:            
                        throw new  ArgumentOutOfRangeException();
                 }
                 ObterOpcaoCliente = ObterOpcaoCliente();
            }
                System.Console.WriteLine("Obrigado por ultilizar nosso App.");
                Console.Readline();
        }   
        private static void listarCodigo()
        {
            System.Console.WriteLine("Listar Codigo");

            var Lista = reporsitorio.Lista();
            if (Lista.Count == 0)       
            {
                System.Console.WriteLine("Nenhum Codigo encontrado");
                return;
            }

            foreach (var Codigo in Lista)
            {
                System.Console.WriteLine("#ID {0}: - {1}", Codigo.retornaID(), Codigo.retornaTitulo());
            }
        }

        private  static void InserirCodigo()
        {
            System.Console.WriteLine("Insira uma Novo Codigo");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite qual tipo de codigo lhe agrada: ");
            int entradaGenero = int.Parse(Console.Readline());

            System.Console.WriteLine("Digite o Titulo do Codigo: ");
            string entradaTitulo = Console.Readline();

            System.Console.WriteLine("Digite a Data do codigo: ");
            int entradaData = int.Parse(Console.Readline());

            System.Console.WriteLine("Digite a Sinopse do Codigo: ");
            string entradaSinopse = Console.Readline();
            



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