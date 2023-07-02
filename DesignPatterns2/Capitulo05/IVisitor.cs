using DesignPatterns2.Capitulo04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo05;

public interface IVisitor
{
    void ImprimeSoma(Soma soma);
    void ImprimeSubtracao(Subtracao subtracao);
    void ImprimeNumero(Numero numero);
    void ImprimeMultiplicacao(Multiplicacao multiplicacao);
    void ImprimeDivisao(Divisao divisao);
    void ImprimeRaizQuadrada(RaizQuadrada raiz);
}
