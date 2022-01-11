using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class program
    {
        public void Main(string[] args)
        {
            Data data = new data();
            data.SetMês(2);

            data.mês = 12;
            System.Console.WriteLine(data.mês);

            data.ApresentarMês();

            //log log = log.GetInstance();

            //log.PropriedadeLog = "Teste Instancia";

            //log log2 = log.GetInstance();
            //System.Console.WriteLine(log2.PropriedadeLog);

            //Aluno p1 = new Aluno();
            //p1.Apresentar();

            //Pessoa p1 = new Pessoa("Fellipe", "Augusto");
            //p1.Apresentar();


        }
    }
}