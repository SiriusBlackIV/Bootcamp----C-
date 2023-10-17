using System;

public class Celular
{
    public string NumeroTelefone { get; set; }

    public void FazerChamada(string numero)
    {
        Console.WriteLine($"Chamando {numero}...");
    }

    public void EnviarMensagem(string numero, string mensagem)
    {
        Console.WriteLine($"Enviando mensagem para {numero}: {mensagem}");
    }
}

public abstract class Marca
{
    public string Nome { get; set; }

    public abstract void Ligar();
    public abstract void Desligar();
}

public abstract class Modelo
{
    public string Nome { get; set; }

    public abstract void EnviarSMS();
    public abstract void NavegarInternet();
}

public class Samsung : Marca
{
    public override void Ligar()
    {
        Console.WriteLine("Ligando o celular Samsung");
    }

    public override void Desligar()
    {
        Console.WriteLine("Desligando o celular Samsung");
    }
}

public class iPhone : Marca
{
    public override void Ligar()
    {
        Console.WriteLine("Ligando o iPhone");
    }

    public override void Desligar()
    {
        Console.WriteLine("Desligando o iPhone");
    }
}

public class GalaxyS21 : Modelo
{
    public override void EnviarSMS()
    {
        Console.WriteLine("Enviando SMS a partir do Galaxy S21");
    }

    public override void NavegarInternet()
    {
        Console.WriteLine("Navegando na Internet a partir do Galaxy S21");
    }
}

public class iPhone12 : Modelo
{
    public override void EnviarSMS()
    {
        Console.WriteLine("Enviando SMS a partir do iPhone 12");
    }

    public override void NavegarInternet()
    {
        Console.WriteLine("Navegando na Internet a partir do iPhone 12");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Marca samsungPhone = new Samsung();
        samsungPhone.Ligar();

        Marca iphonePhone = new iPhone();
        iphonePhone.Ligar();

        Modelo galaxy = new GalaxyS21();
        galaxy.EnviarSMS();

        Modelo iphoneModel = new iPhone12();
        iphoneModel.NavegarInternet();
    }
}
