using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public class Numero : IExpressao
{
    private int numero;

    public Numero(int numero)
    {
        this.numero = numero;
    }

    public int Avalia()
    {
        return numero;
    }
}
