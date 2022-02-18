using System.IO;

System.Console.WriteLine("Digete o nome do arquivo: ");
var Name = Console.ReadLine();
var path = Path.Combine(Environment.CurrentDirectory, $"{Name}.txt");

NewFile(path);

static void NewFile(string Path)
{
    var Tx = File.CreateText(Path);
    Tx.WriteLine("Primeiro arquivo criado");
    Tx.Flush();
}



