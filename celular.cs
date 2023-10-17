// Classe base para representar um celular genérico
public class Celular
{
    public string NumeroTelefone { get; set; }

    public void FazerChamada(string numero)
    {
        // Implementação para fazer uma chamada
    }

    public void EnviarMensagem(string numero, string mensagem)
    {
        // Implementação para enviar mensagem
    }
}

// Classe base para representar uma marca de celular
public abstract class Marca
{
    public string Nome { get; set; }

    public abstract void Ligar();
    public abstract void Desligar();
}

// Classe base para representar um modelo de celular
public abstract class Modelo
{
    public string Nome { get; set; }

    public abstract void EnviarSMS();
    public abstract void NavegarInternet();
}

// Exemplo de classes concretas que herdam de Marca e Modelo
public class Samsung : Marca
{
    public override void Ligar()
    {
        // Implementação específica para ligar um celular Samsung
    }

    public override void Desligar()
    {
        // Implementação específica para desligar um celular Samsung
    }
}

public class iPhone : Marca
{
    public override void Ligar()
    {
        // Implementação específica para ligar um iPhone
    }

    public override void Desligar()
    {
        // Implementação específica para desligar um iPhone
    }
}

public class GalaxyS21 : Modelo
{
    public override void EnviarSMS()
    {
        // Implementação específica para enviar SMS em um Galaxy S21
    }

    public override void NavegarInternet()
    {
        // Implementação específica para navegar na Internet em um Galaxy S21
    }
}

public class iPhone12 : Modelo
{
    public override void EnviarSMS()
    {
        // Implementação específica para enviar SMS em um iPhone 12
    }

    public override void NavegarInternet()
    {
        // Implementação específica para navegar na Internet em um iPhone 12
    }
}
