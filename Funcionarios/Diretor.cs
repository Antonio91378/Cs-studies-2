namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        override public double getBonificacao()
        {
            // usando a palavra base que remete ao método da classe base 
            return Salario + base.getBonificacao();
        }
    }
}
