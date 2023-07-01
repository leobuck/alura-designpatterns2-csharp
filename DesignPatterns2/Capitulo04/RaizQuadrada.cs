using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public class RaizQuadrada : IExpressao
{
    private IExpressao radicando;

    public RaizQuadrada(IExpressao radicando)
    {
        this.radicando = radicando;
    }

    public int Avalia()
    {
        int valorRadicando = radicando.Avalia();
        return (int)Math.Sqrt(valorRadicando);
    }
}
