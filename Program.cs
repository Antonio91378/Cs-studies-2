using bytebank_ADM.Funcionarios;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao ByteBank Administração");

        Funcionario joao = new Funcionario();
        joao.nome = "Joao Pinto da Silva";
        joao.cpf = "12123123";
        joao.salario = 5000;

        Console.WriteLine("Bonificação: " + joao.getBonificacao());
    }
}