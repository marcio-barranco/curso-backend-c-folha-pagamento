namespace FolhaPagamento;

public class Horista : Funcionario
{

    public int Horas { get; set; }

    public Horista(string nome, double salario, int horas) : base(nome, salario)
    {
        Horas = horas;
    }

    public override void InformacaoSalario()
    {
        Console.WriteLine($"O salário do funcionário {Nome} é R$ {Horas * Salario:F2}.");
    }

    public override double ValorSalario()
    {
        return Horas * Salario;
    }
}
