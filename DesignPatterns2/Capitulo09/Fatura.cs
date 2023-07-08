using DesignPatterns2.Capitulo08;

namespace DesignPatterns2.Capitulo09;

public class Fatura
{
    public Fatura(Cliente cliente, double valor)
    {
        Cliente = cliente;
        Valor = valor;
    }

    public Cliente Cliente { get; set; }
    public double Valor { get; set; }
}