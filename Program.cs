using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        BonificacaoMeneger gerenciador = new BonificacaoMeneger();
        Console.WriteLine("Bem-vindo ao ByteBank Administração");

        Funcionario joao = new Funcionario();
        joao.Nome = "Joao Pinto da Silva";
        joao.Cpf = "12123123";
        joao.Salario = 5000;

        Diretor pedro = new Diretor();
        pedro.Nome = "pedro Pinto da Silva";
        pedro.Cpf = "12123123";
        pedro.Salario = 10000;

        gerenciador.Registrar(joao);
        gerenciador.Registrar(pedro);

        Console.WriteLine("Bonificação: " + joao.getBonificacao());
        Console.WriteLine("Bonificação: " + pedro.getBonificacao());
        System.Console.WriteLine(gerenciador.TotalBonificacao);
    }
}