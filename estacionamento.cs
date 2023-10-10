using System;
using System.Collections.Generic;

class Veiculo
{
    public string Placa { get; set; }
    public DateTime HoraEntrada { get; set; }
}

class Estacionamento
{
    private List<Veiculo> veiculos = new List<Veiculo>();

    public void AdicionarVeiculo(string placa)
    {
        Veiculo veiculo = new Veiculo { Placa = placa, HoraEntrada = DateTime.Now };
        veiculos.Add(veiculo);
        Console.WriteLine($"Veículo de placa {placa} estacionado com sucesso.");
    }

    public void RemoverVeiculo(string placa)
    {
        Veiculo veiculo = veiculos.Find(v => v.Placa == placa);
        if (veiculo != null)
        {
            TimeSpan tempoEstacionado = DateTime.Now - veiculo.HoraEntrada;
            double valorCobrado = tempoEstacionado.TotalHours * 10; // Exemplo de taxa por hora.
            Console.WriteLine($"Veículo de placa {placa} removido. Valor cobrado: R$ {valorCobrado:F2}");
            veiculos.Remove(veiculo);
        }
        else
        {
            Console.WriteLine($"Veículo de placa {placa} não encontrado no estacionamento.");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veículos estacionados:");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Hora de Entrada: {veiculo.HoraEntrada}");
        }
    }
}

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();
        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Informe a placa do veículo: ");
                    string placa = Console.ReadLine();
                    estacionamento.AdicionarVeiculo(placa);
                    break;
                case "2":
                    Console.Write("Informe a placa do veículo a ser removido: ");
                    placa = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placa);
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
