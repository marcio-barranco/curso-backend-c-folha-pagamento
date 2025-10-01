namespace FolhaPagamento;

public class Comissionado : Funcionario
{
    public double Comissao { get; set; }

    public Comissionado(string nome, double salario, double comissao) : base(nome, salario)
    {
        Comissao = comissao;
    }

    public override void InformacaoSalario()
    {
        Console.WriteLine($"O salário do funcionário {Nome} é R$ {Comissao * Salario:F2}.");
    }

    public override double ValorSalario()
    {
        return Comissao * Salario;
    }

}
