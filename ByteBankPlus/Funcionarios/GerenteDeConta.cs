using ByteBankPlus.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankPlus.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        //chamando construtor da classe pai - Funcionário
    
        public GerenteDeConta (string cpf) : base (4000, cpf)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
