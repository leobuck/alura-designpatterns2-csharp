using DesignPatterns2.Capitulo05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public class RaizQuadrada : IExpressao
{
    public IExpressao Radicando { get; private set; }

    public RaizQuadrada(IExpressao radicando)
    {
        Radicando = radicando;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeRaizQuadrada(this);
    }

    public int Avalia()
    {
        int valorRadicando = Radicando.Avalia();
        return (int)Math.Sqrt(valorRadicando);
    }
}
