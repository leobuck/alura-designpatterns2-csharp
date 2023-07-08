namespace DesignPatterns2.Capitulo09;

public class Cobranca
{
    public Cobranca(TipoCobranca tipo, Fatura fatura)
    {
        Tipo = tipo;
        Fatura = fatura;
    }

    public TipoCobranca Tipo { get; set; }
    public Fatura Fatura { get; set; }

    public void Emite()
    {
        Console.WriteLine($"Emitindo cobrança do cliente {Fatura.Cliente.Cpf}...");
    }
}