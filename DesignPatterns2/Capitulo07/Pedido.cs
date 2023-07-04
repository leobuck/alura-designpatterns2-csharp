using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo07;

public class Pedido
{
    public Pedido(string cliente, double valor)
    {
        Cliente = cliente;
        Valor = valor;
        Status = Status.Novo;
    }

    public string Cliente { get; private set; }
    public double Valor { get; private set; }
    public DateTime DataFinalizacao { get; private set; }
    public Status Status { get; private set; }

    public void Paga()
    {
        Status = Status.Pago;
    }

    public void Finaliza()
    {
        Status = Status.Entregue;
        DataFinalizacao = DateTime.Now;
    }
}
