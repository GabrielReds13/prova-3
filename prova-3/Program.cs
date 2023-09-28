using prova_3.Classes;
using System;

public class Program
{
    static void Main(string[] args)
    {
        // Variaveis
        int opcao = 0, erro = 0;
        string[] tipo = {"", "Médico", "Adiministrativo"};

        // Funcionario
        string nome, cpf, sexo;
        DateTime dataNascimento;
        double salario;

        // Medico
        string crm = "";
        double valorHoraExtra = 0;
        string especialidade = "";

        // Outros


        // Cogido
        while(true)
        {
            Console.WriteLine(" 1 - CADASTRAR FUNCIONÁRIO\n");
            Console.Write("ESCOLHA UMA OPÇÃO: ");

            opcao = int.Parse(Console.ReadLine());

            Console.Clear();
            while (true)
            {
                switch (opcao)
                {
                    // - Cadastrar funcionario
                    case 1:
                        Console.WriteLine("\nNOME: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("\nCPF: ");
                        cpf = Console.ReadLine();

                        Console.WriteLine("\nSEXO: ");
                        sexo = Console.ReadLine();

                        Console.WriteLine("\nDATA DE NASCIMENTO: ");
                        dataNascimento = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("\nSALÁRIO: ");
                        salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nTIPO: ");
                        Console.WriteLine("\n 0 - FUNCIONÁRIO");
                        Console.WriteLine("\n 1 - MÉDICO");
                        Console.WriteLine("\n 2 - ADIMINISTRATIVO");

                        opcao = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 0:
                                Sistema.CadastrarFuncionario(nome, cpf, dataNascimento, sexo, salario, tipo[opcao], crm, valorHoraExtra, especialidade);
                                erro = 0;
                                break;

                            case 1:
                                Console.WriteLine("\nCRM: ");
                                crm = Console.ReadLine();

                                Console.WriteLine("\nESPECIALIDADE: ");
                                especialidade = Console.ReadLine();

                                Console.WriteLine("\nVALOR DA HORA EXTRA: ");
                                salario = double.Parse(Console.ReadLine());

                                Sistema.CadastrarFuncionario(nome, cpf, dataNascimento, sexo, salario, tipo[opcao], crm, valorHoraExtra, especialidade);
                                erro = 0;
                                break;

                            case 2:
                                Sistema.CadastrarFuncionario(nome, cpf, dataNascimento, sexo, salario, tipo[opcao], crm, valorHoraExtra, especialidade);
                                erro = 0;
                                break;

                            default:
                                Console.WriteLine("\n - OPÇÃO INVÁLIDA -\n");
                                erro = 1;
                                break;
                        }

                        break;
                }

                Console.Clear();

                if (erro == 1) { }
                else Sistema.ListarFuncionarios();

                Console.WriteLine("DESEJA CONTINUAR CADASTRANDO (0 - SIM; 1 - NÃO) ?");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 0) break;
            }

        }



        // Fim
    }
}