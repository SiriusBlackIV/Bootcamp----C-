using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

class Suite
{
    public string Tipo { get; set; }
    public double ValorDiaria { get; set; }

    public Suite(string tipo, double valorDiaria)
    {
        Tipo = tipo;
        ValorDiaria = valorDiaria;
    }
}

class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suite Suite { get; set; }
    public int QuantidadeDias { get; set; }

    public Reserva(Pessoa hospede, Suite suite, int quantidadeDias)
    {
        Hospede = hospede;
        Suite = suite;
        QuantidadeDias = quantidadeDias;
    }

    public double CalcularValorTotal()
    {
        double valorTotal = Suite.ValorDiaria * QuantidadeDias;

        if (QuantidadeDias > 10)
        {
            valorTotal *= 0.9; // Aplica desconto de 10% para reservas com mais de 10 dias
        }

        return valorTotal;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospede.Idade >= 18 ? 1 : 0; // Conta 1 hóspede se for maior de idade
    }
}
class Program
{
    static void Main()
    {
        Pessoa hospede = new Pessoa("Alice", 25);
        Suite suite = new Suite("Presidencial", 200.0);
        Reserva reserva = new Reserva(hospede, suite, 15);

        Console.WriteLine($"Nome do hóspede: {reserva.Hospede.Nome}");
        Console.WriteLine($"Tipo da suíte: {reserva.Suite.Tipo}");
        Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Quantidade de dias: {reserva.QuantidadeDias}");
        Console.WriteLine($"Valor total da reserva: R${reserva.CalcularValorTotal():F2}");

        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }
}