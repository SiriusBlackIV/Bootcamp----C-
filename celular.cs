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

public class Marca
{
    public string Nome { get; set; }

    public virtual void Ligar()
    {
        Console.WriteLine("Ligando o celular da marca " + Nome);
    }

    public virtual void Desligar()
    {
        Console.WriteLine("Desligando o celular da marca " + Nome);
    }
}

public class Modelo
{
    public string Nome { get; set; }

    public virtual void EnviarSMS()
    {
        Console.WriteLine("Enviando SMS a partir do modelo " + Nome);
    }

    public virtual void NavegarInternet()
    {
        Console.WriteLine("Navegando na Internet a partir do modelo " + Nome);
    }
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
        Samsung samsungPhone = new Samsung();
        samsungPhone.Ligar();
        samsungPhone.EnviarSMS();

        iPhone iphonePhone = new iPhone();
        iphonePhone.Ligar();
        iphonePhone.NavegarInternet();
    }
}
