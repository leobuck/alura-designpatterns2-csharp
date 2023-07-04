using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Capitulo07;

public class FilaDeTrabalho
{
    private IList<IComando> comandos = new List<IComando>();

    public void Adiciona(IComando comando)
    {
        comandos.Add(comando);
    }

    public void Processa()
    {
        foreach (var comando in comandos)
        {
            comando.Executa();
        }
    }
}
