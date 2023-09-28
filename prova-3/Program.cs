using prova_3.Classes;
using System;

public class Program
{
    static void Main(string[] args)
    {
        // Variaveis
        int opcao = 0;

        // Objetos


        // Outros


        // Cogido
        Console.WriteLine(" 1 - CADASTRAR FUNCIONÁRIO\n");
        Console.Write("ESCOLHA UMA OPÇÃO: ");

        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            // - Cadastrar funcionario
            case 1:
                Sistema.ListarFuncionarios();
            break;
        }

        // Fim
    }
}