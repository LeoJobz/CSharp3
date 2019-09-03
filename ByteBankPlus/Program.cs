using ByteBankPlus.Funcionarios;
using ByteBankPlus.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Funcionario carlos = new Funcionario(2000, "546.879.157-20");

            //carlos.Nome = "Carlos";

            //carlos.AumentarSalario();
            //Console.WriteLine("Novo Salário Carlos: " + carlos.Salario);

            //Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //gerenciador.Registrar(carlos);


            //Diretor roberta = new Diretor(5000, "454.658.148-3");

            //roberta.Nome = "Roberta";

            //Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //roberta.AumentarSalario();
            //Console.WriteLine("Novo Salário Roberta: " + roberta.Salario);


            //gerenciador.Registrar(roberta);


            //Console.WriteLine(carlos.Nome);
            //Console.WriteLine(carlos.GetBonificacao());

            //Console.WriteLine(roberta.Nome);
            //Console.WriteLine(roberta.GetBonificacao());

            //Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            //calcularBonificacao();

            UsarSistema();

            Console.ReadLine();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("811.896.980-05");

            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("968.916.470-88");
            camila.Nome = "Camila";
            camila.Senha = "1234";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "1234");

            sistemaInterno.Logar(parceiro, "123456");
        }

        public static void calcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("795.853.560-07");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("811.896.980-05");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("505.393.400-22");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("968.916.470-88");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());

        }

    }
}
