using System.IO;

System.Console.WriteLine("Digete o nome do arquivo: ");
var Name = Console.ReadLine();
Name = CleanName(Name);

foreach (var @char in Path.GetInvalidFileNameChars())
{
    Name = Name.Replace(@char, '*');
}

var path = Path.Combine(Environment.CurrentDirectory, $"{Name}.txt");

NewFile(path);

System.Console.WriteLine("Pressiona enter para finalizar");
Console.ReadLine();

static string CleanName(string Name)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        Name = Name.Replace(@char, '*');
    }
        return Name;
}

static void NewFile(string Path)
{
    try
    {
        var Tx = File.CreateText(Path);
        Tx.WriteLine("Primeiro arquivo criado");
        Tx.Flush();
    }
    catch 
    {
        System.Console.WriteLine("Nome de Arquio invalido");
    }

   
}



