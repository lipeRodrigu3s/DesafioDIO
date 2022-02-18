using System.IO;

var Path = Environment.CurrentDirectory + "\\Teste.txt";

var Tx = File.CreateText(Path);
Tx.WriteLine("Primeiro arquivo criado");
Tx.Flush();

