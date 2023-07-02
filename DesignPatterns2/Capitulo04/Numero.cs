using DesignPatterns2.Capitulo05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public class Numero : IExpressao
{
    public int Valor { get; private set; }

    public Numero(int numero)
    {
        Valor = numero;
    }

    public int Avalia()
    {
        return Valor;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeNumero(this);
    }
}
