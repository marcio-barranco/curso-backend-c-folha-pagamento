namespace FolhaPagamento
{
    class Program
    {
        static void Main()
        {

            var funcionario = new List<Funcionario>();
            int opcao;
            string nome = "";
            double salario = 0;
            double comissao = 0;
            int horas = 0;
            double total = 0;

            do
            {
                Console.WriteLine("\n----- Opções -----");
                Console.WriteLine("1 - Cadastrar Horista");
                Console.WriteLine("2 - Cadastrar Assalariado");
                Console.WriteLine("3 - Cadastrar Comissionado");
                Console.WriteLine("4 - Listar folha de pagamento");
                Console.WriteLine("0 - Sair");

                Console.WriteLine("Escolha: ");
                opcao = int.Parse(Console.ReadLine() ?? "0");

                if (!(opcao == 0 || opcao == 4))
                {
                    Console.WriteLine("Informe o nome: ");
                    nome = Console.ReadLine() ?? "(nome não informado)";

                    if (opcao == 1)
                    {
                        Console.WriteLine("Informe o salário por hora: ");
                        salario = double.Parse(Console.ReadLine() ?? "0");

                        Console.WriteLine("Informe as horas trabalhadas: ");
                        horas = int.Parse(Console.ReadLine() ?? "0");
                    }
                    else
                    {
                        Console.WriteLine("Informe o salário mensal: ");
                        salario = double.Parse(Console.ReadLine() ?? "0");
                    }

                    if (opcao == 3)
                    {
                        Console.WriteLine("Informe a comissão em percentual (1,1 para 10%, 1,2 para 20%, por exemplo): ");
                        comissao = double.Parse(Console.ReadLine() ?? "0");
                    }
                }

                switch (opcao)
                {
                    case 1:
                        funcionario.Add(new Horista(nome, salario, horas));
                        break;
                    case 2:
                        funcionario.Add(new Assalariado(nome, salario));
                        break;
                    case 3:
                        funcionario.Add(new Comissionado(nome, salario, comissao));
                        break;
                    case 4:
                        total = 0;
                        Console.WriteLine("\n----- Folha de Pagamento -----");
                        foreach (var item in funcionario)
                        {
                            item.InformacaoSalario();
                            total += item.ValorSalario();
                        }
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"----- Total: R$ {total:F2} -----");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\n(pressione qualquer tecla para continuar)");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }


            } while (opcao != 0);


        }
    }
}
