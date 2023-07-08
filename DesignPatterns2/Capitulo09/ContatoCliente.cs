using DesignPatterns2.Capitulo08;

namespace DesignPatterns2.Capitulo09;

public class ContatoCliente
{
    public ContatoCliente(Cliente cliente, Cobranca cobranca)
    {
        Cliente = cliente;
        Cobranca = cobranca;
    }

    public Cliente Cliente { get; set; }
    public Cobranca Cobranca { get; set; }

    public void Dispara()
    {
        Console.WriteLine($"Disparando contato para o cliente {Cliente.Cpf}...");
    }
}