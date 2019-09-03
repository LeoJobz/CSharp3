using ByteBankPlus.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankPlus.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
       //chamando construtor da classe pai - Funcionário
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        //polimorfismo
        public override double GetBonificacao()
        {
            return Salario * 0.5;

        }

        

    }
}

