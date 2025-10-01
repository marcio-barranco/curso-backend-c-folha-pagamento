namespace FolhaPagamento;

public class Funcionario
{
    private double salario;
    private string nome;
    public string Nome
    {
        get { return nome; }
        set
        {
            if (value == "" || value == null)
                Console.WriteLine("Não é possível informar um nome vazio");
            else
                nome = value;
        }
    }

    public double Salario
    {
        get { return salario; }
        set
        {
            if (value < 0)
                Console.WriteLine("Não é permitido salário negativo!");
            else
                salario = value;
        }
    }

    public Funcionario(string nome, double salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public virtual void InformacaoSalario()
    {
        Console.WriteLine($"O salário do funcionário {Nome} é R$ {Salario:F2}");
    }

    public virtual double ValorSalario()
    {
        return Salario;
    }


}
