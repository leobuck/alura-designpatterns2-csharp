using DesignPatterns2.Capitulo05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public class Divisao : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Divisao(IExpressao esquerda, IExpressao direita)
    {
        Esquerda = esquerda;
        Direita = direita;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeDivisao(this);
    }

    public int Avalia()
    {
        int valorEsquerda = Esquerda.Avalia();
        int valorDireita = Direita.Avalia();
        return valorEsquerda / valorDireita;
    }
}
