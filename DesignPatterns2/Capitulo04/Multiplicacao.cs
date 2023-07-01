﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo04;

public class Multiplicacao : IExpressao
{
    private IExpressao esquerda;
    private IExpressao direita;

    public Multiplicacao(IExpressao esquerda, IExpressao direita)
    {
        this.esquerda = esquerda;
        this.direita = direita;
    }

    public int Avalia()
    {
        int valorEsquerda = esquerda.Avalia();
        int valorDireita = direita.Avalia();
        return valorEsquerda * valorDireita;
    }
}
