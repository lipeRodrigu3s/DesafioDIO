﻿using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class program
    {
        public delegate void Operacao(int X, int Y); 
        public void Main(string[] args)
        {

            Operacao op = new Operacao(Calculadora.Somar);


            
            //const double pi = 3.14;
           //System.Console.WriteLine(pi);

            //Data data = new Data();
            //data.SetMês(2);

            //data.mês = 12;
            //System.Console.WriteLine(data.mês);

            //data.ApresentarMês();

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