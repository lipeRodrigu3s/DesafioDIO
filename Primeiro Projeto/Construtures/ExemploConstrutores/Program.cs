using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class program
    {
        public void Main(string[] args)
        {
            log log = log.GetInstance();

            log.PropriedadeLog = "Teste Instancia";

            log log2 = log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);


            //Pessoa p1 = new Pessoa("Fellipe", "Augusto");
            //p1.Apresentar();
        }
    }
}