using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo07;

public class PagaPedido : IComando
{
    private Pedido pedido;

    public PagaPedido(Pedido pedido)
    {
        this.pedido = pedido;
    }

    public void Executa()
    {
        Console.WriteLine($"Pagando o pedido do cliente {pedido.Cliente}.");
        pedido.Paga();
    }
}
