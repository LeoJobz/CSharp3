﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankPlus.Funcionarios
{
    //classe abstrata
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome {get; set;}
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;

            Salario = salario;
                
            TotalDeFuncionarios++;
        }

        //public virtual void para permitir override sem obrigatoriedade
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();        

    }
}
