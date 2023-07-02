using DesignPatterns2.Capitulo05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public class Subtracao : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Subtracao(IExpressao esquerda, IExpressao direita)
    {
        Esquerda = esquerda;
        Direita = direita;
    }

    public int Avalia()
    {
        int valorEsquerda = Esquerda.Avalia();
        int valorDireita = Direita.Avalia();
        return valorEsquerda - valorDireita;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeSubtracao(this);
    }
}
