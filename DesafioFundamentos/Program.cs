using System;
using DesafioDIO1.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
        Console.Write("Digite o preço inicial: ");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Agora digite o preço por hora: ");
        decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1-Cadastrar veículo");
            Console.WriteLine("2-Remover veículo");
            Console.WriteLine("3-Listar veículos");
            Console.WriteLine("4-Encerrar o sistema");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a placa do veículo: ");
                    string placaCadastrar = Console.ReadLine();
                    estacionamento.CadastrarVeiculo(placaCadastrar);
                    Pausar();
                    break;

                case "2":
                    Console.Write("Digite a placa do veículo para remover: ");
                    string placaRemover = Console.ReadLine();
                    Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    estacionamento.RemoverVeiculo(placaRemover, horas);
                    Pausar();
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    Pausar();
                    break;

                case "4":
                    Console.WriteLine("Encerrando o sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Pausar();
                    break;
            }
        }
    }

    static void Pausar()
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
}
