using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo03;

public class Historico
{
    private IList<Estado> Estados = new List<Estado>();

    public void Adiciona(Estado estado)
    {
        Estados.Add(estado);
    }

    public Estado Pega(int indice)
    {
        return Estados[indice];
    }
}
